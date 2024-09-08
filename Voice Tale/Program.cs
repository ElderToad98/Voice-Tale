using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Voice_Tale.Properties;

namespace Voice_Tale
{

    
    static class Program
    {
        [DllImport("Shcore.dll")]
        static extern int SetProcessDpiAwareness(int PROCESS_DPI_AWARENESS);

        // According to https://msdn.microsoft.com/en-us/library/windows/desktop/dn280512(v=vs.85).aspx
        private enum DpiAwareness
        {
            None = 0,
            SystemAware = 1,
            PerMonitorAware = 2
        }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            DatabaseOperations dbop = new DatabaseOperations();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            SetProcessDpiAwareness((int)DpiAwareness.PerMonitorAware);
            dbop.InitializeDatabase();

            if (string.IsNullOrEmpty(dbop.GetName()) || !dbop.IsInitCompleted())
            {
                Application.Run(new WelcomeForm());
            }
            else
            {
                Application.Run(new MainMenu());
            }
        }
    }
}