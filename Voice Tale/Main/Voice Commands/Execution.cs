using Bogus.Bson;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Recognition;
using Townsharp.Infrastructure;
using Townsharp.Infrastructure.Configuration;
using Townsharp.Infrastructure.Consoles;
using Voice_Tale.Properties;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Security.Cryptography;
using Voice_Tale.Main.Voice_Commands.Text_Editor;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Header;
using System.Speech.Synthesis;

namespace Voice_Tale.Main.Voice_Commands
{
    public partial class Execution : Form
    {
        private DatabaseOperations dbop;
        private Dictionary<string, int> serverDictionary = new Dictionary<string, int>();
        private bool isConnecting = false;
        private IConsoleClient consoleClient;
        private MiscOperations op;
        private SpeechRecognitionEngine recognizer;

        public Execution()
        {
            InitializeComponent();

            dbop = new DatabaseOperations();
            op = new MiscOperations();

            InitializeSpeechRecognition();



        }

        private async void InitializeSpeechRecognition()
        {
            recognizer = new SpeechRecognitionEngine();
            // Loads grammar
            var commands = new Choices();
            var rawCommands = dbop.GetAllCommandNames();
            if (rawCommands.Count == 0)
            {
                MessageBox.Show("No commands found. Please add at least one command before initializing speech recognition.");
                return;
            }
            foreach (var rawCommand in rawCommands)
            {
                commands.Add(rawCommand);
                if (!commandList.Items.Contains(rawCommand))
                {
                    commandList.Items.Add(rawCommand);
                }
            }
            var grammarBuilder = new GrammarBuilder();
            grammarBuilder.Append(commands);
            var grammar = new Grammar(grammarBuilder);
            recognizer.LoadGrammar(grammar);
            // Event handlers
            recognizer.SpeechRecognized += Recognizer_SpeechRecognized;
            // Configures input
            recognizer.SetInputToDefaultAudioDevice();
            // Continuous recognition
            recognizer.RecognizeAsync(RecognizeMode.Multiple);
            await ConnectToServerAsync();
        }


        // When speech is recognized
        private async void Recognizer_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            if (e.Result.Confidence < dbop.GetConfidence())
            {
                return;
            }

            var recognizedText = e.Result.Text;

            var cmds = dbop.GetCommandByName(recognizedText);
            if (consoleClient is not null)
            {
                foreach (var cmd in cmds)
                {
                    try
                    {
                        //MessageBox.Show(cmd);
                        await consoleClient.RunCommandAsync(cmd);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Unexpected error occurred when running command '{cmd}' in '{recognizedText}'\n\n{ex}");
                        return;
                    }
                }
            }
            else
            {
                MessageBox.Show("No active server connection. Please connect to a server before executing commands.");
            }

            if (dbop.IsBeep() && dbop.IsVoice())
            {
                SpeechSynthesizer s = new SpeechSynthesizer();

                Console.Beep();
                s.Speak(recognizedText);
                commandLog.Items.Add(recognizedText);
                return;
            }

            else if (dbop.IsBeep())
            {
                Console.Beep();
                commandLog.Items.Add(recognizedText);
                return;
            }

            else if (dbop.IsVoice())
            {
                SpeechSynthesizer s = new SpeechSynthesizer();
                s.Speak(recognizedText);
                commandLog.Items.Add(recognizedText);
                return;
            }





        }

        // ApiResponse for server connection
        public class ApiResponse
        {
            [JsonProperty("message")]
            public string? Message { get; set; }

            [JsonProperty("error_code")]
            public string? ErrorCode { get; set; }
        }


        // File button click
        private void File_Click(object sender, EventArgs e)
        {
            FileEditor f = new FileEditor();
            f.ShowDialog();

        }

        // When the info button is clicked
        private void Info_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Welcome to the Command Executer!\n\nThis is the place where you can execute your own voice commands!\n\nTo use commands, configure your server ID in the settings in the main menu!");
        }


        // When the form loads
        private async void Execution_Load(object sender, EventArgs e)
        {
            try
            {
                isConnecting = true;
                await ConnectToServerAsync();
                connLabel.Text = "Connected Server: " + dbop.GetServerId().ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unexpected error when attempting to connect to the server\n\n{ex}");
            }
            finally
            {
                isConnecting = false;
            }
        }


        // Connects to the server using creds from the db
        private async Task ConnectToServerAsync()
        {

            // Get's variables from the database
            var serverId = dbop.GetServerId();
            var userName = dbop.GetUsername();
            var userPasswordHash = dbop.GetPasswordHash();
            var password = dbop.GetPassword();

            // Essential t# stuff
            var userCreds = new UserCredential(userName, userPasswordHash, password);
            var builder = Builders.CreateUserClientBuilder(userCreds);
            var webApiClient = builder.BuildWebApiClient();

            // Bot cred stuff for debug

            //var botCreds = BotCredential.FromEnvironmentVariables();
            //var bbuilder = Builders.CreateBotClientBuilder(botCreds);
            //var bwebApiClient = bbuilder.BuildWebApiClient();


            try
            {
                //Console.Beep(); // debug

                // Requests console access and deserializes the json attatched

                var req = await webApiClient.RequestConsoleAccessAsync(serverId);
                //var req2 = await bwebApiClient.RequestConsoleAccessAsync(serverId);

                ApiResponse response = JsonConvert.DeserializeObject<ApiResponse>(req.RawJson.ToJsonString());


                // Handles the json
                var handle = await op.HandleServerConnectionJson(response.Message);
                //Console.Beep(); // debug

                // If the connection is rejected

                if (!handle)
                {
                    this.Close();
                    return;
                }



                //MessageBox.Show(serverId.ToString()); MessageBox.Show(webApiClient.ToString());

                Task<IConsoleClient> buildTask = Task.Run(() => builder.BuildConsoleClient(webApiClient, serverId));

                // Wait for the build task with a timeout
                if (await Task.WhenAny(buildTask, Task.Delay(TimeSpan.FromSeconds(30))) == buildTask)
                {
                    consoleClient = await buildTask;
                    if (consoleClient == null)
                    {
                        throw new Exception("Failed to build console client.");
                    }
                    //Console.Beep(); 
                    //MessageBox.Show("Successfully connected to the server.");
                }

                CancellationTokenSource cancellationTokenSource = new CancellationTokenSource(); // used to end the session.

                await consoleClient.ConnectAsync(cancellationTokenSource.Token); // Connect the client to the console endpoint.



                //consoleClient = bbuilder.BuildConsoleClient(bwebApiClient, serverId);

                //Console.Beep(); // This never beeps

                if (consoleClient == null)
                {
                    throw new Exception("Failed to build console client.");
                }


            }
            catch (Exception ex)
            {
                throw new Exception($"Error during server connection: {ex.Message}");
            }
        }

        private void mainPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CommandList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void mainPanel_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void mainPanel_Paint_2(object sender, PaintEventArgs e)
        {

        }

        private void File_Click_1(object sender, EventArgs e)
        {
            FileEditor f = new FileEditor();
            f.ShowDialog();
        }
    }
}