using System;
using System.IO;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Voice_Tale.Main.Voice_Commands.Text_Editor;

namespace Voice_Tale.Main.Voice_Commands.Text_Editor
{
    public partial class Search : Form
    {
        private FileEditor parentForm;

        public Search(FileEditor parent)
        {
            InitializeComponent();
            parentForm = parent;
        }

        private async void textBox1_TextChanged(object sender, EventArgs e)
        {
            parentForm.HighlightText(textBox1.Text);
            await SaveFileContentAsync();
        }

        private async Task SaveFileContentAsync()
        {
            string savePath = GetSelectedFilePath();
            try
            {
                if (File.Exists(savePath))
                {
                    await File.WriteAllTextAsync(savePath, textBox1.Text);
                }
                else
                {
                    MessageBox.Show("Error occurred retrieving save file.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}\n\nStack Trace: {ex.StackTrace}");
            }
        }

        private string GetSelectedFilePath()
        {
            string executablePath = Application.ExecutablePath;
            string executableDirectory = Path.GetDirectoryName(executablePath);
            string filePath = Path.Combine(executableDirectory, "SearchQuery.txt");
            if (!File.Exists(filePath))
            {
                File.WriteAllText(filePath, "");
            }
            return filePath;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Search_Load(object sender, EventArgs e)
        {

        }
    }
}