using Bogus.DataSets;
using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;

namespace Voice_Tale.Main.Voice_Commands.Text_Editor
{
    partial class FileEditor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FileEditor));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            FileName = new Label();
            RedoButton = new PictureBox();
            UndoButton = new PictureBox();
            MainBox = new RichTextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)RedoButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)UndoButton).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(29, 30, 20);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(FileName);
            panel1.Controls.Add(RedoButton);
            panel1.Controls.Add(UndoButton);
            panel1.Location = new Point(-1, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(1502, 43);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(168, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(38, 38);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // FileName
            // 
            FileName.AutoSize = true;
            FileName.Font = new System.Drawing.Font("Corbel", 10F, FontStyle.Bold);
            FileName.ForeColor = Color.White;
            FileName.Location = new Point(747, 10);
            FileName.Name = "FileName";
            FileName.Size = new Size(36, 21);
            FileName.TabIndex = 2;
            FileName.Text = "File";
            FileName.Click += FileName_Click;
            // 
            // RedoButton
            // 
            RedoButton.BackgroundImageLayout = ImageLayout.Stretch;
            RedoButton.Cursor = Cursors.Hand;
            RedoButton.Image = (System.Drawing.Image)resources.GetObject("RedoButton.Image");
            RedoButton.Location = new Point(70, 5);
            RedoButton.Name = "RedoButton";
            RedoButton.Size = new Size(38, 38);
            RedoButton.TabIndex = 1;
            RedoButton.TabStop = false;
            RedoButton.Click += RedoButton_Click;
            // 
            // UndoButton
            // 
            UndoButton.BackgroundImageLayout = ImageLayout.Stretch;
            UndoButton.Cursor = Cursors.Hand;
            UndoButton.Image = (System.Drawing.Image)resources.GetObject("UndoButton.Image");
            UndoButton.Location = new Point(26, 5);
            UndoButton.Name = "UndoButton";
            UndoButton.Size = new Size(38, 35);
            UndoButton.TabIndex = 0;
            UndoButton.TabStop = false;
            UndoButton.Click += UndoButton_Click;
            // 
            // MainBox
            // 
            MainBox.BackColor = Color.FromArgb(29, 30, 38);
            MainBox.Cursor = Cursors.IBeam;
            MainBox.Font = new System.Drawing.Font("Corbel", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            MainBox.ForeColor = Color.White;
            MainBox.Location = new Point(12, 62);
            MainBox.Name = "MainBox";
            MainBox.Size = new Size(1477, 799);
            MainBox.TabIndex = 2;
            MainBox.Text = "Loading....";
            MainBox.TextChanged += MainBox_TextChanged;
            // 
            // FileEditor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(29, 30, 38);
            ClientSize = new Size(1501, 873);
            Controls.Add(MainBox);
            Controls.Add(panel1);
            MaximizeBox = false;
            Name = "FileEditor";
            Text = "ToadText Editor";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)RedoButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)UndoButton).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private RichTextBox MainBox;
        private PictureBox UndoButton;
        private PictureBox RedoButton;
        private Label FileName;
        private PictureBox pictureBox1;
    }
}