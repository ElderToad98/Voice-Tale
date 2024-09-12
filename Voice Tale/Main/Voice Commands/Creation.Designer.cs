namespace Voice_Tale.Main.Voice_Commands
{
    partial class Creation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Creation));
            panel1 = new Panel();
            File = new PictureBox();
            Info = new PictureBox();
            mainPanel = new Panel();
            label3 = new Label();
            label2 = new Label();
            Save = new PictureBox();
            Commands = new TextBox();
            CommandsLabel = new Label();
            CommandName = new TextBox();
            CommandNameLabel = new Label();
            TitleLabel = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)File).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Info).BeginInit();
            mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Save).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(114, 137, 218);
            panel1.Controls.Add(File);
            panel1.Controls.Add(Info);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(80, 553);
            panel1.TabIndex = 9;
            // 
            // File
            // 
            File.Cursor = Cursors.Hand;
            File.Image = (Image)resources.GetObject("File.Image");
            File.Location = new Point(14, 254);
            File.Name = "File";
            File.Size = new Size(51, 62);
            File.SizeMode = PictureBoxSizeMode.Zoom;
            File.TabIndex = 16;
            File.TabStop = false;
            File.Click += File_Click;
            // 
            // Info
            // 
            Info.Cursor = Cursors.Hand;
            Info.Image = (Image)resources.GetObject("Info.Image");
            Info.Location = new Point(14, 32);
            Info.Name = "Info";
            Info.Size = new Size(51, 62);
            Info.SizeMode = PictureBoxSizeMode.Zoom;
            Info.TabIndex = 10;
            Info.TabStop = false;
            Info.Click += Info_Click;
            // 
            // mainPanel
            // 
            mainPanel.BackColor = Color.FromArgb(35, 39, 42);
            mainPanel.Controls.Add(label3);
            mainPanel.Controls.Add(label2);
            mainPanel.Controls.Add(Save);
            mainPanel.Controls.Add(Commands);
            mainPanel.Controls.Add(CommandsLabel);
            mainPanel.Controls.Add(CommandName);
            mainPanel.Controls.Add(CommandNameLabel);
            mainPanel.Controls.Add(TitleLabel);
            mainPanel.Dock = DockStyle.Fill;
            mainPanel.Location = new Point(80, 0);
            mainPanel.Name = "mainPanel";
            mainPanel.Padding = new Padding(20);
            mainPanel.Size = new Size(814, 553);
            mainPanel.TabIndex = 10;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.ForeColor = Color.FromArgb(153, 170, 181);
            label3.Location = new Point(609, 509);
            label3.Name = "label3";
            label3.Size = new Size(185, 24);
            label3.TabIndex = 17;
            label3.Text = "Don't forget to save!!";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label2.AutoSize = true;
            label2.ForeColor = Color.FromArgb(153, 170, 181);
            label2.Location = new Point(23, 509);
            label2.Name = "label2";
            label2.Size = new Size(215, 24);
            label2.TabIndex = 16;
            label2.Text = "This is in very early beta!";
            // 
            // Save
            // 
            Save.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            Save.Cursor = Cursors.Hand;
            Save.Image = (Image)resources.GetObject("Save.Image");
            Save.Location = new Point(660, 406);
            Save.Name = "Save";
            Save.Size = new Size(100, 100);
            Save.SizeMode = PictureBoxSizeMode.Zoom;
            Save.TabIndex = 15;
            Save.TabStop = false;
            Save.Click += Save_Click;
            // 
            // Commands
            // 
            Commands.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            Commands.BackColor = Color.FromArgb(64, 68, 75);
            Commands.BorderStyle = BorderStyle.FixedSingle;
            Commands.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Commands.ForeColor = Color.White;
            Commands.Location = new Point(23, 234);
            Commands.Name = "Commands";
            Commands.PlaceholderText = "time set 9,time set 10,time set 11";
            Commands.Size = new Size(768, 34);
            Commands.TabIndex = 13;
            // 
            // CommandsLabel
            // 
            CommandsLabel.AutoSize = true;
            CommandsLabel.ForeColor = Color.FromArgb(153, 170, 181);
            CommandsLabel.Location = new Point(23, 206);
            CommandsLabel.Name = "CommandsLabel";
            CommandsLabel.Size = new Size(456, 24);
            CommandsLabel.TabIndex = 14;
            CommandsLabel.Text = "Command(s) to Execute (Commands Separated by ',')";
            // 
            // CommandName
            // 
            CommandName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            CommandName.BackColor = Color.FromArgb(64, 68, 75);
            CommandName.BorderStyle = BorderStyle.FixedSingle;
            CommandName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CommandName.ForeColor = Color.White;
            CommandName.Location = new Point(23, 144);
            CommandName.Name = "CommandName";
            CommandName.PlaceholderText = "Make it Day";
            CommandName.Size = new Size(768, 34);
            CommandName.TabIndex = 11;
            // 
            // CommandNameLabel
            // 
            CommandNameLabel.AutoSize = true;
            CommandNameLabel.ForeColor = Color.FromArgb(153, 170, 181);
            CommandNameLabel.Location = new Point(23, 116);
            CommandNameLabel.Name = "CommandNameLabel";
            CommandNameLabel.Size = new Size(154, 24);
            CommandNameLabel.TabIndex = 12;
            CommandNameLabel.Text = "Command Name";
            // 
            // TitleLabel
            // 
            TitleLabel.AutoSize = true;
            TitleLabel.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TitleLabel.ForeColor = Color.FromArgb(114, 137, 218);
            TitleLabel.Location = new Point(23, 20);
            TitleLabel.Name = "TitleLabel";
            TitleLabel.Size = new Size(397, 54);
            TitleLabel.TabIndex = 10;
            TitleLabel.Text = "Create a Command!";
            // 
            // Creation
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(894, 553);
            Controls.Add(mainPanel);
            Controls.Add(panel1);
            Font = new Font("Corbel", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.White;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(800, 600);
            Name = "Creation";
            Text = "Voice Tale | Command Creation";
            Load += Creation_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)File).EndInit();
            ((System.ComponentModel.ISupportInitialize)Info).EndInit();
            mainPanel.ResumeLayout(false);
            mainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Save).EndInit();
            ResumeLayout(false);
        }

        private Panel panel1;
        private PictureBox Info;
        private PictureBox File;
        private Panel mainPanel;
        private Label TitleLabel;
        private TextBox CommandName;
        private Label CommandNameLabel;
        private TextBox Commands;
        private Label CommandsLabel;
        private PictureBox Save;
        private Label label2;
        private Label label3;
    }
}