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
    public partial class frmTaskEdit : Form
    {
        public frmTaskEdit()
        {
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void frmTaskEdit_Load(object sender, EventArgs e)
        {
            ccbTask.SelectedIndex = 1;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
