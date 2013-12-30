using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;

namespace ProcScribeOutlook
{
    public partial class frmOptions : Form
    {
        public frmOptions()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            DialogResult result = ofFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                txtPath.Text = ofFileDialog.FileName;
            }
        }

        private void frmOptions_Load(object sender, EventArgs e)
        {
            RegistryKey readReg;
            readReg = Registry.CurrentUser.OpenSubKey(globalOutlook.registryPath, true);
            txtPath.Text = readReg.GetValue("PROSCRIBEPATH", -1, RegistryValueOptions.None).ToString();

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            RegistryKey readReg;
            readReg = Registry.CurrentUser.OpenSubKey(globalOutlook.registryPath, true);
            readReg.SetValue("PROSCRIBEPATH", txtPath.Text);
        }
    }
}
