using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;


namespace ProcScribe
{
    public partial class frmOption : Form
    {
        private frmMain frmParent;

        public frmOption()
        {
            InitializeComponent();
        }

        public frmOption(frmMain fMain)
        {
            InitializeComponent();
            frmParent = fMain;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            //save configurations into registry
            RegistryKey readReg;
            readReg = Registry.CurrentUser.OpenSubKey(global.registryPath, true);
            if (cbTop.Checked)
            {
                readReg.SetValue("ALLWAYTOP", "TRUE");
                frmParent.TopMost = true;
            }
            else
            {
                readReg.SetValue("ALLWAYTOP", "FALSE");
                frmParent.TopMost = false;
            }
            this.Close();
        }

        private void frmOption_Load(object sender, EventArgs e)
        {
            //load configurations from registry
            RegistryKey readReg;
            readReg = Registry.CurrentUser.OpenSubKey(global.registryPath, true);
            String strTop = readReg.GetValue("ALLWAYTOP", "FALSE").ToString();

            if (strTop == "FALSE")
            {
                cbTop.Checked = false;
            }
            else
            {
                cbTop.Checked = true;
            }

        }
    }
}
