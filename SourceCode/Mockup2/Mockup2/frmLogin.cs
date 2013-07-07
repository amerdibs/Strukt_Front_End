using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Mockup2
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            StruktWebservice.StruktUserSoapClient wsStrukt = new StruktWebservice.StruktUserSoapClient();
            global.processTable = wsStrukt.checkLogin(txtUserName.Text, txtPassword.Text);
            if (global.processTable == null)
            {
                MessageBox.Show("Wrong Username or Password", "Please try again");
            }
            else
            {
                Close();
            }
        }

        private void btnPass_Click(object sender, EventArgs e)
        {
            StruktWebservice.StruktUserSoapClient wsStrukt = new StruktWebservice.StruktUserSoapClient();
            global.processTable = wsStrukt.getProcessAll();
            Close();
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            this.Width = 350;
            txtTest.Text = "User name: \r\n pakorn \r\n amer \r\n tariq \r\n Password: \r\n strukt \r\n (Processes are different.)";
        }
    }
}
