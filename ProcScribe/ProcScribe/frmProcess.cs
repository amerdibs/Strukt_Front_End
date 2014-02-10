using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProcScribe
{
    public partial class frmProcess : Form
    {
        public frmProcess()
        {
            InitializeComponent();
        }

        private void btn_process_Click(object sender, EventArgs e)
        {
            string strProcessName = txt_processName.Text;
            string addStruktProcess(String strProcessName);
        }
    }
}
