using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SRS.DeskApp
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

            using (var login = new Login2())
            {
                login.WindowState = FormWindowState.Normal;
                if (login.ShowDialog() != DialogResult.OK)
                    Application.Run(new MDIMainForm());
                    //Application.Run(new MetroForm());
                else
                    Application.Exit();
                    
            }

            //Application.Run(new MDIMainForm());
            //Application.Run(new MetroForm());
            
        }
    }
}
