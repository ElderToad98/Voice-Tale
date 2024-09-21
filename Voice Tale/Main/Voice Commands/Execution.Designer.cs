namespace Voice_Tale.Main.Voice_Commands
{
    partial class Execution
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Execution));
            sidePanel = new Panel();
            File = new PictureBox();
            infoButton = new Button();
            mainPanel = new Panel();
            commandLogPanel = new Panel();
            commandLogLabel = new Label();
            commandLog = new ListBox();
            commandListPanel = new Panel();
            commandList = new ListBox();
            commandListLabel = new Label();
            instructionLabel = new Label();
            titleLabel = new Label();
            connLabel = new Label();
            sidePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)File).BeginInit();
            mainPanel.SuspendLayout();
            commandLogPanel.SuspendLayout();
            commandListPanel.SuspendLayout();
            SuspendLayout();
            // 
            // sidePanel
            // 
            sidePanel.BackColor = Color.FromArgb(114, 137, 218);
            sidePanel.Controls.Add(File);
            sidePanel.Controls.Add(infoButton);
            sidePanel.Dock = DockStyle.Left;
            sidePanel.Location = new Point(0, 0);
            sidePanel.Name = "sidePanel";
            sidePanel.Size = new Size(80, 561);
            sidePanel.TabIndex = 9;
            // 
            // File
            // 
            File.Cursor = Cursors.Hand;
            File.Image = (Image)resources.GetObject("File.Image");
            File.Location = new Point(15, 249);
            File.Name = "File";
            File.Size = new Size(51, 62);
            File.SizeMode = PictureBoxSizeMode.Zoom;
            File.TabIndex = 17;
            File.TabStop = false;
            File.Click += File_Click_1;
            // 
            // infoButton
            // 
            infoButton.BackColor = Color.Transparent;
            infoButton.Cursor = Cursors.Hand;
            infoButton.FlatAppearance.BorderSize = 0;
            infoButton.FlatStyle = FlatStyle.Flat;
            infoButton.Image = (Image)resources.GetObject("infoButton.Image");
            infoButton.Location = new Point(10, 40);
            infoButton.Name = "infoButton";
            infoButton.Size = new Size(60, 60);
            infoButton.TabIndex = 10;
            infoButton.UseVisualStyleBackColor = false;
            infoButton.Click += Info_Click;
            // 
            // mainPanel
            // 
            mainPanel.BackColor = Color.FromArgb(35, 39, 42);
            mainPanel.Controls.Add(commandLogPanel);
            mainPanel.Controls.Add(commandListPanel);
            mainPanel.Controls.Add(instructionLabel);
            mainPanel.Controls.Add(titleLabel);
            mainPanel.Controls.Add(connLabel);
            mainPanel.Dock = DockStyle.Fill;
            mainPanel.Location = new Point(80, 0);
            mainPanel.Name = "mainPanel";
            mainPanel.Padding = new Padding(20);
            mainPanel.Size = new Size(870, 561);
            mainPanel.TabIndex = 10;
            mainPanel.Paint += mainPanel_Paint_2;
            // 
            // commandLogPanel
            // 
            commandLogPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            commandLogPanel.BackColor = Color.FromArgb(44, 47, 51);
            commandLogPanel.Controls.Add(commandLogLabel);
            commandLogPanel.Controls.Add(commandLog);
            commandLogPanel.Location = new Point(460, 150);
            commandLogPanel.Name = "commandLogPanel";
            commandLogPanel.Padding = new Padding(10);
            commandLogPanel.Size = new Size(390, 391);
            commandLogPanel.TabIndex = 24;
            // 
            // commandLogLabel
            // 
            commandLogLabel.Dock = DockStyle.Top;
            commandLogLabel.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            commandLogLabel.ForeColor = Color.FromArgb(153, 170, 181);
            commandLogLabel.Location = new Point(10, 10);
            commandLogLabel.Name = "commandLogLabel";
            commandLogLabel.Size = new Size(370, 30);
            commandLogLabel.TabIndex = 23;
            commandLogLabel.Text = "Command Log";
            // 
            // commandLog
            // 
            commandLog.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            commandLog.BackColor = Color.FromArgb(35, 39, 42);
            commandLog.BorderStyle = BorderStyle.None;
            commandLog.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            commandLog.ForeColor = Color.White;
            commandLog.FormattingEnabled = true;
            commandLog.ItemHeight = 23;
            commandLog.Location = new Point(10, 50);
            commandLog.Name = "commandLog";
            commandLog.Size = new Size(370, 322);
            commandLog.TabIndex = 18;
            // 
            // commandListPanel
            // 
            commandListPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            commandListPanel.BackColor = Color.FromArgb(44, 47, 51);
            commandListPanel.Controls.Add(commandList);
            commandListPanel.Controls.Add(commandListLabel);
            commandListPanel.Location = new Point(20, 150);
            commandListPanel.Name = "commandListPanel";
            commandListPanel.Padding = new Padding(10);
            commandListPanel.Size = new Size(390, 391);
            commandListPanel.TabIndex = 23;
            // 
            // commandList
            // 
            commandList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            commandList.BackColor = Color.FromArgb(35, 39, 42);
            commandList.BorderStyle = BorderStyle.None;
            commandList.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            commandList.ForeColor = Color.White;
            commandList.FormattingEnabled = true;
            commandList.ItemHeight = 23;
            commandList.Location = new Point(10, 50);
            commandList.Name = "commandList";
            commandList.Size = new Size(370, 322);
            commandList.TabIndex = 23;
            // 
            // commandListLabel
            // 
            commandListLabel.Dock = DockStyle.Top;
            commandListLabel.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            commandListLabel.ForeColor = Color.FromArgb(153, 170, 181);
            commandListLabel.Location = new Point(10, 10);
            commandListLabel.Name = "commandListLabel";
            commandListLabel.Size = new Size(370, 30);
            commandListLabel.TabIndex = 22;
            commandListLabel.Text = "Command List";
            // 
            // instructionLabel
            // 
            instructionLabel.AutoSize = true;
            instructionLabel.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            instructionLabel.ForeColor = Color.FromArgb(153, 170, 181);
            instructionLabel.Location = new Point(20, 100);
            instructionLabel.Name = "instructionLabel";
            instructionLabel.Size = new Size(256, 23);
            instructionLabel.TabIndex = 16;
            instructionLabel.Text = "Speak a command to execute it!";
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            titleLabel.ForeColor = Color.FromArgb(114, 137, 218);
            titleLabel.Location = new Point(20, 20);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(406, 54);
            titleLabel.TabIndex = 10;
            titleLabel.Text = "Execute a Command";
            // 
            // connLabel
            // 
            connLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            connLabel.AutoSize = true;
            connLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            connLabel.ForeColor = Color.FromArgb(153, 170, 181);
            connLabel.Location = new Point(662, 20);
            connLabel.Name = "connLabel";
            connLabel.Size = new Size(168, 20);
            connLabel.TabIndex = 20;
            connLabel.Text = "Connected Server: None";
            // 
            // Execution
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(35, 39, 42);
            ClientSize = new Size(950, 561);
            Controls.Add(mainPanel);
            Controls.Add(sidePanel);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.White;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(800, 600);
            Name = "Execution";
            Text = "Voice Tale | Voice Command Execution";
            Load += Execution_Load;
            sidePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)File).EndInit();
            mainPanel.ResumeLayout(false);
            mainPanel.PerformLayout();
            commandLogPanel.ResumeLayout(false);
            commandListPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        private Panel sidePanel;
        private Button infoButton;
        private Panel mainPanel;
        private Label titleLabel;
        private Label instructionLabel;
        private ListBox commandLog;
        private Label connLabel;
        private Panel commandListPanel;
        private Label commandListLabel;
        private Panel commandLogPanel;
        private Label commandLogLabel;
        private ListBox commandList;
        private PictureBox File;
    }
}