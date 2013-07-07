using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mockup2
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
            frmLogin fLogin = new frmLogin();
            if (fLogin.ShowDialog() == DialogResult.Cancel) 
            {
                Application.Exit(); 
            }
            else
            {
                Application.Run(new frmMain());
            }
            //Application.Run(new frmMain());
            //Application.Run(new TestFunction());
            //Application.Run(new frmTaskEdit());
        }
    }
}
