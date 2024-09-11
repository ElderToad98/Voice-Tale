using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Voice_Tale.Main
{
    public partial class Settings : Form
    {
        DatabaseOperations dbop = new DatabaseOperations();

        public Settings()
        {
            InitializeComponent();

            ServerID.Text = dbop.GetServerId().ToString(); // Sets the base id to what it already is
            Confidence.Text = dbop.GetConfidence().ToString();

            Beep.Checked = dbop.IsBeep();
            Speak.Checked = dbop.IsVoice(); 

        }


        // This is the save button
        private void Save_Click(object sender, EventArgs e)
        {

            // ServerID
            var serverId = ServerID.Text;
            if (string.IsNullOrWhiteSpace(serverId))
            {
                MessageBox.Show("Server ID cannot be empty!");
                return;
            }

            if (!serverId.All(char.IsDigit))
            {
                MessageBox.Show("Server ID must contain only digits!");
                return;
            }

            int serverInt;
            if (!int.TryParse(serverId, out serverInt))
            {
                MessageBox.Show("Invalid Server ID format!");
                return;
            }
            dbop.ChangeServerId(serverInt);


            // Confidence

            var c = Confidence.Text;
            if (string.IsNullOrWhiteSpace(c))
            {
                MessageBox.Show("Confidence cannot be empty!");
                return;
            }

            float cInt;
            if (!float.TryParse(c, out cInt))
            {
                MessageBox.Show("Invalid Confidence format!");
                return;
            }

            dbop.ChangeConfidence(cInt);

            // Beep on Command
            if (Beep.Checked)
            {

                dbop.ChangeBeep(1);

            }
            else
            {
                dbop.ChangeBeep(0);
            }

            // Speak on command

            
            if (Speak.Checked)
            {

                dbop.ChangeVoice(1);

            }
            else
            {
                dbop.ChangeVoice(0);
            }
             




            MessageBox.Show("Settings saved!");


            this.Close();


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Beep_CheckedChanged(object sender, EventArgs e)
        {
            
        }
    }
}
