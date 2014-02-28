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
            readReg.SetValue("COLORHOVER", txtTaskHoverColor.BackColor.ToArgb());
            readReg.SetValue("COLORSELECT", txtTaskSelectColor.BackColor.ToArgb());
            readReg.SetValue("COLORMAINTASK", txtColorTask.BackColor.ToArgb());
            global.ColorHover = Color.FromArgb(txtTaskHoverColor.BackColor.ToArgb());
            global.ColorSelect = Color.FromArgb(txtTaskSelectColor.BackColor.ToArgb());
            global.ColorMainTask = Color.FromArgb(txtColorTask.BackColor.ToArgb());
            TabControl tabCon = (TabControl)frmParent.Controls["tabCenter"];
            TabPage tabPage0 = (TabPage)tabCon.TabPages[0];
            foreach (object objEach in tabPage0.Controls["pnCenter"].Controls)
            {
                UCMainTask ucTask = (UCMainTask)objEach;
                ucTask.BackColor = global.ColorMainTask;
                ucTask.colorBackGround = global.ColorMainTask;
            }
            if (global.currentTaskControlObject != null)
            {
                Object uControl = global.currentTaskControlObject;
                UCMainTask uSelect = (UCMainTask)uControl;
                uSelect.BackColor = global.ColorSelect;
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

            txtColorTask.BackColor = global.ColorMainTask;
            txtColorTask.Tag = global.ColorMainTask;
            txtTaskSelectColor.BackColor = global.ColorSelect;
            txtTaskSelectColor.Tag = global.ColorSelect;
            txtTaskHoverColor.BackColor = global.ColorHover;
            txtTaskHoverColor.Tag = global.ColorHover;

            if (strTop == "FALSE")
            {
                cbTop.Checked = false;
            }
            else
            {
                cbTop.Checked = true;
            }

            if (global.roleUser == User.roleDesigner)
            {
                rdbtnDesigner.Checked = true;
                rdbtnExecutor.Checked = false;
            }
            else
            {
                rdbtnDesigner.Checked = false;
                rdbtnExecutor.Checked = true;
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

        private void rdbtnExecutor_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbtnExecutor.Checked)
            {
                global.roleUser = User.roleExecutor;

                StatusStrip strp = frmParent.Controls["statusStrip1"] as StatusStrip;
                ComboBox cbProcess = (frmParent.Controls.Find("cbProcess", true))[0] as ComboBox;
                cbProcess.Visible = false;
                strp.Items["tsRole"].Text = "Executor";
                frmParent.Controls["pnDesigner"].Visible = false;
                Button btnLoadProcess = (frmParent.Controls.Find("btnLoadProcess", true))[0] as Button;
                btnLoadProcess.Visible = false;
                TabPage tpGuide = (frmParent.Controls.Find("tpGuide", true))[0] as TabPage;
                tpGuide.Text = "Guide";
                
            }

            
        }

        private void rdbtnDesigner_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbtnDesigner.Checked)
            {
                
                global.roleUser = User.roleDesigner;
                StatusStrip strp = frmParent.Controls["statusStrip1"] as StatusStrip;
                ComboBox cbProcess = (frmParent.Controls.Find("cbProcess", true))[0] as ComboBox;
                cbProcess.Visible = true;
                strp.Items["tsRole"].Text = "Designer";
                frmParent.Controls["pnDesigner"].Visible = true;
                Button btnLoadProcess = (frmParent.Controls.Find("btnLoadProcess", true))[0] as Button;
                btnLoadProcess.Visible = true;
                TabPage tpGuide = (frmParent.Controls.Find("tpGuide", true))[0] as TabPage;
                tpGuide.Text = "Guide/Edit";
           
         
            }
        }

       
    }
}
