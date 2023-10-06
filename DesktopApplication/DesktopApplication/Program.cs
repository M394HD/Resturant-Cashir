using DesktopApplication.Classes;
using DesktopApplication.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopApplication
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            declarations.userId = -1;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            adoClass.SetConeection();
            Application.Run(new FormLogin());
        }
    }
}
