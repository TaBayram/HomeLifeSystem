using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeLifeSystem
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
            CreateSignScreen();
            Application.Run();
        }

        public static void CreateSignScreen()
        {
            new SignScreen().Show();
        }
        public static void CreateMainScreen(Person user)
        {
            new MainScreen(user).Show();
        }
    }
}
