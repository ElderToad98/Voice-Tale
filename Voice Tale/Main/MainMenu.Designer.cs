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
            sidePanel = new TableLayoutPanel();
            mainInfoButton = new Button();
            discordButton = new Button();
            youtubeButton = new Button();
            githubButton = new Button();
            settingsButton = new Button();
            topPanel = new Panel();
            titleLabel = new Label();
            contentPanel = new TableLayoutPanel();
            commandCreateButton = new Button();
            commandExecuteButton = new Button();
            manualCommandButton = new Button();
            variableCreationButton = new Button();
            sidePanel.SuspendLayout();
            topPanel.SuspendLayout();
            contentPanel.SuspendLayout();
            SuspendLayout();
            // 
            // sidePanel
            // 
            sidePanel.BackColor = Color.FromArgb(32, 34, 37);
            sidePanel.ColumnCount = 1;
            sidePanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            sidePanel.Controls.Add(mainInfoButton, 0, 0);
            sidePanel.Controls.Add(discordButton, 0, 1);
            sidePanel.Controls.Add(youtubeButton, 0, 2);
            sidePanel.Controls.Add(githubButton, 0, 3);
            sidePanel.Controls.Add(settingsButton, 0, 4);
            sidePanel.Dock = DockStyle.Left;
            sidePanel.Location = new Point(0, 0);
            sidePanel.Name = "sidePanel";
            sidePanel.RowCount = 5;
            sidePanel.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            sidePanel.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            sidePanel.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            sidePanel.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            sidePanel.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            sidePanel.Size = new Size(90, 600);
            sidePanel.TabIndex = 8;
            // 
            // mainInfoButton
            // 
            mainInfoButton.Dock = DockStyle.Fill;
            mainInfoButton.FlatAppearance.BorderSize = 0;
            mainInfoButton.FlatStyle = FlatStyle.Flat;
            mainInfoButton.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            mainInfoButton.ForeColor = Color.White;
            mainInfoButton.Image = (Image)resources.GetObject("mainInfoButton.Image");
            mainInfoButton.Location = new Point(3, 3);
            mainInfoButton.Name = "mainInfoButton";
            mainInfoButton.Size = new Size(84, 114);
            mainInfoButton.TabIndex = 0;
            mainInfoButton.UseVisualStyleBackColor = true;
            mainInfoButton.Click += MainInfo_Click;
            // 
            // discordButton
            // 
            discordButton.Dock = DockStyle.Fill;
            discordButton.FlatAppearance.BorderSize = 0;
            discordButton.FlatStyle = FlatStyle.Flat;
            discordButton.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            discordButton.ForeColor = Color.White;
            discordButton.Image = (Image)resources.GetObject("discordButton.Image");
            discordButton.Location = new Point(3, 123);
            discordButton.Name = "discordButton";
            discordButton.Size = new Size(84, 114);
            discordButton.TabIndex = 1;
            discordButton.UseVisualStyleBackColor = true;
            discordButton.Click += Discord_Click;
            // 
            // youtubeButton
            // 
            youtubeButton.Dock = DockStyle.Fill;
            youtubeButton.FlatAppearance.BorderSize = 0;
            youtubeButton.FlatStyle = FlatStyle.Flat;
            youtubeButton.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            youtubeButton.ForeColor = Color.White;
            youtubeButton.Image = (Image)resources.GetObject("youtubeButton.Image");
            youtubeButton.Location = new Point(3, 243);
            youtubeButton.Name = "youtubeButton";
            youtubeButton.Size = new Size(84, 114);
            youtubeButton.TabIndex = 2;
            youtubeButton.UseVisualStyleBackColor = true;
            youtubeButton.Click += Youtube_Click_1;
            // 
            // githubButton
            // 
            githubButton.Dock = DockStyle.Fill;
            githubButton.FlatAppearance.BorderSize = 0;
            githubButton.FlatStyle = FlatStyle.Flat;
            githubButton.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            githubButton.ForeColor = Color.White;
            githubButton.Image = (Image)resources.GetObject("githubButton.Image");
            githubButton.Location = new Point(3, 363);
            githubButton.Name = "githubButton";
            githubButton.Size = new Size(84, 114);
            githubButton.TabIndex = 3;
            githubButton.UseVisualStyleBackColor = true;
            githubButton.Click += Github_Click_1;
            // 
            // settingsButton
            // 
            settingsButton.Dock = DockStyle.Fill;
            settingsButton.FlatAppearance.BorderSize = 0;
            settingsButton.FlatStyle = FlatStyle.Flat;
            settingsButton.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            settingsButton.ForeColor = Color.White;
            settingsButton.Image = (Image)resources.GetObject("settingsButton.Image");
            settingsButton.Location = new Point(3, 483);
            settingsButton.Name = "settingsButton";
            settingsButton.Size = new Size(84, 114);
            settingsButton.TabIndex = 4;
            settingsButton.UseVisualStyleBackColor = true;
            settingsButton.Click += Settings_Click;
            // 
            // topPanel
            // 
            topPanel.BackColor = Color.FromArgb(32, 34, 37);
            topPanel.Controls.Add(titleLabel);
            topPanel.Dock = DockStyle.Top;
            topPanel.Location = new Point(90, 0);
            topPanel.Name = "topPanel";
            topPanel.Size = new Size(1094, 60);
            topPanel.TabIndex = 9;
            // 
            // titleLabel
            // 
            titleLabel.Dock = DockStyle.Fill;
            titleLabel.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            titleLabel.ForeColor = Color.White;
            titleLabel.Location = new Point(0, 0);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(1094, 60);
            titleLabel.TabIndex = 11;
            titleLabel.Text = "Voice Tale Menu";
            titleLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // contentPanel
            // 
            contentPanel.BackColor = Color.FromArgb(54, 57, 63);
            contentPanel.ColumnCount = 3;
            contentPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
            contentPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
            contentPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
            contentPanel.Controls.Add(commandCreateButton, 0, 0);
            contentPanel.Controls.Add(commandExecuteButton, 1, 0);
            contentPanel.Controls.Add(manualCommandButton, 2, 0);
            contentPanel.Controls.Add(variableCreationButton, 0, 1);
            contentPanel.Dock = DockStyle.Fill;
            contentPanel.Location = new Point(90, 60);
            contentPanel.Name = "contentPanel";
            contentPanel.Padding = new Padding(20);
            contentPanel.RowCount = 3;
            contentPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 37.6F));
            contentPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 62.4F));
            contentPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 193F));
            contentPanel.Size = new Size(1094, 540);
            contentPanel.TabIndex = 10;
            // 
            // commandCreateButton
            // 
            commandCreateButton.Anchor = AnchorStyles.None;
            commandCreateButton.BackColor = Color.FromArgb(114, 137, 218);
            commandCreateButton.FlatAppearance.BorderSize = 0;
            commandCreateButton.FlatStyle = FlatStyle.Flat;
            commandCreateButton.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            commandCreateButton.ForeColor = Color.White;
            commandCreateButton.Location = new Point(75, 23);
            commandCreateButton.Name = "commandCreateButton";
            commandCreateButton.Size = new Size(240, 109);
            commandCreateButton.TabIndex = 10;
            commandCreateButton.Text = "➕\nCommand Creation";
            commandCreateButton.UseVisualStyleBackColor = false;
            commandCreateButton.Click += CommandCreate_Click;
            // 
            // commandExecuteButton
            // 
            commandExecuteButton.Anchor = AnchorStyles.None;
            commandExecuteButton.BackColor = Color.FromArgb(114, 137, 218);
            commandExecuteButton.FlatAppearance.BorderSize = 0;
            commandExecuteButton.FlatStyle = FlatStyle.Flat;
            commandExecuteButton.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            commandExecuteButton.ForeColor = Color.White;
            commandExecuteButton.Location = new Point(426, 23);
            commandExecuteButton.Name = "commandExecuteButton";
            commandExecuteButton.Size = new Size(240, 109);
            commandExecuteButton.TabIndex = 12;
            commandExecuteButton.Text = "💬\nCommand Execution";
            commandExecuteButton.UseVisualStyleBackColor = false;
            commandExecuteButton.Click += button1_Click;
            // 
            // manualCommandButton
            // 
            manualCommandButton.Anchor = AnchorStyles.None;
            manualCommandButton.BackColor = Color.FromArgb(114, 137, 218);
            manualCommandButton.FlatAppearance.BorderSize = 0;
            manualCommandButton.FlatStyle = FlatStyle.Flat;
            manualCommandButton.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            manualCommandButton.ForeColor = Color.White;
            manualCommandButton.Location = new Point(778, 23);
            manualCommandButton.Name = "manualCommandButton";
            manualCommandButton.Size = new Size(240, 109);
            manualCommandButton.TabIndex = 14;
            manualCommandButton.Text = "⌨\nSend Manual Command";
            manualCommandButton.UseVisualStyleBackColor = false;
            manualCommandButton.Click += manualCommandButton_Click;
            // 
            // variableCreationButton
            // 
            variableCreationButton.Anchor = AnchorStyles.None;
            variableCreationButton.BackColor = Color.FromArgb(114, 137, 218);
            variableCreationButton.FlatAppearance.BorderSize = 0;
            variableCreationButton.FlatStyle = FlatStyle.Flat;
            variableCreationButton.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            variableCreationButton.ForeColor = Color.White;
            variableCreationButton.Location = new Point(75, 175);
            variableCreationButton.Name = "variableCreationButton";
            variableCreationButton.Size = new Size(240, 110);
            variableCreationButton.TabIndex = 15;
            variableCreationButton.Text = "➕\nVariable Creation";
            variableCreationButton.UseVisualStyleBackColor = false;
            variableCreationButton.Click += button1_Click_1;
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(54, 57, 63);
            ClientSize = new Size(1184, 600);
            Controls.Add(contentPanel);
            Controls.Add(topPanel);
            Controls.Add(sidePanel);
            Font = new Font("Segoe UI", 9F);
            ForeColor = Color.White;
            MinimumSize = new Size(800, 600);
            Name = "MainMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Voice Tale | Main Menu";
            sidePanel.ResumeLayout(false);
            topPanel.ResumeLayout(false);
            contentPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private TableLayoutPanel sidePanel;
        private Panel topPanel;
        private Label titleLabel;
        private TableLayoutPanel contentPanel;
        private Button commandCreateButton;
        private Button commandExecuteButton;
        private Button manualCommandButton;
        private Button variableCreationButton;
        private Button mainInfoButton;
        private Button discordButton;
        private Button youtubeButton;
        private Button githubButton;
        private Button settingsButton;
    }
}