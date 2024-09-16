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
        private readonly MiscOperations op;

        public MainMenu()
        {
            InitializeComponent();
            dbop = new DatabaseOperations();
            specifiedName = dbop.GetName();
            op = new MiscOperations();
        }

        // Main Info Button
        private void MainInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Hello {specifiedName}!\nWelcome to the wonderful menu of Voice Tale!\n\nThis is the space where you can gain access to all sorts of things, such as command creation, command execution, and much more!\n\nVersion: M1");
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



        private void Youtube_Click_1(object sender, EventArgs e) {

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

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }

        private void manualCommandButton_Click(object sender, EventArgs e)
        {

            op.OpenForm<ManualCommand>();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            op.OpenForm<variables>();

        }
        

    }
}