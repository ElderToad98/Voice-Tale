﻿using System;
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

            if (MessageBox.Show($"Are you sure you want to save these settings?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
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

            else
            {
                MessageBox.Show("Settings not saved!");
                this.Close();
            }


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Beep_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void infoButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is the area where you can change your settings, duh.\n\nServer ID: The server ID that all commands will be sent on.\n\nConfidence: Speech recognition confidence. The higher the number the more confident the program has to be to run a voice command. 0.94 seems to work best.\n\nBeep on Command: Beep when a voice command is ran successfully.\n\nTTS on Command: Text to speech will say your command name when the voice command is executed successfully.");
        }
    }
}
