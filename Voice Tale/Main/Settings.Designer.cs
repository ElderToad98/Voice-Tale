using System;
using System.Drawing;
using System.Windows.Forms;

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
            label1 = new Label();
            User = new Label();
            ServerID = new TextBox();
            label2 = new Label();
            Confidence = new TextBox();
            Beep = new CheckBox();
            Speak = new CheckBox();
            DiscordPresence = new CheckBox();
            infoButton = new Button();
            Save = new Button();
            pictureBox1 = new PictureBox();
            Keyboard = new CheckBox();
            Voice = new CheckBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 28F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(114, 137, 218);
            label1.Location = new Point(26, 6);
            label1.Name = "label1";
            label1.Size = new Size(205, 62);
            label1.TabIndex = 12;
            label1.Text = "Settings";
            // 
            // User
            // 
            User.AutoSize = true;
            User.Font = new Font("Segoe UI", 10F);
            User.ForeColor = Color.FromArgb(153, 170, 181);
            User.Location = new Point(35, 68);
            User.Name = "User";
            User.Size = new Size(79, 23);
            User.TabIndex = 15;
            User.Text = "Server ID";
            // 
            // ServerID
            // 
            ServerID.BackColor = Color.FromArgb(64, 68, 75);
            ServerID.BorderStyle = BorderStyle.FixedSingle;
            ServerID.Font = new Font("Segoe UI", 14F);
            ServerID.ForeColor = Color.White;
            ServerID.Location = new Point(35, 97);
            ServerID.Name = "ServerID";
            ServerID.PlaceholderText = "Enter Server ID";
            ServerID.Size = new Size(279, 39);
            ServerID.TabIndex = 14;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.ForeColor = Color.FromArgb(153, 170, 181);
            label2.Location = new Point(35, 154);
            label2.Name = "label2";
            label2.Size = new Size(96, 23);
            label2.TabIndex = 17;
            label2.Text = "Confidence";
            // 
            // Confidence
            // 
            Confidence.BackColor = Color.FromArgb(64, 68, 75);
            Confidence.BorderStyle = BorderStyle.FixedSingle;
            Confidence.Font = new Font("Segoe UI", 14F);
            Confidence.ForeColor = Color.White;
            Confidence.Location = new Point(35, 180);
            Confidence.Name = "Confidence";
            Confidence.PlaceholderText = "Enter Confidence Value";
            Confidence.Size = new Size(279, 39);
            Confidence.TabIndex = 16;
            // 
            // Beep
            // 
            Beep.AutoSize = true;
            Beep.Font = new Font("Segoe UI", 12F);
            Beep.ForeColor = Color.White;
            Beep.Location = new Point(35, 276);
            Beep.Name = "Beep";
            Beep.Size = new Size(279, 32);
            Beep.TabIndex = 19;
            Beep.Text = "Beep on Speech Recognized";
            Beep.UseVisualStyleBackColor = true;
            // 
            // Speak
            // 
            Speak.AutoSize = true;
            Speak.Font = new Font("Segoe UI", 12F);
            Speak.ForeColor = Color.White;
            Speak.Location = new Point(35, 238);
            Speak.Name = "Speak";
            Speak.Size = new Size(267, 32);
            Speak.TabIndex = 20;
            Speak.Text = "TTS on Speech Recognized";
            Speak.UseVisualStyleBackColor = true;
            // 
            // DiscordPresence
            // 
            DiscordPresence.AutoSize = true;
            DiscordPresence.Font = new Font("Segoe UI", 12F);
            DiscordPresence.ForeColor = Color.White;
            DiscordPresence.Location = new Point(35, 314);
            DiscordPresence.Name = "DiscordPresence";
            DiscordPresence.Size = new Size(182, 32);
            DiscordPresence.TabIndex = 21;
            DiscordPresence.Text = "Discord Presence";
            DiscordPresence.UseVisualStyleBackColor = true;
            // 
            // infoButton
            // 
            infoButton.BackColor = Color.Transparent;
            infoButton.FlatAppearance.BorderSize = 0;
            infoButton.FlatStyle = FlatStyle.Flat;
            infoButton.Image = (Image)resources.GetObject("infoButton.Image");
            infoButton.Location = new Point(254, 8);
            infoButton.Name = "infoButton";
            infoButton.Size = new Size(60, 60);
            infoButton.TabIndex = 23;
            infoButton.UseVisualStyleBackColor = false;
            infoButton.Click += infoButton_Click;
            // 
            // Save
            // 
            Save.BackColor = Color.FromArgb(114, 137, 218);
            Save.FlatAppearance.BorderSize = 0;
            Save.FlatStyle = FlatStyle.Flat;
            Save.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            Save.ForeColor = Color.White;
            Save.Location = new Point(35, 438);
            Save.Name = "Save";
            Save.Size = new Size(279, 46);
            Save.TabIndex = 13;
            Save.Text = "Save Changes";
            Save.UseVisualStyleBackColor = false;
            Save.Click += Save_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(320, 107);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(42, 29);
            pictureBox1.TabIndex = 24;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // Keyboard
            // 
            Keyboard.AutoSize = true;
            Keyboard.Font = new Font("Segoe UI", 12F);
            Keyboard.ForeColor = Color.White;
            Keyboard.Location = new Point(35, 352);
            Keyboard.Name = "Keyboard";
            Keyboard.Size = new Size(207, 32);
            Keyboard.TabIndex = 25;
            Keyboard.Text = "Keyboard Shortcuts";
            Keyboard.UseVisualStyleBackColor = true;
            // 
            // Voice
            // 
            Voice.AutoSize = true;
            Voice.Font = new Font("Segoe UI", 12F);
            Voice.ForeColor = Color.White;
            Voice.Location = new Point(35, 390);
            Voice.Name = "Voice";
            Voice.Size = new Size(169, 32);
            Voice.TabIndex = 26;
            Voice.Text = "Voice Shortcuts";
            Voice.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.BackColor = Color.Red;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 192, 192);
            button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 128, 128);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Corbel", 8.25F);
            button1.ForeColor = Color.White;
            button1.Location = new Point(54, 490);
            button1.Name = "button1";
            button1.Size = new Size(248, 29);
            button1.TabIndex = 27;
            button1.Text = "Reset Username or Password";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Settings
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(35, 39, 42);
            ClientSize = new Size(368, 540);
            Controls.Add(button1);
            Controls.Add(Voice);
            Controls.Add(Keyboard);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(User);
            Controls.Add(ServerID);
            Controls.Add(label2);
            Controls.Add(Confidence);
            Controls.Add(Beep);
            Controls.Add(Speak);
            Controls.Add(DiscordPresence);
            Controls.Add(infoButton);
            Controls.Add(Save);
            Font = new Font("Segoe UI", 9F);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Settings";
            Text = "Voice Tale | Settings";
            Load += Settings_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button Save;
        private TextBox ServerID;
        private Label User;
        private TextBox Confidence;
        private Label label2;
        private CheckBox Speak;
        private Button infoButton;
        private CheckBox DiscordPresence;
        private CheckBox Beep;
        private PictureBox pictureBox1;
        private CheckBox Keyboard;
        private CheckBox Voice;
        private Button button1;
    }
}