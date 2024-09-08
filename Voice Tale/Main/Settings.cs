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
            MessageBox.Show("Settings saved!");


            this.Close();


        }
    }
}
