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
    public partial class frmAssign : Form
    {
        public Task taskAssign { get; set; }

        public frmAssign()
        {
            InitializeComponent();
        }

        private void frmAssign_Load(object sender, EventArgs e)
        {
            StruktWebservice.StruktUserSoapClient wsStrukt = new StruktWebservice.StruktUserSoapClient();
            DataTable dtUser  = wsStrukt.getUserAll();
            cbUser.DataSource = dtUser;
            cbUser.DisplayMember = "u_name";
            cbUser.ValueMember = "u_id";
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult result1 = MessageBox.Show("Do you want to cancel?",
                                       "Please confirm",
                                       MessageBoxButtons.OKCancel);
            if (result1 == System.Windows.Forms.DialogResult.OK)
                Close();
            else
                return;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {



        }
    }
}
