using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Drawing.Drawing2D;

namespace ProcScribe
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
            DialogResult result1 = MessageBox.Show("Do you really want to cancel the task assignment?",
                                       "Cancel Task Assignment",
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
                MessageBox.Show("This process is not allocated to the current user! \n Please select another!","Error Message");
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
            Task taskNew = JsonConvert.DeserializeObject<Task>(strObj);
            //Task taskNew = taskTempList[0];

            //Task taskNew = new Task();
            //Task taskFollow = global.workflowMain.taskChildList[0];
            
            taskNew.parent_workflow_id = taskFollow.parent_workflow_id;
            taskNew.follows_id = taskFollow.id;
            taskNew.user_id = taskFollow.user_id;
            taskNew.precedes_id = null;
            taskNew.id = null;

            Task taskNewReturn = Task.addTask(taskNew);
            taskFollow.precedes_id = taskNewReturn.id;
            Task taskFollowReturn = Task.editTask(taskFollow);

            Workflow wfNew = Workflow.addWorkflow();
            wfNew.parent_task_id = taskNewReturn.id;
            taskNewReturn.child_workflow_id = wfNew.id;
            wfNew.user_id = global.workflowMain.user_id;

            Workflow returnChildWorkflow = Workflow.editWorkflow(wfNew);
            Task returnTaskAdd = Task.editTask(taskNewReturn);

            Assignment assignNew = new Assignment();
            assignNew.acknowledged = "false";
            assignNew.date = global.convertStruktDateTimeToString(DateTime.Now);
            assignNew.message = txtMsg.Text;
            assignNew.source_task_id = taskAssign.id;
            assignNew.source_user_id = taskAssign.user_id;
            assignNew.target_task_id = returnTaskAdd.id;
            assignNew.target_user_id = returnTaskAdd.user_id;


            Assignment asReturn = Assignment.addAssignment(assignNew);
            if (global.assignmentSentList == null)
            {
                global.assignmentSentList = new List<Assignment>();
            }
            global.assignmentSentList.Add(asReturn);

            StruktWebservice.StruktUserSoapClient struktWS = new StruktWebservice.StruktUserSoapClient();
            struktWS.setUpdateTaskExtend(global.getValueFromStruktValue(returnTaskAdd.id), taskAssign.description, taskAssign.attachmentType, taskAssign.attachmentDetail, taskAssign.keyword);

            MessageBox.Show("Assign Complete");
            //returnTaskAdd.workflowChild = returnChildWorkflow;
            //returnTaskAdd.workflowParent = global.workflowMain;

            //global.workflowMain.taskChildList.Insert(0, returnTaskAdd);
            //global.workflowMain.taskChildList[1].precedes_id = returnTaskAdd.id;
            //Task returnTaskFollow = Task.editTask(global.workflowMain.taskChildList[1]);

        }

        private void frmAssign_Paint(object sender, PaintEventArgs e)
        {
            Rectangle rc = new Rectangle(0, 0, this.ClientSize.Width, this.ClientSize.Height);
            using (LinearGradientBrush brush = new LinearGradientBrush(rc, Color.WhiteSmoke, Color.PeachPuff, LinearGradientMode.Vertical))
            {

                e.Graphics.FillRectangle(brush, rc);

            }

        }
    }
}
