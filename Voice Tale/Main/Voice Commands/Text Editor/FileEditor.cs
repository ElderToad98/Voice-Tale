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
        private readonly Stack<string> undoStack = new Stack<string>();
        private readonly Stack<string> redoStack = new Stack<string>();
        private bool isUndoRedo = false;
        private readonly DatabaseOperations dbop;
        private readonly string filePath;
        private System.Threading.Timer autoSaveTimer;
        private bool isInitialLoad = true;

        public FileEditor()
        {
            InitializeComponent();
            dbop = new DatabaseOperations();
            filePath = dbop.GetFilePath("commands.txt");

            this.Load += FileEditor_Load;
        }

        private async void FileEditor_Load(object sender, EventArgs e)
        {
            await HandleLoadSavedFileAsync();

            // Set up auto-save timer (every 30 seconds) after initial load
            autoSaveTimer = new System.Threading.Timer(AutoSave, null, TimeSpan.FromSeconds(30), TimeSpan.FromSeconds(30));
        }

        private async Task HandleLoadSavedFileAsync()
        {
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
                    MessageBox.Show("File not found. A new file will be created when you start typing.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading the file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                isInitialLoad = false;
            }
        }

        private async void MainBox_TextChanged(object sender, EventArgs e)
        {
            if (!isUndoRedo && !isInitialLoad)
            {
                undoStack.Push(MainBox.Text);
                redoStack.Clear();
                await SaveFileContentAsync();
            }
            UpdateUndoRedoButtons();
        }

        private async Task SaveFileContentAsync()
        {
            int maxRetries = 5;
            int retryDelayMs = 100;

            for (int i = 0; i < maxRetries; i++)
            {
                try
                {
                    await File.WriteAllTextAsync(filePath, MainBox.Text);
                    return; // Successfully saved, exit the method
                }
                catch (IOException) when (i < maxRetries - 1)
                {
                    // If it's not the last attempt, wait and then try again
                    await Task.Delay(retryDelayMs * (i + 1)); // Exponential backoff
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred while saving: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; // Exit on any other exception
                }
            }

            MessageBox.Show("Unable to save the file after multiple attempts. The file may be in use by another process.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void AutoSave(object state)
        {
            if (!IsDisposed && IsHandleCreated)
            {
                BeginInvoke(new Action(() => SaveFileContentAsync()));
            }
        }

        private void RedoButton_Click(object sender, EventArgs e)
        {
            if (redoStack.Count > 0)
            {
                isUndoRedo = true;
                string redoText = redoStack.Pop();
                undoStack.Push(MainBox.Text);
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
                redoStack.Push(MainBox.Text);
                undoStack.Pop();
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
                MainBox.SelectionBackColor = Color.Yellow;

                index = foundIndex + searchText.Length;
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
          
            autoSaveTimer?.Dispose();
        }
    }
}