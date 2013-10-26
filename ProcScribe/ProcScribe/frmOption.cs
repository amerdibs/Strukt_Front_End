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
            this.Height -= 134; 
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


        private void btnColorTask_Click(object sender, EventArgs e)
        {
            if (cdDialog.ShowDialog() == DialogResult.OK)
            {
                txtColorTask.BackColor = cdDialog.Color;
                txtColorTask.Tag = cdDialog.Color;
            }
        }

        private void btnAdvance_Click(object sender, EventArgs e)
        {
            if (!gbColor.Visible)
            {
                gbColor.Visible = true;
                this.Height += 134;
                txtColorTask.BackColor = global.ColorMainTask;
                txtColorTask.Tag = global.ColorMainTask;
                txtTaskSelectColor.BackColor = global.ColorSelect;
                txtTaskSelectColor.Tag = global.ColorSelect;
                txtTaskHoverColor.BackColor = global.ColorHover;
                txtTaskHoverColor.Tag = global.ColorHover;
            }
        }

        private void btnTaskSelectColor_Click(object sender, EventArgs e)
        {
            if (cdDialog.ShowDialog() == DialogResult.OK)
            {
                txtTaskSelectColor.BackColor = cdDialog.Color;
                txtTaskSelectColor.Tag = cdDialog.Color;
            }
        }

        private void btnDefault_Click(object sender, EventArgs e)
        {
            txtColorTask.BackColor = global.ColorMainTaskDefault;
            txtColorTask.Tag = global.ColorMainTaskDefault;
            txtTaskSelectColor.BackColor = global.ColorSelectDefault;
            txtTaskSelectColor.Tag = global.ColorSelectDefault;
            txtTaskHoverColor.BackColor = global.ColorHoverDefault;
            txtTaskHoverColor.Tag = global.ColorHoverDefault;
        }

        private void btnTaskHoverColor_Click(object sender, EventArgs e)
        {
            if (cdDialog.ShowDialog() == DialogResult.OK)
            {
                txtTaskHoverColor.BackColor = cdDialog.Color;
                txtTaskHoverColor.Tag = cdDialog.Color;
            }
        }
    }
}
