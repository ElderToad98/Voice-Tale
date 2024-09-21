namespace Voice_Tale
{

   
    partial class MainMenu
    {
        private System.ComponentModel.IContainer components = null;
        private ToolTip toolTip1; 
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            sidePanel = new Panel();
            settingsButton = new Button();
            githubButton = new Button();
            youtubeButton = new Button();
            discordButton = new Button();
            mainInfoButton = new Button();
            topPanel = new Panel();
            titleLabel = new Label();
            variableCreationButton = new Button();
            manualCommandButton = new Button();
            commandExecuteButton = new Button();
            commandCreateButton = new Button();
            pictureBox1 = new PictureBox();
            contentPanel = new Panel();
            toolTip1 = new ToolTip(components);
            sidePanel.SuspendLayout();
            topPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            contentPanel.SuspendLayout();
            SuspendLayout();
            // 
            // sidePanel
            // 
            sidePanel.BackColor = Color.FromArgb(32, 34, 37);
            sidePanel.Controls.Add(settingsButton);
            sidePanel.Controls.Add(githubButton);
            sidePanel.Controls.Add(youtubeButton);
            sidePanel.Controls.Add(discordButton);
            sidePanel.Controls.Add(mainInfoButton);
            sidePanel.Dock = DockStyle.Left;
            sidePanel.Location = new Point(0, 0);
            sidePanel.Name = "sidePanel";
            sidePanel.Size = new Size(101, 600);
            sidePanel.TabIndex = 8;
            // 
            // settingsButton
            // 
            settingsButton.FlatAppearance.BorderSize = 0;
            settingsButton.FlatStyle = FlatStyle.Flat;
            settingsButton.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            settingsButton.ForeColor = Color.White;
            settingsButton.Image = (Image)resources.GetObject("settingsButton.Image");
            settingsButton.Location = new Point(0, 483);
            settingsButton.Name = "settingsButton";
            settingsButton.Size = new Size(95, 114);
            settingsButton.TabIndex = 4;
            toolTip1.SetToolTip(settingsButton, "Open Settings");
            settingsButton.UseVisualStyleBackColor = true;
            settingsButton.Click += Settings_Click;
            // 
            // githubButton
            // 
            githubButton.FlatAppearance.BorderSize = 0;
            githubButton.FlatStyle = FlatStyle.Flat;
            githubButton.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            githubButton.ForeColor = Color.White;
            githubButton.Image = (Image)resources.GetObject("githubButton.Image");
            githubButton.Location = new Point(0, 363);
            githubButton.Name = "githubButton";
            githubButton.Size = new Size(95, 114);
            githubButton.TabIndex = 3;
            toolTip1.SetToolTip(githubButton, "Visit our GitHub");
            githubButton.UseVisualStyleBackColor = true;
            githubButton.Click += Github_Click_1;
            // 
            // youtubeButton
            // 
            youtubeButton.FlatAppearance.BorderSize = 0;
            youtubeButton.FlatStyle = FlatStyle.Flat;
            youtubeButton.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            youtubeButton.ForeColor = Color.White;
            youtubeButton.Image = (Image)resources.GetObject("youtubeButton.Image");
            youtubeButton.Location = new Point(0, 243);
            youtubeButton.Name = "youtubeButton";
            youtubeButton.Size = new Size(95, 114);
            youtubeButton.TabIndex = 2;
            toolTip1.SetToolTip(youtubeButton, "Check our YouTube channel");
            youtubeButton.UseVisualStyleBackColor = true;
            youtubeButton.Click += Youtube_Click_1;
            // 
            // discordButton
            // 
            discordButton.FlatAppearance.BorderSize = 0;
            discordButton.FlatStyle = FlatStyle.Flat;
            discordButton.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            discordButton.ForeColor = Color.White;
            discordButton.Image = (Image)resources.GetObject("discordButton.Image");
            discordButton.Location = new Point(0, 123);
            discordButton.Name = "discordButton";
            discordButton.Size = new Size(96, 114);
            discordButton.TabIndex = 1;
            toolTip1.SetToolTip(discordButton, "Join our Discord server");
            discordButton.UseVisualStyleBackColor = true;
            discordButton.Click += Discord_Click;
            // 
            // mainInfoButton
            // 
            mainInfoButton.FlatAppearance.BorderSize = 0;
            mainInfoButton.FlatStyle = FlatStyle.Flat;
            mainInfoButton.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            mainInfoButton.ForeColor = Color.White;
            mainInfoButton.Image = (Image)resources.GetObject("mainInfoButton.Image");
            mainInfoButton.Location = new Point(0, 3);
            mainInfoButton.Name = "mainInfoButton";
            mainInfoButton.Size = new Size(98, 114);
            mainInfoButton.TabIndex = 0;
            toolTip1.SetToolTip(mainInfoButton, "Main Information");
            mainInfoButton.UseVisualStyleBackColor = true;
            mainInfoButton.Click += MainInfo_Click;
            // 
            // topPanel
            // 
            topPanel.BackColor = Color.FromArgb(32, 34, 37);
            topPanel.Controls.Add(titleLabel);
            topPanel.Dock = DockStyle.Top;
            topPanel.Location = new Point(101, 0);
            topPanel.Name = "topPanel";
            topPanel.Size = new Size(1083, 60);
            topPanel.TabIndex = 9;
            // 
            // titleLabel
            // 
            titleLabel.Dock = DockStyle.Fill;
            titleLabel.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            titleLabel.ForeColor = Color.White;
            titleLabel.Location = new Point(0, 0);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(1083, 60);
            titleLabel.TabIndex = 11;
            titleLabel.Text = "Voice Tale Menu";
            titleLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // variableCreationButton
            // 
            variableCreationButton.BackColor = Color.FromArgb(114, 137, 218);
            variableCreationButton.FlatAppearance.BorderSize = 0;
            variableCreationButton.FlatStyle = FlatStyle.Flat;
            variableCreationButton.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            variableCreationButton.ForeColor = Color.White;
            variableCreationButton.Location = new Point(706, 24);
            variableCreationButton.Name = "variableCreationButton";
            variableCreationButton.Size = new Size(365, 167);
            variableCreationButton.TabIndex = 15;
            variableCreationButton.Text = "➕\nVariable Creation";
            toolTip1.SetToolTip(variableCreationButton, "Create new variables");
            variableCreationButton.UseVisualStyleBackColor = false;
            variableCreationButton.Click += button1_Click_1;
            // 
            // manualCommandButton
            // 
            manualCommandButton.BackColor = Color.FromArgb(114, 137, 218);
            manualCommandButton.FlatAppearance.BorderSize = 0;
            manualCommandButton.FlatStyle = FlatStyle.Flat;
            manualCommandButton.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            manualCommandButton.ForeColor = Color.White;
            manualCommandButton.Location = new Point(18, 334);
            manualCommandButton.Name = "manualCommandButton";
            manualCommandButton.Size = new Size(365, 167);
            manualCommandButton.TabIndex = 14;
            manualCommandButton.Text = "⌨\nSend Manual Command";
            toolTip1.SetToolTip(manualCommandButton, "Send a manual command");
            manualCommandButton.UseVisualStyleBackColor = false;
            manualCommandButton.Click += manualCommandButton_Click;
            // 
            // commandExecuteButton
            // 
            commandExecuteButton.BackColor = Color.FromArgb(114, 137, 218);
            commandExecuteButton.FlatAppearance.BorderSize = 0;
            commandExecuteButton.FlatStyle = FlatStyle.Flat;
            commandExecuteButton.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            commandExecuteButton.ForeColor = Color.White;
            commandExecuteButton.Location = new Point(706, 334);
            commandExecuteButton.Name = "commandExecuteButton";
            commandExecuteButton.Size = new Size(365, 167);
            commandExecuteButton.TabIndex = 12;
            commandExecuteButton.Text = "💬\nCommand Execution";
            toolTip1.SetToolTip(commandExecuteButton, "Execute existing commands");
            commandExecuteButton.UseVisualStyleBackColor = false;
            commandExecuteButton.Click += button1_Click;
            // 
            // commandCreateButton
            // 
            commandCreateButton.AutoSize = true;
            commandCreateButton.BackColor = Color.FromArgb(114, 137, 218);
            commandCreateButton.FlatAppearance.BorderSize = 0;
            commandCreateButton.FlatStyle = FlatStyle.Flat;
            commandCreateButton.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            commandCreateButton.ForeColor = Color.White;
            commandCreateButton.Location = new Point(18, 24);
            commandCreateButton.Name = "commandCreateButton";
            commandCreateButton.Size = new Size(365, 167);
            commandCreateButton.TabIndex = 10;
            commandCreateButton.Text = "➕\nCommand Creation";
            toolTip1.SetToolTip(commandCreateButton, "Create new commands");
            commandCreateButton.UseVisualStyleBackColor = false;
            commandCreateButton.Click += CommandCreate_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(440, 144);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(213, 189);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // contentPanel
            // 
            contentPanel.BackColor = Color.FromArgb(54, 57, 63);
            contentPanel.Controls.Add(commandCreateButton);
            contentPanel.Controls.Add(variableCreationButton);
            contentPanel.Controls.Add(pictureBox1);
            contentPanel.Controls.Add(manualCommandButton);
            contentPanel.Controls.Add(commandExecuteButton);
            contentPanel.Dock = DockStyle.Fill;
            contentPanel.Location = new Point(101, 60);
            contentPanel.Name = "contentPanel";
            contentPanel.Size = new Size(1083, 540);
            contentPanel.TabIndex = 10;
            // 
            // toolTip1
            // 
            toolTip1.AutoPopDelay = 5000;
            toolTip1.InitialDelay = 1000;
            toolTip1.ReshowDelay = 500;
            toolTip1.ShowAlways = true;
            // 
            // MainMenu
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(54, 57, 63);
            ClientSize = new Size(1184, 600);
            Controls.Add(contentPanel);
            Controls.Add(topPanel);
            Controls.Add(sidePanel);
            Font = new Font("Segoe UI", 9F);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "MainMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Voice Tale | Main Menu";
            Load += MainMenu_Load;
            sidePanel.ResumeLayout(false);
            topPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            contentPanel.ResumeLayout(false);
            contentPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel sidePanel;
        private Panel topPanel;
        private Label titleLabel;
        private Button mainInfoButton;
        private Button discordButton;
        private Button youtubeButton;
        private Button githubButton;
        private Button settingsButton;
        private Button variableCreationButton;
        private Button manualCommandButton;
        private Button commandExecuteButton;
        private Button commandCreateButton;
        private PictureBox pictureBox1;
        private Panel contentPanel;
       



    }
}