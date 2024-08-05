using MultipleSupportProgram.Screen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultipleSupportProgram
{
    internal static class Program
    {
        /// <summary>
        /// Uygulamanın ana girdi noktası.
        /// </summary>
        [STAThread]
        static void Main()
        {


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            loginScreen loginForm = new loginScreen();
            loginForm.ShowDialog();
            // Application.Run(new MainForm());
            
            
            
            
        }
    }
}
