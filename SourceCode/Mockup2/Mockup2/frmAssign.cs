﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

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

            StruktWebservice.StruktUserSoapClient wsStrukt = new StruktWebservice.StruktUserSoapClient();
            DataTable dtProcess = wsStrukt.getProcessByUserID(cbUser.SelectedValue.ToString());
            if (dtProcess == null)
            {
                MessageBox.Show("The process of this user us not exist","Please select the other user.");
            }
            List<Task> taskList = Task.getTaskByParentWorkflowID(dtProcess.Rows[0]["p_workflow_id"].ToString());
            //Now we can support only the user who has Task in process 
            taskList = Task.sortTaskList(taskList);
            Task taskFollow = taskList[0];
            

            //copy values from object to object
            JsonSerializerSettings jsSetting = new JsonSerializerSettings();
            jsSetting.NullValueHandling = NullValueHandling.Ignore;
            jsSetting.ReferenceLoopHandling = ReferenceLoopHandling.Ignore;
            string strObj = JsonConvert.SerializeObject(taskAssign, jsSetting);
            List<Task> taskTempList = JsonConvert.DeserializeObject<List<Task>>(strObj);
            Task taskNew = taskTempList[0];

            //Task taskNew = new Task();
            //Task taskFollow = global.workflowMain.taskChildList[0];
            
            taskNew.parent_workflow_id = taskFollow.parent_workflow_id;
            taskNew.follows_id = taskFollow.id;
            taskNew.user_id = taskFollow.user_id;
            taskNew.id = null;

            

            Task taskNewReturn = Task.addTask(taskNew);
            taskFollow.precedes_id = taskNewReturn.id;
            Task taskFollowReturn = Task.editTask(taskFollow);


            //create new child workflow for new task
            Workflow wfNew = Workflow.addWorkflow();
            wfNew.parent_task_id = taskNew.id;
            taskNew.child_workflow_id = wfNew.id;
            wfNew.user_id = global.workflowMain.user_id;

            Task returnTaskAdd = Task.addTask(taskNew);
            Workflow returnChildWorkflow = Workflow.editWorkflow(wfNew);
            returnTaskAdd.workflowChild = returnChildWorkflow;
            returnTaskAdd.workflowParent = global.workflowMain;

            global.workflowMain.taskChildList.Insert(0, returnTaskAdd);
            global.workflowMain.taskChildList[1].precedes_id = returnTaskAdd.id;
            Task returnTaskFollow = Task.editTask(global.workflowMain.taskChildList[1]);

        }
    }
}
