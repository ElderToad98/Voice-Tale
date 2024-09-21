using System.Drawing.Drawing2D;

namespace Voice_Tale
{
    partial class WelcomeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WelcomeForm));
            gradientPanel = new Panel();
            logoPanel = new Panel();
            Youtube = new PictureBox();
            Github = new PictureBox();
            Discord = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            NameBox = new TextBox();
            button1 = new Button();
            gradientPanel.SuspendLayout();
            logoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Youtube).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Github).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Discord).BeginInit();
            SuspendLayout();
            // 
            // gradientPanel
            // 
            gradientPanel.BackColor = Color.FromArgb(35, 39, 42);
            gradientPanel.Controls.Add(logoPanel);
            gradientPanel.Controls.Add(label1);
            gradientPanel.Controls.Add(label2);
            gradientPanel.Controls.Add(label3);
            gradientPanel.Controls.Add(NameBox);
            gradientPanel.Controls.Add(button1);
            gradientPanel.Dock = DockStyle.Fill;
            gradientPanel.Location = new Point(0, 0);
            gradientPanel.Name = "gradientPanel";
            gradientPanel.Size = new Size(1100, 600);
            gradientPanel.TabIndex = 0;
            gradientPanel.Paint += GradientPanel_Paint;
            // 
            // logoPanel
            // 
            logoPanel.BackColor = Color.FromArgb(114, 137, 218);
            logoPanel.Controls.Add(Youtube);
            logoPanel.Controls.Add(Github);
            logoPanel.Controls.Add(Discord);
            logoPanel.Location = new Point(0, 0);
            logoPanel.Name = "logoPanel";
            logoPanel.Size = new Size(300, 600);
            logoPanel.TabIndex = 0;
            // 
            // Youtube
            // 
            Youtube.Cursor = Cursors.Hand;
            Youtube.Image = (Image)resources.GetObject("Youtube.Image");
            Youtube.Location = new Point(62, 402);
            Youtube.Name = "Youtube";
            Youtube.Size = new Size(186, 154);
            Youtube.TabIndex = 3;
            Youtube.TabStop = false;
            Youtube.Click += Youtube_Click;
            // 
            // Github
            // 
            Github.Cursor = Cursors.Hand;
            Github.Image = (Image)resources.GetObject("Github.Image");
            Github.Location = new Point(62, 214);
            Github.Name = "Github";
            Github.Size = new Size(153, 150);
            Github.TabIndex = 2;
            Github.TabStop = false;
            Github.Click += Github_Click;
            // 
            // Discord
            // 
            Discord.Cursor = Cursors.Hand;
            Discord.Image = (Image)resources.GetObject("Discord.Image");
            Discord.Location = new Point(62, 30);
            Discord.Name = "Discord";
            Discord.Size = new Size(168, 158);
            Discord.TabIndex = 1;
            Discord.TabStop = false;
            Discord.Click += Discord_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Corbel", 30.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(114, 137, 218);
            label1.Location = new Point(350, 50);
            label1.Name = "label1";
            label1.Size = new Size(539, 64);
            label1.TabIndex = 1;
            label1.Text = "Welcome to Voice Tale!";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Corbel", 13F);
            label2.ForeColor = Color.White;
            label2.Location = new Point(332, 134);
            label2.Name = "label2";
            label2.Size = new Size(737, 54);
            label2.TabIndex = 2;
            label2.Text = "Voice Tale is an interactive Township Tale tool similar to Voice Attack.\nPlease enter what we should call you, or say \"My name is {name}\" to get started!";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Corbel", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(153, 170, 181);
            label3.Location = new Point(355, 250);
            label3.Name = "label3";
            label3.Size = new Size(347, 37);
            label3.TabIndex = 3;
            label3.Text = "What Should we Call You?";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // NameBox
            // 
            NameBox.BackColor = Color.FromArgb(64, 68, 75);
            NameBox.BorderStyle = BorderStyle.None;
            NameBox.Font = new Font("Corbel", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            NameBox.ForeColor = Color.White;
            NameBox.Location = new Point(355, 300);
            NameBox.Name = "NameBox";
            NameBox.PlaceholderText = "Elder Toad";
            NameBox.Size = new Size(400, 41);
            NameBox.TabIndex = 4;
            NameBox.TextChanged += NameBox_TextChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(114, 137, 218);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Corbel", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(355, 380);
            button1.Name = "button1";
            button1.Size = new Size(200, 50);
            button1.TabIndex = 5;
            button1.Text = "Continue";
            button1.UseVisualStyleBackColor = false;
            button1.Click += Button1_Click;
            // 
            // WelcomeForm
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1100, 600);
            Controls.Add(gradientPanel);
            Font = new Font("Corbel", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "WelcomeForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Voice Tale | Welcome";
            Load += WelcomeForm_Load;
            gradientPanel.ResumeLayout(false);
            gradientPanel.PerformLayout();
            logoPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Youtube).EndInit();
            ((System.ComponentModel.ISupportInitialize)Github).EndInit();
            ((System.ComponentModel.ISupportInitialize)Discord).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel gradientPanel;
        private Panel logoPanel;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox NameBox;
        private Button button1;

        private void GradientPanel_Paint(object sender, PaintEventArgs e)
        {
            using (LinearGradientBrush brush = new LinearGradientBrush(gradientPanel.ClientRectangle,
                                                                       Color.FromArgb(35, 39, 42),
                                                                       Color.FromArgb(44, 47, 51),
                                                                       LinearGradientMode.Vertical))
            {
                e.Graphics.FillRectangle(brush, gradientPanel.ClientRectangle);
            }
        }

        private PictureBox Youtube;
        private PictureBox Github;
        private PictureBox Discord;
    }
}