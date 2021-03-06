﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using Newtonsoft.Json;

namespace ProcScribe
{
    public partial class frmTaskEdit : Form
    {
        public string strFormMode { get; set; }
        public Task taskUse { get; set; }
        public string formModeEdit = "EDIT";
        public string formModeNew = "NEW";
        
        


        public frmTaskEdit()
        {
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {


        }

        private void frmTaskEdit_Load(object sender, EventArgs e)
        {
            try
            {
                txtLinkDesc.MaxLength = global.linkDescWidth;
                //User's role control
                if (global.roleUser == User.roleExecutor)
                    txtTaskName.ReadOnly = true;
   
            }
            catch (Exception ex)
            {
                global.getExceptionThrow(ex);
                throw ex;
            }

          
            if (strFormMode == formModeNew) // NEW Mode
            {
                txtTaskName.Text = taskUse.name;

            }
            else // EDIT Mode
            {
                txtTaskName.Text = taskUse.name;
                if (taskUse.description != null)
                    txtDetail.Text = taskUse.description.Replace("\n", Environment.NewLine);
                if (taskUse.attachmentDetail != null)
                    txtAddress.Text = taskUse.attachmentDetail;
                if (taskUse.keyword != null)
                    txtKeyword.Text = taskUse.keyword;
                if (taskUse.linkDetail != null)
                    txtLinkDesc.Text = taskUse.linkDetail;
                if (taskUse.attachmentType != null)
                {
                    if (taskUse.attachmentType == "NONE")
                    {
                        rbNone.Checked = true;
                        txtAddress.Enabled = false;
                        txtAddress.ReadOnly = true;
                    }
                    else
                        if (taskUse.attachmentType == "LINK")
                        {
                            rbLink.Checked = true;
                            txtAddress.Enabled = true;
                            txtAddress.ReadOnly = false;
                        }
                        else
                            if (taskUse.attachmentType == "APP")
                            {
                                rbApp.Checked = true;
                                txtAddress.Enabled = false;
                                txtAddress.ReadOnly = true;
                            }
                            else
                                if (taskUse.attachmentType == "FILE")
                                {
                                    rbFile.Checked = true;
                                    txtAddress.Enabled = true;
                                    txtAddress.ReadOnly = true;
                                }
                }
                   
            }
          
         
        }
        
  
         
        private void btnOK_Click(object sender, EventArgs e)
        {
            if (txtTaskName.Text.Trim() == "")
            {
                DialogResult = DialogResult.None;
                MessageBox.Show("Please input task name!", "Error Message");
                return;
            }
            
            taskUse.name = txtTaskName.Text;

            if (!rbNone.Checked && txtAddress.Text.Trim() == "")
            {
                DialogResult = DialogResult.None;
                MessageBox.Show("Tool not chosen! Please select an appropriate tool!", "Error Message");
                return;
            }

            string strType = "";
            if (rbNone.Checked)
                strType = "NONE";
            else
            if (rbLink.Checked)
                strType = "LINK";
            else
            if (rbApp.Checked)
                strType = "APP";
            else
            if (rbFile.Checked)
                strType = "FILE";

            taskUse.description = txtDetail.Text;
            taskUse.attachmentDetail = txtAddress.Text;
            taskUse.attachmentType = strType;
            taskUse.keyword = txtKeyword.Text;
            taskUse.linkDetail = txtLinkDesc.Text;
            
  
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult dResult = MessageBox.Show("Do you really want to cancel this action?", "Cancel Message", MessageBoxButtons.OKCancel);
            if (dResult == DialogResult.Cancel)
                this.DialogResult = DialogResult.None;
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {

            if (rbNone.Checked)
                return;
            else
                if (rbLink.Checked)
                    return;
                else
                    if (rbApp.Checked)
                    {
                        frmSelectApplication frmSelect = new frmSelectApplication();
                        DialogResult diaSelect = frmSelect.ShowDialog();
                        if (diaSelect == DialogResult.OK)
                        {
                            txtAddress.Text = frmSelect.strSelect;
                        }
                    }
                    else
                        if (rbFile.Checked)
                        {
                            frmUploadFile frmUpload = new frmUploadFile(this);
                            DialogResult diaUpload = frmUpload.ShowDialog();
                            if (diaUpload == DialogResult.OK)
                            {
                                txtAddress.Text = frmUpload.strSelect;
                            }

                        }
 
        }

        private void rbNone_Click(object sender, EventArgs e)
        {
            txtAddress.Text = "";
            btnBrowse.Text = "Browse";
            txtAddress.Enabled = false;
            txtAddress.ReadOnly = true;
        }

        private void rbLink_Click(object sender, EventArgs e)
        {
            txtAddress.Text = "";
            btnBrowse.Text = "Browse";
            txtAddress.Enabled = true;
            txtAddress.ReadOnly = false;
        }

        private void rbApp_Click(object sender, EventArgs e)
        {
            txtAddress.Text = "";
            btnBrowse.Text = "Browse";
            txtAddress.Enabled = true;
            txtAddress.ReadOnly = true;
        }

        private void rbFile_Click(object sender, EventArgs e)
        {
            txtAddress.Text = "";
            btnBrowse.Text = "Open";
            txtAddress.Enabled = true;
            txtAddress.ReadOnly = true;
        }
 
    }
}
