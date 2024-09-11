using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Voice_Tale.Main.Voice_Commands.Execution;
using Townsharp.Infrastructure.Configuration;
using Townsharp.Infrastructure.Consoles;
using Townsharp.Infrastructure;
using System.Data.SQLite;

namespace Voice_Tale.Main.Modules
{
    public partial class ManualCommand : Form
    {
        IConsoleClient consoleClient;
        DatabaseOperations dbop;
        MiscOperations op;
        public ManualCommand()
        {
            InitializeComponent();
            dbop = new DatabaseOperations();
            op = new MiscOperations();
        }

        private async void Send_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(Command.Text))
            {
                MessageBox.Show("Command can not be empty!");
                return;
            }

            var cmd = await consoleClient.RunCommandAsync(Command.Text);

            if (ShowJson.Checked)
            {
                MessageBox.Show($"Command JSON:\n\n{cmd.ResultString}");
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

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private async void ManualCommand_Load(object sender, EventArgs e)
        {
            await ConnectToServerAsync();
        }
    }
}
