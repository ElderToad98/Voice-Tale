using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Voice_Tale.Main.Voice_Commands.Text_Editor
{
    public partial class FileEditor : Form
    {
        private Stack<string> undoStack = new Stack<string>();
        private Stack<string> redoStack = new Stack<string>();
        private bool isUndoRedo = false;
        DatabaseOperations dbop;

        public FileEditor()
        {
            InitializeComponent();
            UpdateUndoRedoButtons();
            dbop = new DatabaseOperations();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            await HandleLoadSavedFileAsync();

        }

        private async Task HandleLoadSavedFileAsync()
        {
            string filePath = dbop.GetFilePath("commands.txt");
            try
            {
                if (File.Exists(filePath))
                {
                    string fileContent = await File.ReadAllTextAsync(filePath);
                    MainBox.Text = fileContent;
                    undoStack.Push(fileContent);
                    UpdateUndoRedoButtons();

                    FileName.Text = Path.GetFileName(filePath);
                }
                else
                {
                    MessageBox.Show("Error occurred retrieving file.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}\n\nStack Trace: {ex.StackTrace}");
            }
        }

        private async void MainBox_TextChanged(object sender, EventArgs e)
        {
            if (!isUndoRedo)
            {
                undoStack.Push(MainBox.Text);
                redoStack.Clear();
                await SaveFileContentAsync();
            }
            UpdateUndoRedoButtons();
        }

        private async Task SaveFileContentAsync()
        {
            string savePath = dbop.GetFilePath("commands.txt");
            int maxRetries = 3;
            int retryDelayMs = 100;

            for (int i = 0; i < maxRetries; i++)
            {
                try
                {
                    using (FileStream fs = new FileStream(savePath, FileMode.Open, FileAccess.ReadWrite, FileShare.None))
                    using (StreamWriter sw = new StreamWriter(fs))
                    {
                        await sw.WriteAsync(MainBox.Text);
                        return; // Successfully saved, exit the method
                    }
                }
                catch (IOException ex) when (i < maxRetries - 1)
                {
                    // If it's not the last attempt, wait and then try again
                    await Task.Delay(retryDelayMs);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}\n\nStack Trace: {ex.StackTrace}");
                    return; // Exit on any other exception
                }
            }

            MessageBox.Show("Unable to save the file after multiple attempts. The file may be in use by another process.");
        }



        private void RedoButton_Click(object sender, EventArgs e)
        {
            if (redoStack.Count > 0)
            {
                isUndoRedo = true;
                string redoText = redoStack.Pop();
                undoStack.Push(redoText);
                MainBox.Text = redoText;
                isUndoRedo = false;
            }
            UpdateUndoRedoButtons();
        }

        private void UndoButton_Click(object sender, EventArgs e)
        {
            if (undoStack.Count > 1)
            {
                isUndoRedo = true;
                string currentText = undoStack.Pop();
                redoStack.Push(currentText);
                MainBox.Text = undoStack.Peek();
                isUndoRedo = false;
            }
            UpdateUndoRedoButtons();
        }

        private void UpdateUndoRedoButtons()
        {
            UndoButton.Enabled = undoStack.Count > 1;
            RedoButton.Enabled = redoStack.Count > 0;
        }

        private void FileName_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Search search = new Search(this);
            search.Show();
        }

        public void HighlightText(string searchText)
        {
            if (string.IsNullOrEmpty(searchText))
            {
                MainBox.SelectionStart = 0;
                MainBox.SelectionLength = MainBox.Text.Length;
                MainBox.SelectionBackColor = MainBox.BackColor;
                return;
            }

            int index = 0;
            MainBox.SelectionStart = 0;
            MainBox.SelectionLength = MainBox.Text.Length;
            MainBox.SelectionBackColor = MainBox.BackColor;

            while (index < MainBox.Text.Length)
            {
                int foundIndex = MainBox.Text.IndexOf(searchText, index, StringComparison.OrdinalIgnoreCase);
                if (foundIndex < 0)
                    break;

                MainBox.SelectionStart = foundIndex;
                MainBox.SelectionLength = searchText.Length;
                MainBox.SelectionBackColor = Color.Brown;

                index = foundIndex + searchText.Length;
            }
        }





    }
}