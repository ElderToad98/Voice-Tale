using System;
using System.Windows.Forms;
using System.Linq;
using Voice_Tale.Main.Voice_Commands.Text_Editor;

namespace Voice_Tale.Main.Voice_Commands
{
    public partial class Creation : Form
    {
        private readonly DatabaseOperations _dbOps;

        public Creation()
        {
            InitializeComponent();
            _dbOps = new DatabaseOperations();
        }

        private void Creation_Load(object sender, EventArgs e)
        {
            RefreshCommandList();
        }

        private void RefreshCommandList()
        {
            // Assuming you want to add a ComboBox to show existing commands
            CommandList.Items.Clear();
            var commands = _dbOps.GetAllCommandNames();
            CommandList.Items.AddRange(commands.ToArray());
        }

        private async void Save_Click(object sender, EventArgs e)
        {
            string commandName = CommandName.Text.Trim();
            string commands = Commands.Text.Trim();

            

            if (string.IsNullOrEmpty(commandName))
            {
                MessageBox.Show("Please enter a valid command name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(commands))
            {
                MessageBox.Show("Please enter your command(s).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (commandName.Length >= 100)
            {
                MessageBox.Show("Command name must be less than 100 characters.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                bool success = _dbOps.SaveCommand(commandName, commands);
                if (success)
                {
                    MessageBox.Show($"Command '{commandName}' saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RefreshCommandList();
                    ClearInputFields();
                    await MiscOperations.SendWebhookMessage($"{_dbOps.GetUsername()} Created a Command!", commandName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving command: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (CommandList.SelectedItem == null)
            {
                MessageBox.Show("Please select a command to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string commandName = CommandList.SelectedItem.ToString();
            if (MessageBox.Show($"Are you sure you want to delete the command '{commandName}'?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    _dbOps.DeleteCommand(commandName);
                    MessageBox.Show($"Command '{commandName}' deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RefreshCommandList();
                    ClearInputFields();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error deleting command: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void CommandList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CommandList.SelectedItem != null)
            {
                string commandName = CommandList.SelectedItem.ToString();
                List<string> commandStrings = _dbOps.GetRawCommandByName(commandName);
                if (commandStrings.Any())
                {
                    CommandName.Text = commandName;
                    Commands.Text = string.Join(",", commandStrings);
                }
            }
        }

        private void ClearInputFields()
        {
            CommandName.Clear();
            Commands.Clear();
            CommandList.SelectedIndex = -1;
        }

        private void File_Click(object sender, EventArgs e)
        {
            FileEditor fileEditor = new FileEditor();
            fileEditor.ShowDialog();
        }

        private void Info_Click(object sender, EventArgs e)
        {
            string userName = _dbOps.GetName();
            MessageBox.Show($"Hey {userName}!\n\nWelcome to the Command Creation Area!\n\n" +
                            "This area is made for creating custom voice commands.\n" +
                            "- To add a new command, enter the name and commands, then click 'Save'.\n" +
                            "- To edit an existing command, select it from the list, modify it, then click 'Save'.\n" +
                            "- To delete a command, select it from the list and click 'Delete'.\n" +
                            "- Click the file icon to open the txt file containing your commands for easy sharing.",
                            "Command Creation Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}