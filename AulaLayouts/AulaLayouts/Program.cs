using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using AulaLayouts.Screen.Home;

namespace AulaLayouts
{
    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Home home = new Home();
            SplashScreen splashScreen = new SplashScreen();
            Paineis paineis = new Paineis();
            Tables tables = new Tables();

            Application.Run(tables);

            if (splashScreen.IsDisposed)
            {
                Application.Run(home);
            }
        }
    }
}
