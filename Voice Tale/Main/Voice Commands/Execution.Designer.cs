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

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Execution));
            panel1 = new Panel();
            File = new PictureBox();
            Info = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            CommandList = new ListBox();
            CommandLog = new ListBox();
            ConnLabel = new Label();
            label4 = new Label();
            label5 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)File).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Info).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(114, 137, 218);
            panel1.Controls.Add(File);
            panel1.Controls.Add(Info);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(120, 560);
            panel1.TabIndex = 9;
            // 
            // File
            // 
            File.Cursor = Cursors.Hand;
            File.Image = (Image)resources.GetObject("File.Image");
            File.Location = new Point(35, 180);
            File.Name = "File";
            File.Size = new Size(51, 62);
            File.TabIndex = 16;
            File.TabStop = false;
            File.Click += File_Click;
            // 
            // Info
            // 
            Info.Cursor = Cursors.Hand;
            Info.Image = (Image)resources.GetObject("Info.Image");
            Info.Location = new Point(35, 40);
            Info.Name = "Info";
            Info.Size = new Size(51, 62);
            Info.TabIndex = 10;
            Info.TabStop = false;
            Info.Click += Info_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Corbel", 32F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(114, 137, 218);
            label1.Location = new Point(180, 30);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(521, 66);
            label1.TabIndex = 10;
            label1.Text = "Execute a Command!";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.FromArgb(153, 170, 181);
            label2.Location = new Point(275, 100);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(278, 24);
            label2.TabIndex = 16;
            label2.Text = "Speak a command to execute it!";
            // 
            // CommandList
            // 
            CommandList.BackColor = Color.FromArgb(35, 39, 50);
            CommandList.ForeColor = Color.White;
            CommandList.FormattingEnabled = true;
            CommandList.ItemHeight = 24;
            CommandList.Location = new Point(201, 180);
            CommandList.Name = "CommandList";
            CommandList.Size = new Size(250, 292);
            CommandList.TabIndex = 17;
            CommandList.TabStop = false;
            // 
            // CommandLog
            // 
            CommandLog.BackColor = Color.FromArgb(35, 39, 50);
            CommandLog.ForeColor = Color.White;
            CommandLog.FormattingEnabled = true;
            CommandLog.ItemHeight = 24;
            CommandLog.Location = new Point(608, 180);
            CommandLog.Name = "CommandLog";
            CommandLog.Size = new Size(250, 292);
            CommandLog.TabIndex = 18;
            // 
            // ConnLabel
            // 
            ConnLabel.AutoSize = true;
            ConnLabel.Font = new Font("Corbel", 10F);
            ConnLabel.ForeColor = Color.FromArgb(153, 170, 181);
            ConnLabel.Location = new Point(722, 40);
            ConnLabel.Margin = new Padding(4, 0, 4, 0);
            ConnLabel.Name = "ConnLabel";
            ConnLabel.Size = new Size(178, 21);
            ConnLabel.TabIndex = 20;
            ConnLabel.Text = "Connected Server: None";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.FromArgb(153, 170, 181);
            label4.Location = new Point(256, 500);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(133, 24);
            label4.TabIndex = 21;
            label4.Text = "Command List";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.FromArgb(153, 170, 181);
            label5.Location = new Point(671, 500);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(135, 24);
            label5.TabIndex = 22;
            label5.Text = "Command Log";
            // 
            // Execution
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(35, 39, 42);
            ClientSize = new Size(950, 560);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(ConnLabel);
            Controls.Add(CommandLog);
            Controls.Add(CommandList);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Font = new Font("Corbel", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.White;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "Execution";
            Text = "Command Creation";
            Load += Execution_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)File).EndInit();
            ((System.ComponentModel.ISupportInitialize)Info).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }


        #endregion

        private Panel panel1;
        private PictureBox Info;
        private Label label1;
        private PictureBox File;
        private Label label2;
        private ListBox CommandList;
        private ListBox CommandLog;
        private Label ConnLabel;
        private Label label4;
        private Label label5;
    }
}
