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
using Voice_Tale.Properties;

namespace Voice_Tale.Main.Voice_Commands
{

    public partial class Creation : Form
    {
        DatabaseOperations dbop;
        public Creation()
        {
            InitializeComponent();

            dbop = new DatabaseOperations();
        }


        // This gets the file of the commands txt file
        private void File_Click(object sender, EventArgs e)
        {
            var filePath = dbop.GetFilePath("commands.txt");

            try
            {
                Process.Start("explorer.exe", filePath);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to open the path: {ex.Message}");
            }
        }


        // This saves the command entered
        private void Save_Click(object sender, EventArgs e)
        {



            if (Commands.Text.Length == 0)
            {
                MessageBox.Show("Please put both a command name and the commands!");
            }

            if (Commands.Text.Length == 0)
            {
                MessageBox.Show("Please enter your command(s)!");
                return;
            }

            if (CommandName.Text.Length == 0 || CommandName.Text.Length >= 30)
            {
                MessageBox.Show("Please enter a valid command name!");
                return;
            }

            string filePath = dbop.GetFilePath("commands.txt");

            var commands = Commands.Text;
            var name = CommandName.Text;

            dbop.SaveCommand(name, commands);

            MessageBox.Show($"Added Command '{name}'!");
        }

        private void Creation_Load(object sender, EventArgs e)
        {

        }


        // Info box
        private void Info_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Hey {dbop.GetName()}!\nWelcome to the Command Creation Area!\n\nThis area is made for creating custom voice commands!\nThis is an early version of what it will be!\n\nClick the file icon to open the txt file containing your commands for easy command sharing between your friends!");
        }
    }
}
