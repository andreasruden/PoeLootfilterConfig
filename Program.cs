using System;
using System.Windows.Forms;

namespace PoeLootfilterConfig
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var mainWindow = new MainWindow();
            Application.Run(mainWindow);
        }
    }
}
