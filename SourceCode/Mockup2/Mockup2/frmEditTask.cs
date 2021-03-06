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

namespace Mockup2
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
            //List<Task> taskslist = new List<Task>();
            //List<Task> taskslistAlter = new List<Task>();
            //List<Task> taskslistRoll = new List<Task>();
            try
            {
                //global.getTaskListFromAllWorkflow(global.workflowMain, taskslist);
                //taskslistAlter = taskslist.ToList();
                //taskslistAlter.Reverse();
                //taskslistRoll = taskslist.ToList();
                //taskslistRoll.Reverse();


                //User's role control
                if (global.roleUser == User.roleExecutor)
                    txtTaskName.ReadOnly = true;
                
                PropertiesStrukt propertie = PropertiesStrukt.getPropertiesStruktAll();
                cbLocation.DataSource = propertie.locationList;
                cbLocation.ValueMember = "id";
                cbLocation.DisplayMember = "name";
                cbStatus.DataSource = propertie.statusList;
                cbStatus.ValueMember = "id";
                cbStatus.DisplayMember = "name";
                cbTaskType.DataSource = propertie.taskTypeList;
                cbTaskType.ValueMember = "id";
                cbTaskType.DisplayMember = "name";
                cbProject.DataSource = propertie.projectList;
                cbProject.ValueMember = "id";
                cbProject.DisplayMember = "name";
                //taskslist.Reverse();
                //lstPreCondition.DataSource = taskslist;
                //lstPreCondition.ValueMember = "id";
                //lstPreCondition.DisplayMember = "name";
                //lstAlternative.DataSource = taskslistAlter;
                //lstAlternative.ValueMember = "id";
                //lstAlternative.DisplayMember = "name";
                //lstRoleCondition.DataSource = propertie.roleList;
                //lstRoleCondition.ValueMember = "id";
                //lstRoleCondition.DisplayMember = "name";
                //lstPreCondition.SelectedIndex = -1;
                //lstResourceCondition.SelectedIndex = -1;
                //lstRoleCondition.SelectedIndex = -1;
                //lstAlternative.SelectedIndex = -1;
   
            }
            catch (Exception)
            {

                throw;
            }

          
            if (strFormMode == formModeNew) // NEW Mode
            {
                txtTaskName.Text = taskUse.name;
                dtpDate.Value = DateTime.Now;
                dtpDeadline.Value = DateTime.Now;
            }
            else // EDIT Mode
            {
                txtTaskName.Text = taskUse.name;
                if (taskUse.location_id != null)
                    cbLocation.SelectedValue = taskUse.location_id;
                if (taskUse.status_id != null)
                    cbStatus.SelectedValue = taskUse.status_id;
                if (taskUse.type_id != null)
                    cbTaskType.SelectedValue = taskUse.type_id;
                if (taskUse.project_id != null)
                    cbProject.SelectedValue = taskUse.project_id;
                if (taskUse.date != null)
                    dtpDate.Value = global.convertFromStruktDateTime(taskUse.date);
                if (taskUse.deadline != null)
                    dtpDeadline.Value = global.convertFromStruktDateTime(taskUse.deadline);
                if (taskUse.description != null)
                    txtDetail.Text = taskUse.description;
                if (taskUse.attachmentDetail != null)
                    txtAddress.Text = taskUse.attachmentDetail;
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
            taskUse.name = txtTaskName.Text;
            if (cbLocation.SelectedValue != null)
                taskUse.location_id = (string)cbLocation.SelectedValue;
            if (cbStatus.SelectedValue!= null)
                taskUse.status_id = (string)cbStatus.SelectedValue;
            if (cbTaskType.SelectedValue != null)
                taskUse.type_id = (string)cbTaskType.SelectedValue;
            if (cbProject.SelectedValue != null)
                taskUse.project_id = (string)cbProject.SelectedValue;
            if (dtpDate.Value != null)
                taskUse.date = global.convertStruktDateTimeToString(dtpDate.Value);
            if (dtpDeadline.Value != null)
                taskUse.deadline = global.convertStruktDateTimeToString(dtpDeadline.Value);

            if (!rbNone.Checked && txtAddress.Text.Trim() == "")
            {
                DialogResult = DialogResult.None;
                MessageBox.Show("Please input address in tool textbox or please select tool to None.");
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
  
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult dResult = MessageBox.Show("Do you want to cancel this action?", "Please confirm", MessageBoxButtons.OKCancel);
            if (dResult == DialogResult.Cancel)
                this.DialogResult = DialogResult.None;
        }

        private void frmTaskEdit_Paint(object sender, PaintEventArgs e)
        {
            Rectangle rc = new Rectangle(0, 0, this.ClientSize.Width, this.ClientSize.Height);
            using (LinearGradientBrush brush = new LinearGradientBrush(rc, Color.WhiteSmoke, Color.Tan, LinearGradientMode.Vertical))
            {

                e.Graphics.FillRectangle(brush, rc);

            }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {

            if (rbNone.Checked)
                return;
            else
                if (rbLink.Checked)
                    MessageBox.Show("Please input web address in textbox.");
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
                            DialogResult result = ofFileDialog.ShowDialog();
                            if (result == DialogResult.OK) 
                            {
                                txtAddress.Text = ofFileDialog.FileName;
                            }

                        }
 
        }

        private void rbNone_Click(object sender, EventArgs e)
        {
            txtAddress.Text = "";
            txtAddress.Enabled = false;
            txtAddress.ReadOnly = true;
        }

        private void rbLink_Click(object sender, EventArgs e)
        {
            txtAddress.Text = "";
            txtAddress.Enabled = true;
            txtAddress.ReadOnly = false;
        }

        private void rbApp_Click(object sender, EventArgs e)
        {
            txtAddress.Text = "";
            txtAddress.Enabled = true;
            txtAddress.ReadOnly = true;
        }

        private void rbFile_Click(object sender, EventArgs e)
        {
            txtAddress.Text = "";
            txtAddress.Enabled = true;
            txtAddress.ReadOnly = true;
        }



      
    }
}
