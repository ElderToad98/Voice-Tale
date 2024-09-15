using System;
using System.Windows.Forms;
using System.Linq;

namespace Voice_Tale.Main.Voice_Commands
{
    public partial class variables : Form
    {
        private readonly DatabaseOperations _dbOps;

        public variables()
        {
            InitializeComponent();
            _dbOps = new DatabaseOperations();
        }

        private void VariableSaving_Load(object sender, EventArgs e)
        {
            RefreshVariableList();
        }

        private void RefreshVariableList()
        {
            VariableList.Items.Clear();
            var variables = _dbOps.LoadVariables();
            VariableList.Items.AddRange(variables.Keys.ToArray());
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            string variableName = VariableName.Text.Trim();
            string variableValue = VariableValue.Text.Trim();

            if (string.IsNullOrEmpty(variableName) || variableName.ToLower() == "dynamic int")
            {
                MessageBox.Show("Please enter a valid variable name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                _dbOps.SaveVariable(variableName, variableValue);
                MessageBox.Show($"Variable '{variableName}' saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                RefreshVariableList();
                ClearInputFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving variable: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (VariableList.SelectedItem == null)
            {
                MessageBox.Show("Please select a variable to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string variableName = VariableList.SelectedItem.ToString();
            if (MessageBox.Show($"Are you sure you want to delete the variable '{variableName}'?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    _dbOps.DeleteVariable(variableName);
                    MessageBox.Show($"Variable '{variableName}' deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    RefreshVariableList();
                    ClearInputFields();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error deleting variable: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void VariableList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (VariableList.SelectedItem != null)
            {
                string variableName = VariableList.SelectedItem.ToString();
                var variables = _dbOps.LoadVariables();
                if (variables.TryGetValue(variableName, out string variableValue))
                {
                    VariableName.Text = variableName;
                    VariableValue.Text = variableValue;
                }
            }
        }

        private void ClearInputFields()
        {
            VariableName.Clear();
            VariableValue.Clear();
            VariableList.SelectedIndex = -1;
        }

        private void Info_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This form allows you to manage variables for Voice Tale.\n\n" +
                            "- To add a new variable, enter the name and value, then click 'Save Variable'.\n" +
                            "- To edit an existing variable, select it from the list, modify its value, then click 'Save Variable'.\n" +
                            "- To delete a variable, select it from the list and click 'Delete Variable'.",
                            "Variable Management Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void File_Click(object sender, EventArgs e)
        {
            MessageBox.Show("File operations are not implemented yet.", "Coming Soon", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}