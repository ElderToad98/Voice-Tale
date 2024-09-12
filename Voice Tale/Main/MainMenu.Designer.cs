namespace Voice_Tale
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            sidePanel = new Panel();
            settingsButton = new Button();
            githubButton = new Button();
            youtubeButton = new Button();
            discordButton = new Button();
            mainInfoButton = new Button();
            topPanel = new Panel();
            titleLabel = new Label();
            commandCreateButton = new Button();
            commandExecuteButton = new Button();
            manualCommandButton = new Button();
            sidePanel.SuspendLayout();
            topPanel.SuspendLayout();
            SuspendLayout();
            // 
            // sidePanel
            // 
            sidePanel.BackColor = Color.FromArgb(47, 49, 54);
            sidePanel.Controls.Add(settingsButton);
            sidePanel.Controls.Add(githubButton);
            sidePanel.Controls.Add(youtubeButton);
            sidePanel.Controls.Add(discordButton);
            sidePanel.Controls.Add(mainInfoButton);
            sidePanel.Dock = DockStyle.Left;
            sidePanel.Location = new Point(0, 0);
            sidePanel.Name = "sidePanel";
            sidePanel.Size = new Size(80, 600);
            sidePanel.TabIndex = 8;
            // 
            // settingsButton
            // 
            settingsButton.FlatAppearance.BorderSize = 0;
            settingsButton.FlatStyle = FlatStyle.Flat;
            settingsButton.Image = (Image)resources.GetObject("settingsButton.Image");
            settingsButton.Location = new Point(10, 530);
            settingsButton.Name = "settingsButton";
            settingsButton.Size = new Size(60, 60);
            settingsButton.TabIndex = 14;
            settingsButton.UseVisualStyleBackColor = true;
            settingsButton.Click += Settings_Click;
            // 
            // githubButton
            // 
            githubButton.FlatAppearance.BorderSize = 0;
            githubButton.FlatStyle = FlatStyle.Flat;
            githubButton.Image = (Image)resources.GetObject("githubButton.Image");
            githubButton.Location = new Point(10, 410);
            githubButton.Name = "githubButton";
            githubButton.Size = new Size(60, 60);
            githubButton.TabIndex = 13;
            githubButton.UseVisualStyleBackColor = true;
            githubButton.Click += Github_Click_1;
            // 
            // youtubeButton
            // 
            youtubeButton.FlatAppearance.BorderSize = 0;
            youtubeButton.FlatStyle = FlatStyle.Flat;
            youtubeButton.Image = (Image)resources.GetObject("youtubeButton.Image");
            youtubeButton.Location = new Point(10, 290);
            youtubeButton.Name = "youtubeButton";
            youtubeButton.Size = new Size(60, 60);
            youtubeButton.TabIndex = 12;
            youtubeButton.UseVisualStyleBackColor = true;
            youtubeButton.Click += Youtube_Click_1;
            // 
            // discordButton
            // 
            discordButton.FlatAppearance.BorderSize = 0;
            discordButton.FlatStyle = FlatStyle.Flat;
            discordButton.Image = (Image)resources.GetObject("discordButton.Image");
            discordButton.Location = new Point(10, 170);
            discordButton.Name = "discordButton";
            discordButton.Size = new Size(60, 60);
            discordButton.TabIndex = 11;
            discordButton.UseVisualStyleBackColor = true;
            discordButton.Click += Discord_Click;
            // 
            // mainInfoButton
            // 
            mainInfoButton.FlatAppearance.BorderSize = 0;
            mainInfoButton.FlatStyle = FlatStyle.Flat;
            mainInfoButton.Image = (Image)resources.GetObject("mainInfoButton.Image");
            mainInfoButton.Location = new Point(10, 50);
            mainInfoButton.Name = "mainInfoButton";
            mainInfoButton.Size = new Size(60, 60);
            mainInfoButton.TabIndex = 10;
            mainInfoButton.UseVisualStyleBackColor = true;
            mainInfoButton.Click += MainInfo_Click;
            // 
            // topPanel
            // 
            topPanel.BackColor = Color.FromArgb(32, 34, 37);
            topPanel.Controls.Add(titleLabel);
            topPanel.Dock = DockStyle.Top;
            topPanel.Location = new Point(80, 0);
            topPanel.Name = "topPanel";
            topPanel.Size = new Size(1104, 60);
            topPanel.TabIndex = 9;
            // 
            // titleLabel
            // 
            titleLabel.Dock = DockStyle.Fill;
            titleLabel.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            titleLabel.ForeColor = Color.White;
            titleLabel.Location = new Point(0, 0);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(1104, 60);
            titleLabel.TabIndex = 11;
            titleLabel.Text = "Voice Tale Menu";
            titleLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // commandCreateButton
            // 
            commandCreateButton.BackColor = Color.FromArgb(114, 137, 218);
            commandCreateButton.FlatAppearance.BorderSize = 0;
            commandCreateButton.FlatStyle = FlatStyle.Flat;
            commandCreateButton.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            commandCreateButton.ForeColor = Color.White;
            commandCreateButton.Image = (Image)resources.GetObject("commandCreateButton.Image");
            commandCreateButton.Location = new Point(120, 100);
            commandCreateButton.Name = "commandCreateButton";
            commandCreateButton.Size = new Size(320, 200);
            commandCreateButton.TabIndex = 10;
            commandCreateButton.Text = "Command Creation";
            commandCreateButton.TextAlign = ContentAlignment.BottomCenter;
            commandCreateButton.TextImageRelation = TextImageRelation.ImageAboveText;
            commandCreateButton.UseVisualStyleBackColor = false;
            commandCreateButton.Click += CommandCreate_Click;
            // 
            // commandExecuteButton
            // 
            commandExecuteButton.BackColor = Color.FromArgb(114, 137, 218);
            commandExecuteButton.FlatAppearance.BorderSize = 0;
            commandExecuteButton.FlatStyle = FlatStyle.Flat;
            commandExecuteButton.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            commandExecuteButton.ForeColor = Color.White;
            commandExecuteButton.Image = (Image)resources.GetObject("commandExecuteButton.Image");
            commandExecuteButton.Location = new Point(470, 100);
            commandExecuteButton.Name = "commandExecuteButton";
            commandExecuteButton.Size = new Size(320, 200);
            commandExecuteButton.TabIndex = 12;
            commandExecuteButton.Text = "Command Execution";
            commandExecuteButton.TextAlign = ContentAlignment.BottomCenter;
            commandExecuteButton.TextImageRelation = TextImageRelation.ImageAboveText;
            commandExecuteButton.UseVisualStyleBackColor = false;
            commandExecuteButton.Click += button1_Click;
            // 
            // manualCommandButton
            // 
            manualCommandButton.BackColor = Color.FromArgb(114, 137, 218);
            manualCommandButton.FlatAppearance.BorderSize = 0;
            manualCommandButton.FlatStyle = FlatStyle.Flat;
            manualCommandButton.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            manualCommandButton.ForeColor = Color.White;
            manualCommandButton.Image = (Image)resources.GetObject("manualCommandButton.Image");
            manualCommandButton.Location = new Point(820, 100);
            manualCommandButton.Name = "manualCommandButton";
            manualCommandButton.Size = new Size(320, 200);
            manualCommandButton.TabIndex = 14;
            manualCommandButton.Text = "Send Manual Command";
            manualCommandButton.TextAlign = ContentAlignment.BottomCenter;
            manualCommandButton.TextImageRelation = TextImageRelation.ImageAboveText;
            manualCommandButton.UseVisualStyleBackColor = false;
            manualCommandButton.Click += manualCommandButton_Click;
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(54, 57, 63);
            ClientSize = new Size(1184, 600);
            Controls.Add(manualCommandButton);
            Controls.Add(commandExecuteButton);
            Controls.Add(commandCreateButton);
            Controls.Add(topPanel);
            Controls.Add(sidePanel);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.White;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MainMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Voice Tale | Main Menu";
            sidePanel.ResumeLayout(false);
            topPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel sidePanel;
        private Panel topPanel;
        private Button mainInfoButton;
        private Button settingsButton;
        private Button githubButton;
        private Button youtubeButton;
        private Button discordButton;
        private Button commandCreateButton;
        private Label titleLabel;
        private Button commandExecuteButton;
        private Button manualCommandButton;
    }
}