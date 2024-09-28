using System;
using System.Diagnostics;
using System.Windows.Forms;
using Voice_Tale.Main;
using Voice_Tale.Main.Modules;
using Voice_Tale.Main.Voice_Commands;
using DiscordRPC;
using DiscordRPC.Logging;
using static System.Windows.Forms.AxHost;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Speech.Recognition;
using System.Data.SQLite;

namespace Voice_Tale
{
    public partial class MainMenu : Form
    {
        private readonly DatabaseOperations dbop;
        private readonly string specifiedName;
        private readonly MiscOperations op;
        private static DiscordRpcClient client;
        static SpeechRecognitionEngine recognizer = new SpeechRecognitionEngine();

        public MainMenu(MiscOperations op)
        {
            this.op = op ?? throw new ArgumentNullException(nameof(op));
            InitializeComponent();

            dbop = new DatabaseOperations();
            specifiedName = dbop.GetName();


            if (dbop.IsVoiceShortcuts())
            {
                recognizer.SetInputToDefaultAudioDevice();
                recognizer.LoadGrammar(CreateGrammar()); // Load predefined grammar for recognition
                recognizer.SpeechRecognized += Recognizer_SpeechRecognized;
                recognizer.RecognizeAsync(RecognizeMode.Multiple); // Keep listening
            }
        }


        private static void Recognizer_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            DatabaseOperations dbop = new DatabaseOperations();
            MiscOperations op = new MiscOperations();
            if (e.Result.Confidence <= dbop.GetConfidence())
            {
                return;
            }

            string recognizedText = e.Result.Text.ToLower();

            switch (recognizedText)
            {
                case "open settings":
                    op.OpenForm<Settings>();
                    break;

                case "open command creation":
                    op.OpenForm<Creation>();
                    break;

                case "open manual command sender":
                    op.OpenForm<ManualCommand>();
                    break;

                case "open command execution":
                    op.OpenForm<Execution>();
                    break;

                case "open variable creation":
                    op.OpenForm<variables>();
                    break;


            }
        }

        // Voice shortcut grammar
        private static Grammar CreateGrammar()
        {
            Choices commands = new Choices();
            commands.Add(new string[] { "open settings",
                                        "open command creation",
                                        "open manual command sender",
                                        "open command execution",
                                        "open variable creation"
                                         });

            GrammarBuilder grammarBuilder = new GrammarBuilder(commands);
            return new Grammar(grammarBuilder);
        }

        // Main Info Button
        private void MainInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Hello {specifiedName}!\nWelcome to the wonderful menu of Voice Tale!\n\nThis is the space where you can gain access to all sorts of things, such as command creation, command execution, and much more!\n\nVersion: M2");
        }


        #region side panel
        private void Settings_Click(object sender, EventArgs e)
        {
            op.OpenForm<Settings>();

        }

        private void Discord_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"Are you sure you want to open Discord?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                OpenUrl("https://discord.gg/u7AVjUt2kZ");
            }
        }



        private void Youtube_Click_1(object sender, EventArgs e)
        {

            if (MessageBox.Show($"Are you sure you want to open Youtube?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                OpenUrl("https://www.youtube.com/@eldertoad98");
            }

        }


        private void Github_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show($"Are you sure you want to open Github?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                OpenUrl("https://github.com/ElderToad98/Voice-Tale/tree/master");
            }
        }


        #endregion


        // This opens a url, duh
        private static void OpenUrl(string url)
        {
            try
            {
                Process.Start(new ProcessStartInfo(url) { UseShellExecute = true });
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while opening the URL: {ex.Message}");
            }
        }


        // This opens the command creation window
        private void CommandCreate_Click(object sender, EventArgs e)
        {

            op.OpenForm<Creation>();

        }


        // This opens the command execution window
        private void button1_Click(object sender, EventArgs e)
        {

            op.OpenForm<Execution>();


        }

        private void manualCommandButton_Click(object sender, EventArgs e)
        {

            op.OpenForm<ManualCommand>();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            op.OpenForm<variables>();

        }




        private async void MainMenu_Load(object sender, EventArgs e)
        {
            if (!dbop.IsPresence())
            {
                return;
            }

            await op.RPCInit();
            await UpdateRPC();
           
        }

        private async Task UpdateRPC()
        {
            while (true)
            {
                // Wait asynchronously for 5 seconds
                await Task.Delay(5000);



                // Get the active form
                var activeForm = Form.ActiveForm;
                if (activeForm is null)
                {
                    op.ChangeDiscordRPC("Idling!");
                    continue; // Exit the loop if no active form
                }


                var formName = activeForm.Name;


                //MessageBox.Show($"Focused Form: {formName}");
                var rpc = "";

                switch (formName)
                {
                    case ("MainMenu"):
                        rpc = "In The Menu!";
                        break;
                    case ("Settings"):
                        rpc = "Changing Settings!";
                        break;
                    case ("Execution"):
                        rpc = "Executing Voice Commands!";
                        break;
                    case ("Creation"):
                        rpc = "Creating Voice Commands!";
                        break;
                    case ("variables"):
                        rpc = "Making Variables!";
                        break;
                    case ("ManualCommand"):
                        rpc = "Executing Manual Commands!";
                        break;
                    default:
                        rpc = "Having Fun!";
                        break;
                }

                //MessageBox.Show(rpc);
                op.ChangeDiscordRPC(rpc);

            }
        }

        private void contentPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}