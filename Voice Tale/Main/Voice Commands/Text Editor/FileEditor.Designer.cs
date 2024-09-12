using System;
using System.Drawing;
using System.Windows.Forms;

namespace Voice_Tale.Main.Voice_Commands.Text_Editor
{
    partial class FileEditor
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

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
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1000, 50);
            panel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(958, 9);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(32, 32);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // FileName
            // 
            FileName.Anchor = AnchorStyles.None;
            FileName.AutoSize = true;
            FileName.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            FileName.ForeColor = Color.White;
            FileName.Location = new Point(450, 11);
            FileName.Name = "FileName";
            FileName.Size = new Size(107, 28);
            FileName.TabIndex = 1;
            FileName.Text = "File Name";
            FileName.TextAlign = ContentAlignment.MiddleCenter;
            FileName.Click += FileName_Click;
            // 
            // RedoButton
            // 
            RedoButton.Cursor = Cursors.Hand;
            RedoButton.Image = (Image)resources.GetObject("RedoButton.Image");
            RedoButton.Location = new Point(50, 9);
            RedoButton.Name = "RedoButton";
            RedoButton.Size = new Size(32, 32);
            RedoButton.SizeMode = PictureBoxSizeMode.Zoom;
            RedoButton.TabIndex = 2;
            RedoButton.TabStop = false;
            RedoButton.Click += RedoButton_Click;
            // 
            // UndoButton
            // 
            UndoButton.Cursor = Cursors.Hand;
            UndoButton.Image = (Image)resources.GetObject("UndoButton.Image");
            UndoButton.Location = new Point(10, 9);
            UndoButton.Name = "UndoButton";
            UndoButton.Size = new Size(32, 32);
            UndoButton.SizeMode = PictureBoxSizeMode.Zoom;
            UndoButton.TabIndex = 3;
            UndoButton.TabStop = false;
            UndoButton.Click += UndoButton_Click;
            // 
            // MainBox
            // 
            MainBox.BackColor = Color.FromArgb(29, 30, 38);
            MainBox.BorderStyle = BorderStyle.None;
            MainBox.Dock = DockStyle.Fill;
            MainBox.Font = new Font("Consolas", 12F);
            MainBox.ForeColor = Color.White;
            MainBox.Location = new Point(0, 50);
            MainBox.Name = "MainBox";
            MainBox.Size = new Size(1000, 550);
            MainBox.TabIndex = 0;
            MainBox.Text = "";
            MainBox.TextChanged += MainBox_TextChanged;
            // 
            // FileEditor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(29, 30, 38);
            ClientSize = new Size(1000, 600);
            Controls.Add(MainBox);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(800, 450);
            Name = "FileEditor";
            Text = "Voice Tale | Toad Text";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)RedoButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)UndoButton).EndInit();
            ResumeLayout(false);
        }

        private Panel panel1;
        private RichTextBox MainBox;
        private PictureBox UndoButton;
        private PictureBox RedoButton;
        private Label FileName;
        private PictureBox pictureBox1;
    }
}