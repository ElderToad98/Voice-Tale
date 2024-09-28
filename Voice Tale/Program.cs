using DiscordRPC;
using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Voice_Tale.Main.Modules;
using Voice_Tale.Main.Voice_Commands;
using Voice_Tale.Main;
using Voice_Tale.Properties;
using System.Data.SQLite;
using System.Data.Common;

namespace Voice_Tale
{
    static class Program
    {
        [DllImport("Shcore.dll")]
        static extern int SetProcessDpiAwareness(int PROCESS_DPI_AWARENESS);
        private static DiscordRpcClient? client;
        private static MiscOperations? mop;

        private enum DpiAwareness
        {
            None = 0,
            SystemAware = 1,
            PerMonitorAware = 2
        }

        [STAThread]
        static void Main()
        {
            DatabaseOperations dbop = new DatabaseOperations();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            SetProcessDpiAwareness((int)DpiAwareness.PerMonitorAware);
            dbop.InitializeDatabase();

            mop = new MiscOperations(); 

            if (string.IsNullOrEmpty(dbop.GetName()) || !dbop.IsInitCompleted())
            {
                Application.Run(new WelcomeForm());
            }
            else
            {
                if (dbop.IsKeyboardShortcuts())
                {
                    Application.AddMessageFilter(new KeyMessageFilter(mop));
                }

                
                Application.Run(new MainMenu(mop)); 
              
            }
        }

 
    }



    public class KeyMessageFilter : IMessageFilter
    {
        private const int WM_KEYDOWN = 0x0100;
        private readonly MiscOperations mop;
        private readonly DatabaseOperations dbop;

       

        public KeyMessageFilter(MiscOperations mop)
        {
            this.mop = mop ?? throw new ArgumentNullException(nameof(mop));
        }

    
        public bool PreFilterMessage(ref Message m)
        {


          

            if (m.Msg == WM_KEYDOWN && Control.ModifierKeys == Keys.Control)
            {


                try
                {
                    switch ((Keys)m.WParam)
                    {
                        case Keys.M: mop.OpenForm<ManualCommand>(); return true;
                        case Keys.W: mop.OpenForm<variables>(); return true;
                        case Keys.E: mop.OpenForm<Execution>(); return true;
                        case Keys.Q: mop.OpenForm<Creation>(); return true;
                        case Keys.S: mop.OpenForm<Settings>(); return true;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return true;
                }
            }
            return false;
        }
    }


}