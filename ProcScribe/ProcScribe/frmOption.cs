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
            this.Height -= 260; 
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

        private void btnColorBack_Click(object sender, EventArgs e)
        {
            if (cdDialog.ShowDialog() == DialogResult.OK)
            {
                txtColorBack.BackColor = cdDialog.Color;
                txtColorBack.Tag = cdDialog.Color;
            }

        }

        private void btnColorTask_Click(object sender, EventArgs e)
        {
            if (cdDialog.ShowDialog() == DialogResult.OK)
            {
                txtColorTask.BackColor = cdDialog.Color;
                txtColorTask.Tag = cdDialog.Color;
            }
        }

        private void btnColorText1_Click(object sender, EventArgs e)
        {
            if (cdDialog.ShowDialog() == DialogResult.OK)
            {
                txtColorText1.BackColor = cdDialog.Color;
                txtColorText1.Tag = cdDialog.Color;
            }
        }

        private void btnColorText2_Click(object sender, EventArgs e)
        {
            if (cdDialog.ShowDialog() == DialogResult.OK)
            {
                txtColorText2.BackColor = cdDialog.Color;
                txtColorText2.Tag = cdDialog.Color;
            }
        }

        private void btnColorText3_Click(object sender, EventArgs e)
        {
            if (cdDialog.ShowDialog() == DialogResult.OK)
            {
                txtColorText3.BackColor = cdDialog.Color;
                txtColorText3.Tag = cdDialog.Color;
            }
        }

        private void btnColorText4_Click(object sender, EventArgs e)
        {
            if (cdDialog.ShowDialog() == DialogResult.OK)
            {
                txtColorText4.BackColor = cdDialog.Color;
                txtColorText4.Tag = cdDialog.Color;
            }
        }

        private void btnAdvance_Click(object sender, EventArgs e)
        {
            gbColor.Visible = true;
        }

        private void btnTaskSelectColor_Click(object sender, EventArgs e)
        {
            if (cdDialog.ShowDialog() == DialogResult.OK)
            {
                txtTaskSelectColor.BackColor = cdDialog.Color;
                txtTaskSelectColor.Tag = cdDialog.Color;
            }
        }
    }
}
