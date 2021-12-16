using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
            for (int i = 0; i < 20; ++i)
                mainWindow.AddLevelingFilterOption("test" + i.ToString());
            Application.Run(mainWindow);
        }
    }
}
