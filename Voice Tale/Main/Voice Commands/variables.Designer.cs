namespace Voice_Tale.Main.Voice_Commands
{
    partial class variables
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(variables));
            panel1 = new Panel();
            Info = new PictureBox();
            mainPanel = new Panel();
            DeleteButton = new Button();
            VariableList = new ComboBox();
            VariableListLabel = new Label();
            label3 = new Label();
            label2 = new Label();
            SaveButton = new Button();
            VariableValue = new TextBox();
            VariableValueLabel = new Label();
            VariableName = new TextBox();
            VariableNameLabel = new Label();
            TitleLabel = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Info).BeginInit();
            mainPanel.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(114, 137, 218);
            panel1.Controls.Add(Info);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(80, 553);
            panel1.TabIndex = 9;
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
            mainPanel.Controls.Add(DeleteButton);
            mainPanel.Controls.Add(VariableList);
            mainPanel.Controls.Add(VariableListLabel);
            mainPanel.Controls.Add(label3);
            mainPanel.Controls.Add(label2);
            mainPanel.Controls.Add(SaveButton);
            mainPanel.Controls.Add(VariableValue);
            mainPanel.Controls.Add(VariableValueLabel);
            mainPanel.Controls.Add(VariableName);
            mainPanel.Controls.Add(VariableNameLabel);
            mainPanel.Controls.Add(TitleLabel);
            mainPanel.Dock = DockStyle.Fill;
            mainPanel.Location = new Point(80, 0);
            mainPanel.Name = "mainPanel";
            mainPanel.Padding = new Padding(20);
            mainPanel.Size = new Size(814, 553);
            mainPanel.TabIndex = 10;
            // 
            // DeleteButton
            // 
            DeleteButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            DeleteButton.BackColor = Color.FromArgb(240, 71, 71);
            DeleteButton.FlatStyle = FlatStyle.Flat;
            DeleteButton.Location = new Point(23, 406);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(180, 40);
            DeleteButton.TabIndex = 20;
            DeleteButton.Text = "Delete Variable";
            DeleteButton.UseVisualStyleBackColor = false;
            DeleteButton.Click += DeleteButton_Click;
            // 
            // VariableList
            // 
            VariableList.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            VariableList.BackColor = Color.FromArgb(64, 68, 75);
            VariableList.DropDownStyle = ComboBoxStyle.DropDownList;
            VariableList.FlatStyle = FlatStyle.Flat;
            VariableList.ForeColor = Color.White;
            VariableList.FormattingEnabled = true;
            VariableList.Location = new Point(23, 324);
            VariableList.Name = "VariableList";
            VariableList.Size = new Size(768, 32);
            VariableList.TabIndex = 19;
            VariableList.SelectedIndexChanged += VariableList_SelectedIndexChanged;
            // 
            // VariableListLabel
            // 
            VariableListLabel.AutoSize = true;
            VariableListLabel.ForeColor = Color.FromArgb(153, 170, 181);
            VariableListLabel.Location = new Point(23, 296);
            VariableListLabel.Name = "VariableListLabel";
            VariableListLabel.Size = new Size(151, 24);
            VariableListLabel.TabIndex = 18;
            VariableListLabel.Text = "Edit Variable List";
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
            // SaveButton
            // 
            SaveButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            SaveButton.BackColor = Color.FromArgb(114, 137, 218);
            SaveButton.FlatStyle = FlatStyle.Flat;
            SaveButton.Location = new Point(611, 406);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(180, 40);
            SaveButton.TabIndex = 15;
            SaveButton.Text = "Save Variable";
            SaveButton.UseVisualStyleBackColor = false;
            SaveButton.Click += SaveButton_Click;
            // 
            // VariableValue
            // 
            VariableValue.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            VariableValue.BackColor = Color.FromArgb(64, 68, 75);
            VariableValue.BorderStyle = BorderStyle.FixedSingle;
            VariableValue.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            VariableValue.ForeColor = Color.White;
            VariableValue.Location = new Point(23, 234);
            VariableValue.Name = "VariableValue";
            VariableValue.PlaceholderText = "John Doe";
            VariableValue.Size = new Size(768, 34);
            VariableValue.TabIndex = 13;
            // 
            // VariableValueLabel
            // 
            VariableValueLabel.AutoSize = true;
            VariableValueLabel.ForeColor = Color.FromArgb(153, 170, 181);
            VariableValueLabel.Location = new Point(23, 206);
            VariableValueLabel.Name = "VariableValueLabel";
            VariableValueLabel.Size = new Size(130, 24);
            VariableValueLabel.TabIndex = 14;
            VariableValueLabel.Text = "Variable Value";
            // 
            // VariableName
            // 
            VariableName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            VariableName.BackColor = Color.FromArgb(64, 68, 75);
            VariableName.BorderStyle = BorderStyle.FixedSingle;
            VariableName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            VariableName.ForeColor = Color.White;
            VariableName.Location = new Point(23, 144);
            VariableName.Name = "VariableName";
            VariableName.PlaceholderText = "name";
            VariableName.Size = new Size(768, 34);
            VariableName.TabIndex = 11;
            // 
            // VariableNameLabel
            // 
            VariableNameLabel.AutoSize = true;
            VariableNameLabel.ForeColor = Color.FromArgb(153, 170, 181);
            VariableNameLabel.Location = new Point(23, 116);
            VariableNameLabel.Name = "VariableNameLabel";
            VariableNameLabel.Size = new Size(135, 24);
            VariableNameLabel.TabIndex = 12;
            VariableNameLabel.Text = "Variable Name";
            // 
            // TitleLabel
            // 
            TitleLabel.AutoSize = true;
            TitleLabel.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TitleLabel.ForeColor = Color.FromArgb(114, 137, 218);
            TitleLabel.Location = new Point(23, 20);
            TitleLabel.Name = "TitleLabel";
            TitleLabel.Size = new Size(358, 54);
            TitleLabel.TabIndex = 10;
            TitleLabel.Text = "Manage Variables";
            // 
            // variables
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(894, 553);
            Controls.Add(mainPanel);
            Controls.Add(panel1);
            Font = new Font("Corbel", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.White;
            MinimumSize = new Size(800, 600);
            Name = "variables";
            Text = "Voice Tale | Variable Management";
            WindowState = FormWindowState.Maximized;
            Load += VariableSaving_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Info).EndInit();
            mainPanel.ResumeLayout(false);
            mainPanel.PerformLayout();
            ResumeLayout(false);
        }

        private Panel panel1;
        private PictureBox Info;
        private Panel mainPanel;
        private Label TitleLabel;
        private TextBox VariableName;
        private Label VariableNameLabel;
        private TextBox VariableValue;
        private Label VariableValueLabel;
        private Button SaveButton;
        private Label label2;
        private Label label3;
        private ComboBox VariableList;
        private Label VariableListLabel;
        private Button DeleteButton;
    }
}