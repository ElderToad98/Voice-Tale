namespace Voice_Tale.Main
{
    partial class Settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            label1 = new Label();
            Save = new Button();
            ServerID = new TextBox();
            User = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Corbel", 30.8F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(114, 137, 218);
            label1.Location = new Point(36, 9);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(217, 64);
            label1.TabIndex = 12;
            label1.Text = "Settings";
            // 
            // Save
            // 
            Save.BackColor = Color.FromArgb(114, 137, 218);
            Save.FlatAppearance.BorderSize = 0;
            Save.FlatStyle = FlatStyle.Flat;
            Save.Font = new Font("Corbel", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Save.ForeColor = Color.White;
            Save.Location = new Point(342, 23);
            Save.Name = "Save";
            Save.Size = new Size(200, 50);
            Save.TabIndex = 13;
            Save.Text = "Save";
            Save.UseVisualStyleBackColor = false;
            Save.Click += Save_Click;
            // 
            // ServerID
            // 
            ServerID.BackColor = Color.FromArgb(64, 68, 75);
            ServerID.BorderStyle = BorderStyle.None;
            ServerID.Font = new Font("Corbel", 20F, FontStyle.Bold);
            ServerID.ForeColor = Color.White;
            ServerID.Location = new Point(36, 112);
            ServerID.Margin = new Padding(4);
            ServerID.Name = "ServerID";
            ServerID.PlaceholderText = "12345";
            ServerID.Size = new Size(229, 41);
            ServerID.TabIndex = 14;
            ServerID.Text = "ServerID";
            // 
            // User
            // 
            User.AutoSize = true;
            User.ForeColor = Color.FromArgb(153, 170, 181);
            User.Location = new Point(36, 88);
            User.Margin = new Padding(4, 0, 4, 0);
            User.Name = "User";
            User.Size = new Size(69, 20);
            User.TabIndex = 15;
            User.Text = "Server ID";
            // 
            // Settings
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(35, 39, 42);
            ClientSize = new Size(598, 450);
            Controls.Add(User);
            Controls.Add(ServerID);
            Controls.Add(Save);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Settings";
            Text = "Settings";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button Save;
        private TextBox ServerID;
        private Label User;
    }
}