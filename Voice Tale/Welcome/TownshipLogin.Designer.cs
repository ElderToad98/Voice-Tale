namespace Voice_Tale.Welcome
{
    partial class TownshipLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TownshipLogin));
            label1 = new Label();
            Password = new Label();
            User = new Label();
            Username = new TextBox();
            pictureBox1 = new PictureBox();
            Passwordb = new TextBox();
            panel1 = new Panel();
            Github = new PictureBox();
            label2 = new Label();
            Misc = new Label();
            Login = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Github).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Corbel", 30.8F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(114, 137, 218);
            label1.Location = new Point(24, 19);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(454, 64);
            label1.TabIndex = 0;
            label1.Text = "Login to Township!";
            // 
            // Password
            // 
            Password.AutoSize = true;
            Password.ForeColor = Color.FromArgb(153, 170, 181);
            Password.Location = new Point(31, 238);
            Password.Margin = new Padding(4, 0, 4, 0);
            Password.Name = "Password";
            Password.Size = new Size(92, 24);
            Password.TabIndex = 2;
            Password.Text = "Password";
            // 
            // User
            // 
            User.AutoSize = true;
            User.ForeColor = Color.FromArgb(153, 170, 181);
            User.Location = new Point(31, 130);
            User.Margin = new Padding(4, 0, 4, 0);
            User.Name = "User";
            User.Size = new Size(97, 24);
            User.TabIndex = 3;
            User.Text = "Username";
            // 
            // Username
            // 
            Username.BackColor = Color.FromArgb(64, 68, 75);
            Username.BorderStyle = BorderStyle.None;
            Username.Font = new Font("Corbel", 20F, FontStyle.Bold);
            Username.ForeColor = Color.White;
            Username.Location = new Point(31, 170);
            Username.Margin = new Padding(4);
            Username.Name = "Username";
            Username.PlaceholderText = "Elder Toad";
            Username.Size = new Size(447, 41);
            Username.TabIndex = 4;
            // 
            // pictureBox1
            // 
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(394, 266);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(54, 52);
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // Passwordb
            // 
            Passwordb.BackColor = Color.FromArgb(64, 68, 75);
            Passwordb.BorderStyle = BorderStyle.None;
            Passwordb.Font = new Font("Corbel", 20F, FontStyle.Bold);
            Passwordb.ForeColor = Color.White;
            Passwordb.Location = new Point(31, 266);
            Passwordb.Margin = new Padding(4);
            Passwordb.Name = "Passwordb";
            Passwordb.PlaceholderText = "Password123";
            Passwordb.Size = new Size(356, 41);
            Passwordb.TabIndex = 5;
            Passwordb.UseSystemPasswordChar = true;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(114, 137, 218);
            panel1.Controls.Add(Github);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(565, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(331, 555);
            panel1.TabIndex = 7;
            // 
            // Github
            // 
            Github.Cursor = Cursors.Hand;
            Github.Image = (Image)resources.GetObject("Github.Image");
            Github.Location = new Point(83, 216);
            Github.Name = "Github";
            Github.Size = new Size(153, 150);
            Github.TabIndex = 8;
            Github.TabStop = false;
            Github.Click += Github_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(23, 48);
            label2.Name = "label2";
            label2.Size = new Size(285, 144);
            label2.TabIndex = 0;
            label2.Text = "We ask this question so we\r\ncan send commands to servers.\r\nThis data is only stored on your \r\ncomputer. We have no access to \r\nthis information. Feel free to \r\nlook through the source code.";
            // 
            // Misc
            // 
            Misc.AutoSize = true;
            Misc.Font = new Font("Corbel", 15F, FontStyle.Bold);
            Misc.ForeColor = Color.FromArgb(153, 170, 181);
            Misc.Location = new Point(220, 513);
            Misc.Margin = new Padding(4, 0, 4, 0);
            Misc.Name = "Misc";
            Misc.Size = new Size(0, 31);
            Misc.TabIndex = 8;
            // 
            // Login
            // 
            Login.BackColor = Color.FromArgb(114, 137, 218);
            Login.FlatAppearance.BorderSize = 0;
            Login.FlatStyle = FlatStyle.Flat;
            Login.Font = new Font("Corbel", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Login.ForeColor = Color.White;
            Login.Location = new Point(31, 337);
            Login.Name = "Login";
            Login.Size = new Size(200, 50);
            Login.TabIndex = 9;
            Login.Text = "Login";
            Login.UseVisualStyleBackColor = false;
            // 
            // TownshipLogin
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(35, 39, 42);
            ClientSize = new Size(894, 553);
            Controls.Add(Login);
            Controls.Add(Misc);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Controls.Add(Passwordb);
            Controls.Add(Username);
            Controls.Add(User);
            Controls.Add(Password);
            Controls.Add(label1);
            Font = new Font("Corbel", 12F, FontStyle.Bold);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "TownshipLogin";
            Text = "Township Login";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Github).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label Password;
        private Label User;
        private TextBox Username;
        private PictureBox pictureBox1;
        private TextBox Passwordb;
        private Panel panel1;
        private Label label2;
        private PictureBox Github;
        private Label Misc;
        private Button Login;
    }
}