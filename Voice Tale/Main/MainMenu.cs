using System;
using System.Diagnostics;
using System.Windows.Forms;
using Voice_Tale.Main;
using Voice_Tale.Main.Modules;
using Voice_Tale.Main.Voice_Commands;

namespace Voice_Tale
{
    public partial class MainMenu : Form
    {
        private readonly DatabaseOperations dbop;
        private readonly string specifiedName;

        public MainMenu()
        {
            InitializeComponent();
            dbop = new DatabaseOperations();
            specifiedName = dbop.GetName();
        }

        // Main Info Button
        private void MainInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Hello {specifiedName}!\nWelcome to the wonderful menu of Voice Tale!\n\nThis is the space where you can gain access to all sorts of things, such as command creation, command execution, and much more!\n\nVersion: M1");
        }


        #region side panel
        private void Settings_Click(object sender, EventArgs e)
        {
            Settings s = new Settings();

            s.ShowDialog();

        }

        private void Discord_Click(object sender, EventArgs e) => OpenUrl("https://discord.gg/u7AVjUt2kZ");

        private void Youtube_Click_1(object sender, EventArgs e) => OpenUrl("https://www.youtube.com/@eldertoad98");

        private void Github_Click_1(object sender, EventArgs e) => OpenUrl("https://github.com/ElderToad98/Voice-Tale/tree/master");

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

            Creation c = new Creation();

            c.ShowDialog();

        }


        // This opens the command execution window
        private void button1_Click(object sender, EventArgs e)
        {
            Execution ex = new Execution();
            ex.ShowDialog();


        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }

        private void manualCommandButton_Click(object sender, EventArgs e)
        {
            ManualCommand manualCommand = new ManualCommand();
            manualCommand.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            variables v = new variables();
            v.ShowDialog();

        }
    }
}