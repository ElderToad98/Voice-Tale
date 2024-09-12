namespace Voice_Tale.Main
{
    partial class Settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            tableLayoutPanel1 = new TableLayoutPanel();
            User = new Label();
            ServerID = new TextBox();
            label2 = new Label();
            Confidence = new TextBox();
            checkBoxPanel = new TableLayoutPanel();
            Beep = new CheckBox();
            Speak = new CheckBox();
            Save = new Button();
            label1 = new Label();
            infoButton = new Button();
            panel1 = new Panel();
            tableLayoutPanel1.SuspendLayout();
            checkBoxPanel.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(User, 0, 1);
            tableLayoutPanel1.Controls.Add(ServerID, 0, 2);
            tableLayoutPanel1.Controls.Add(label2, 0, 3);
            tableLayoutPanel1.Controls.Add(Confidence, 0, 4);
            tableLayoutPanel1.Controls.Add(checkBoxPanel, 0, 5);
            tableLayoutPanel1.Controls.Add(Save, 0, 6);
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(infoButton, 0, 7);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(10, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new Padding(20);
            tableLayoutPanel1.RowCount = 8;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(588, 454);
            tableLayoutPanel1.TabIndex = 21;
            // 
            // User
            // 
            User.AutoSize = true;
            User.Font = new Font("Segoe UI", 10F);
            User.ForeColor = Color.FromArgb(153, 170, 181);
            User.Location = new Point(23, 82);
            User.Name = "User";
            User.Size = new Size(79, 23);
            User.TabIndex = 15;
            User.Text = "Server ID";
            // 
            // ServerID
            // 
            ServerID.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            ServerID.BackColor = Color.FromArgb(64, 68, 75);
            ServerID.BorderStyle = BorderStyle.FixedSingle;
            ServerID.Font = new Font("Segoe UI", 14F);
            ServerID.ForeColor = Color.White;
            ServerID.Location = new Point(23, 108);
            ServerID.Name = "ServerID";
            ServerID.PlaceholderText = "Enter Server ID";
            ServerID.Size = new Size(542, 39);
            ServerID.TabIndex = 14;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.ForeColor = Color.FromArgb(153, 170, 181);
            label2.Location = new Point(23, 150);
            label2.Name = "label2";
            label2.Size = new Size(96, 23);
            label2.TabIndex = 17;
            label2.Text = "Confidence";
            // 
            // Confidence
            // 
            Confidence.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            Confidence.BackColor = Color.FromArgb(64, 68, 75);
            Confidence.BorderStyle = BorderStyle.FixedSingle;
            Confidence.Font = new Font("Segoe UI", 14F);
            Confidence.ForeColor = Color.White;
            Confidence.Location = new Point(23, 176);
            Confidence.Name = "Confidence";
            Confidence.PlaceholderText = "Enter Confidence Value";
            Confidence.Size = new Size(542, 39);
            Confidence.TabIndex = 16;
            // 
            // checkBoxPanel
            // 
            checkBoxPanel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            checkBoxPanel.AutoSize = true;
            checkBoxPanel.ColumnCount = 2;
            checkBoxPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            checkBoxPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            checkBoxPanel.Controls.Add(Beep, 0, 0);
            checkBoxPanel.Controls.Add(Speak, 1, 0);
            checkBoxPanel.Location = new Point(23, 221);
            checkBoxPanel.Name = "checkBoxPanel";
            checkBoxPanel.RowCount = 1;
            checkBoxPanel.RowStyles.Add(new RowStyle());
            checkBoxPanel.Size = new Size(542, 38);
            checkBoxPanel.TabIndex = 22;
            // 
            // Beep
            // 
            Beep.AutoSize = true;
            Beep.Font = new Font("Segoe UI", 12F);
            Beep.ForeColor = Color.White;
            Beep.Location = new Point(3, 3);
            Beep.Name = "Beep";
            Beep.Size = new Size(265, 32);
            Beep.TabIndex = 19;
            Beep.Text = "Beep on Speech Recognized";
            Beep.UseVisualStyleBackColor = true;
            // 
            // Speak
            // 
            Speak.AutoSize = true;
            Speak.Font = new Font("Segoe UI", 12F);
            Speak.ForeColor = Color.White;
            Speak.Location = new Point(274, 3);
            Speak.Name = "Speak";
            Speak.Size = new Size(265, 32);
            Speak.TabIndex = 20;
            Speak.Text = "TTS on Speech Recognized";
            Speak.UseVisualStyleBackColor = true;
            // 
            // Save
            // 
            Save.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Save.BackColor = Color.FromArgb(114, 137, 218);
            Save.FlatAppearance.BorderSize = 0;
            Save.FlatStyle = FlatStyle.Flat;
            Save.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            Save.ForeColor = Color.White;
            Save.Location = new Point(23, 265);
            Save.Name = "Save";
            Save.Size = new Size(542, 50);
            Save.TabIndex = 13;
            Save.Text = "Save Changes";
            Save.UseVisualStyleBackColor = false;
            Save.Click += Save_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 28F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(114, 137, 218);
            label1.Location = new Point(23, 20);
            label1.Name = "label1";
            label1.Size = new Size(205, 62);
            label1.TabIndex = 12;
            label1.Text = "Settings";
            // 
            // infoButton
            // 
            infoButton.BackColor = Color.Transparent;
            infoButton.Cursor = Cursors.Default;
            infoButton.FlatAppearance.BorderSize = 0;
            infoButton.FlatStyle = FlatStyle.Flat;
            infoButton.Image = (Image)resources.GetObject("infoButton.Image");
            infoButton.Location = new Point(23, 321);
            infoButton.Name = "infoButton";
            infoButton.Size = new Size(60, 60);
            infoButton.TabIndex = 23;
            infoButton.UseVisualStyleBackColor = false;
            infoButton.Click += infoButton_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(54, 57, 63);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(10, 454);
            panel1.TabIndex = 18;
            // 
            // Settings
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(35, 39, 42);
            ClientSize = new Size(598, 454);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 9F);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(450, 400);
            Name = "Settings";
            Text = "Voice Tale | Settings";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            checkBoxPanel.ResumeLayout(false);
            checkBoxPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Button Save;
        private TextBox ServerID;
        private Label User;
        private TextBox Confidence;
        private Label label2;
        private Panel panel1;
        private CheckBox Beep;
        private CheckBox Speak;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel checkBoxPanel;
        private Button infoButton;
    }
}