namespace Voice_Tale.Main.Modules
{
    partial class ManualCommand : Form
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
            tableLayoutPanel1 = new TableLayoutPanel();
            connLabel = new Label();
            label2 = new Label();
            Command = new TextBox();
            checkBoxPanel = new TableLayoutPanel();
            Clear = new CheckBox();
            ShowJson = new CheckBox();
            Send = new Button();
            label1 = new Label();
            panel1 = new Panel();
            tableLayoutPanel1.SuspendLayout();
            checkBoxPanel.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(connLabel, 0, 6);
            tableLayoutPanel1.Controls.Add(label2, 0, 3);
            tableLayoutPanel1.Controls.Add(Command, 0, 4);
            tableLayoutPanel1.Controls.Add(checkBoxPanel, 0, 5);
            tableLayoutPanel1.Controls.Add(Send, 0, 6);
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(10, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new Padding(20);
            tableLayoutPanel1.RowCount = 7;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(588, 353);
            tableLayoutPanel1.TabIndex = 21;
            tableLayoutPanel1.Paint += tableLayoutPanel1_Paint;
            // 
            // connLabel
            // 
            connLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            connLabel.AutoSize = true;
            connLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            connLabel.ForeColor = Color.FromArgb(153, 170, 181);
            connLabel.Location = new Point(397, 194);
            connLabel.Name = "connLabel";
            connLabel.Size = new Size(168, 20);
            connLabel.TabIndex = 23;
            connLabel.Text = "Connected Server: None";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.ForeColor = Color.FromArgb(153, 170, 181);
            label2.Location = new Point(23, 82);
            label2.Name = "label2";
            label2.Size = new Size(90, 23);
            label2.TabIndex = 17;
            label2.Text = "Command";
            // 
            // Command
            // 
            Command.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            Command.BackColor = Color.FromArgb(64, 68, 75);
            Command.BorderStyle = BorderStyle.FixedSingle;
            Command.Font = new Font("Segoe UI", 14F);
            Command.ForeColor = Color.White;
            Command.Location = new Point(23, 108);
            Command.Name = "Command";
            Command.PlaceholderText = "Trade post 'Elder Toad' flint 2";
            Command.Size = new Size(542, 39);
            Command.TabIndex = 16;
            // 
            // checkBoxPanel
            // 
            checkBoxPanel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            checkBoxPanel.AutoSize = true;
            checkBoxPanel.ColumnCount = 2;
            checkBoxPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            checkBoxPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            checkBoxPanel.Controls.Add(Clear, 0, 0);
            checkBoxPanel.Controls.Add(ShowJson, 0, 0);
            checkBoxPanel.Location = new Point(23, 153);
            checkBoxPanel.Name = "checkBoxPanel";
            checkBoxPanel.RowCount = 1;
            checkBoxPanel.RowStyles.Add(new RowStyle());
            checkBoxPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            checkBoxPanel.Size = new Size(542, 38);
            checkBoxPanel.TabIndex = 22;
            // 
            // Clear
            // 
            Clear.AutoSize = true;
            Clear.Font = new Font("Segoe UI", 12F);
            Clear.ForeColor = Color.White;
            Clear.Location = new Point(274, 3);
            Clear.Name = "Clear";
            Clear.Size = new Size(251, 32);
            Clear.TabIndex = 20;
            Clear.Text = "Clear Command on Send";
            Clear.UseVisualStyleBackColor = true;
            // 
            // ShowJson
            // 
            ShowJson.AutoSize = true;
            ShowJson.Font = new Font("Segoe UI", 12F);
            ShowJson.ForeColor = Color.White;
            ShowJson.Location = new Point(3, 3);
            ShowJson.Name = "ShowJson";
            ShowJson.Size = new Size(221, 32);
            ShowJson.TabIndex = 19;
            ShowJson.Text = "Show Command Json";
            ShowJson.UseVisualStyleBackColor = true;
            // 
            // Send
            // 
            Send.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Send.BackColor = Color.FromArgb(114, 137, 218);
            Send.FlatAppearance.BorderSize = 0;
            Send.FlatStyle = FlatStyle.Flat;
            Send.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            Send.ForeColor = Color.White;
            Send.Location = new Point(23, 273);
            Send.Name = "Send";
            Send.Size = new Size(542, 57);
            Send.TabIndex = 13;
            Send.Text = "Send Command";
            Send.UseVisualStyleBackColor = false;
            Send.Click += Send_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 28F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(114, 137, 218);
            label1.Location = new Point(23, 20);
            label1.Name = "label1";
            label1.Size = new Size(374, 62);
            label1.TabIndex = 12;
            label1.Text = "Send Command";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(54, 57, 63);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(10, 353);
            panel1.TabIndex = 18;
            // 
            // ManualCommand
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(35, 39, 42);
            ClientSize = new Size(598, 353);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 9F);
            MinimumSize = new Size(450, 400);
            Name = "ManualCommand";
            Text = "Voice Tale Command Sender";
            Load += ManualCommand_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            checkBoxPanel.ResumeLayout(false);
            checkBoxPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Button Send;
        private TextBox Command;
        private Label label2;
        private Panel panel1;
        private CheckBox ShowJson;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel checkBoxPanel;
        private CheckBox Clear;
        private Label connLabel;
    }
}