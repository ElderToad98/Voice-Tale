namespace Voice_Tale
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            panel1 = new Panel();
            Settings = new PictureBox();
            Github = new PictureBox();
            Youtube = new PictureBox();
            Discord = new PictureBox();
            MainInfo = new PictureBox();
            panel2 = new Panel();
            label1 = new Label();
            CommandCreate = new Button();
            User = new Label();
            button1 = new Button();
            label2 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Settings).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Github).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Youtube).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Discord).BeginInit();
            ((System.ComponentModel.ISupportInitialize)MainInfo).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(114, 137, 218);
            panel1.Controls.Add(Settings);
            panel1.Controls.Add(Github);
            panel1.Controls.Add(Youtube);
            panel1.Controls.Add(Discord);
            panel1.Controls.Add(MainInfo);
            panel1.Location = new Point(-1, -8);
            panel1.Name = "panel1";
            panel1.Size = new Size(115, 563);
            panel1.TabIndex = 8;
            // 
            // Settings
            // 
            Settings.Cursor = Cursors.Hand;
            Settings.Image = (Image)resources.GetObject("Settings.Image");
            Settings.Location = new Point(26, 438);
            Settings.Name = "Settings";
            Settings.Size = new Size(51, 62);
            Settings.TabIndex = 14;
            Settings.TabStop = false;
            Settings.Click += Settings_Click;
            // 
            // Github
            // 
            Github.Cursor = Cursors.Hand;
            Github.Image = (Image)resources.GetObject("Github.Image");
            Github.Location = new Point(26, 338);
            Github.Name = "Github";
            Github.Size = new Size(51, 62);
            Github.TabIndex = 13;
            Github.TabStop = false;
            Github.Click += Github_Click_1;
            // 
            // Youtube
            // 
            Youtube.Cursor = Cursors.Hand;
            Youtube.Image = (Image)resources.GetObject("Youtube.Image");
            Youtube.Location = new Point(26, 230);
            Youtube.Name = "Youtube";
            Youtube.Size = new Size(51, 62);
            Youtube.TabIndex = 12;
            Youtube.TabStop = false;
            Youtube.Click += Youtube_Click_1;
            // 
            // Discord
            // 
            Discord.Cursor = Cursors.Hand;
            Discord.Image = (Image)resources.GetObject("Discord.Image");
            Discord.Location = new Point(26, 134);
            Discord.Name = "Discord";
            Discord.Size = new Size(51, 62);
            Discord.TabIndex = 11;
            Discord.TabStop = false;
            Discord.Click += Discord_Click;
            // 
            // MainInfo
            // 
            MainInfo.Cursor = Cursors.Hand;
            MainInfo.Image = (Image)resources.GetObject("MainInfo.Image");
            MainInfo.Location = new Point(26, 32);
            MainInfo.Name = "MainInfo";
            MainInfo.Size = new Size(51, 62);
            MainInfo.TabIndex = 10;
            MainInfo.TabStop = false;
            MainInfo.Click += MainInfo_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(35, 39, 50);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(113, -8);
            panel2.Name = "panel2";
            panel2.Size = new Size(969, 115);
            panel2.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Corbel", 30.8F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(114, 137, 218);
            label1.Location = new Point(324, 30);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(292, 64);
            label1.TabIndex = 11;
            label1.Text = "Main Menu!";
            // 
            // CommandCreate
            // 
            CommandCreate.BackColor = Color.FromArgb(114, 137, 218);
            CommandCreate.BackgroundImage = (Image)resources.GetObject("CommandCreate.BackgroundImage");
            CommandCreate.BackgroundImageLayout = ImageLayout.Center;
            CommandCreate.FlatAppearance.BorderSize = 0;
            CommandCreate.FlatStyle = FlatStyle.Flat;
            CommandCreate.Font = new Font("Corbel", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CommandCreate.ForeColor = Color.White;
            CommandCreate.Location = new Point(166, 115);
            CommandCreate.Name = "CommandCreate";
            CommandCreate.Size = new Size(215, 73);
            CommandCreate.TabIndex = 10;
            CommandCreate.UseVisualStyleBackColor = false;
            CommandCreate.Click += CommandCreate_Click;
            // 
            // User
            // 
            User.AutoSize = true;
            User.ForeColor = Color.FromArgb(153, 170, 181);
            User.Location = new Point(180, 191);
            User.Margin = new Padding(4, 0, 4, 0);
            User.Name = "User";
            User.Size = new Size(176, 24);
            User.TabIndex = 11;
            User.Text = "Command Creation";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(114, 137, 218);
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Center;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Corbel", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(475, 115);
            button1.Name = "button1";
            button1.Size = new Size(215, 73);
            button1.TabIndex = 12;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.FromArgb(153, 170, 181);
            label2.Location = new Point(487, 191);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(189, 24);
            label2.TabIndex = 13;
            label2.Text = "Command Execution";
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(35, 39, 42);
            ClientSize = new Size(1081, 553);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(User);
            Controls.Add(CommandCreate);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Corbel", 12F, FontStyle.Bold);
            ForeColor = SystemColors.Control;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "MainMenu";
            Text = "Voice Tale Menu";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Settings).EndInit();
            ((System.ComponentModel.ISupportInitialize)Github).EndInit();
            ((System.ComponentModel.ISupportInitialize)Youtube).EndInit();
            ((System.ComponentModel.ISupportInitialize)Discord).EndInit();
            ((System.ComponentModel.ISupportInitialize)MainInfo).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel1;
        private Panel panel2;
        private PictureBox MainInfo;
        private PictureBox Settings;
        private PictureBox Github;
        private PictureBox Youtube;
        private PictureBox Discord;
        private Button CommandCreate;
        private Label User;
        private Label label1;
        private Button button1;
        private Label label2;
    }
}