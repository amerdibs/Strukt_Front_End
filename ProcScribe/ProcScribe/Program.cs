using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace ProcScribe
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
            //Application.Run(new frmMain());

            // Pakorn comments Logi Page at 15.09.13
            //frmLogin fLogin = new frmLogin();
            //if (fLogin.ShowDialog() == DialogResult.Cancel) 
            //{
            //    Application.Exit(); 
            //}
            //else
            //{
            //    frmMain frM = new frmMain();
            //    Application.Run(frM);
            //}

            //Application.Run(new frmMain());
            Application.Run(new TestFunction());
            //Application.Run(new frmTaskEdit());
        }
    }
}
