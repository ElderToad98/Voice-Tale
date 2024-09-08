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

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Creation));
            panel1 = new Panel();
            File = new PictureBox();
            Info = new PictureBox();
            label1 = new Label();
            CommandName = new TextBox();
            User = new Label();
            Commands = new TextBox();
            Password = new Label();
            Save = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)File).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Info).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Save).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(114, 137, 218);
            panel1.Controls.Add(File);
            panel1.Controls.Add(Info);
            panel1.Location = new Point(-4, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(121, 563);
            panel1.TabIndex = 9;
            // 
            // File
            // 
            File.Cursor = Cursors.Hand;
            File.Image = (Image)resources.GetObject("File.Image");
            File.Location = new Point(34, 254);
            File.Name = "File";
            File.Size = new Size(51, 62);
            File.TabIndex = 16;
            File.TabStop = false;
            File.Click += File_Click;
            // 
            // Info
            // 
            Info.Cursor = Cursors.Hand;
            Info.Image = (Image)resources.GetObject("Info.Image");
            Info.Location = new Point(34, 32);
            Info.Name = "Info";
            Info.Size = new Size(51, 62);
            Info.TabIndex = 10;
            Info.TabStop = false;
            Info.Click += Info_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Corbel", 30.8F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(114, 137, 218);
            label1.Location = new Point(159, 32);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(470, 64);
            label1.TabIndex = 10;
            label1.Text = "Create a Command!";
            // 
            // CommandName
            // 
            CommandName.BackColor = Color.FromArgb(64, 68, 75);
            CommandName.BorderStyle = BorderStyle.None;
            CommandName.Cursor = Cursors.IBeam;
            CommandName.Font = new Font("Corbel", 20F, FontStyle.Bold);
            CommandName.ForeColor = Color.White;
            CommandName.Location = new Point(172, 164);
            CommandName.Margin = new Padding(4);
            CommandName.Name = "CommandName";
            CommandName.PlaceholderText = "Make it Day";
            CommandName.Size = new Size(434, 41);
            CommandName.TabIndex = 11;
            // 
            // User
            // 
            User.AutoSize = true;
            User.ForeColor = Color.FromArgb(153, 170, 181);
            User.Location = new Point(172, 136);
            User.Margin = new Padding(4, 0, 4, 0);
            User.Name = "User";
            User.Size = new Size(154, 24);
            User.TabIndex = 12;
            User.Text = "Command Name";
            // 
            // Commands
            // 
            Commands.BackColor = Color.FromArgb(64, 68, 75);
            Commands.BorderStyle = BorderStyle.None;
            Commands.Cursor = Cursors.IBeam;
            Commands.Font = new Font("Corbel", 20F, FontStyle.Bold);
            Commands.ForeColor = Color.White;
            Commands.Location = new Point(172, 254);
            Commands.Margin = new Padding(4);
            Commands.Name = "Commands";
            Commands.PlaceholderText = "time set 9,time set 10,time set 11";
            Commands.Size = new Size(578, 41);
            Commands.TabIndex = 13;
            // 
            // Password
            // 
            Password.AutoSize = true;
            Password.ForeColor = Color.FromArgb(153, 170, 181);
            Password.Location = new Point(172, 226);
            Password.Margin = new Padding(4, 0, 4, 0);
            Password.Name = "Password";
            Password.Size = new Size(456, 24);
            Password.TabIndex = 14;
            Password.Text = "Command(s) to Execute (Commands Separated by ',')";
            // 
            // Save
            // 
            Save.Cursor = Cursors.Hand;
            Save.Image = (Image)resources.GetObject("Save.Image");
            Save.Location = new Point(788, 457);
            Save.Name = "Save";
            Save.Size = new Size(123, 106);
            Save.TabIndex = 15;
            Save.TabStop = false;
            Save.Click += Save_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.FromArgb(153, 170, 181);
            label2.Location = new Point(124, 529);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(215, 24);
            label2.TabIndex = 16;
            label2.Text = "This is in very early beta!";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.FromArgb(153, 170, 181);
            label3.Location = new Point(596, 529);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(185, 24);
            label3.TabIndex = 17;
            label3.Text = "Don't forget to save!!";
            // 
            // Creation
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(35, 39, 42);
            ClientSize = new Size(894, 553);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(Password);
            Controls.Add(Save);
            Controls.Add(Commands);
            Controls.Add(User);
            Controls.Add(CommandName);
            Controls.Add(label1);
            Controls.Add(panel1);
            Font = new Font("Corbel", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.White;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "Creation";
            Text = "Command Creation";
            Load += Creation_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)File).EndInit();
            ((System.ComponentModel.ISupportInitialize)Info).EndInit();
            ((System.ComponentModel.ISupportInitialize)Save).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox Info;
        private Label label1;
        private TextBox CommandName; // Rename to CommandName
        private Label User;
        private TextBox Commands;
        private Label Password;
        private PictureBox File;
        private PictureBox Save;
        private Label label2;
        private Label label3;
    }
}
