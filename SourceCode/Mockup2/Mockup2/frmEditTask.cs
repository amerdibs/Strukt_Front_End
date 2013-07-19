using System;
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
            List<Task> taskslist = new List<Task>();
            List<Task> taskslistAlter = new List<Task>();
            List<Task> taskslistRoll = new List<Task>();
            try
            {
                /* 
                 string work_flow_id = cbTask.SelectedValue.ToString();
                 Task _task[] = Task.getTaskByParentWorkflowID(work_flow_id);*/
                //cbTask.SelectedIndex = 1;
                propertiesFill(global.workflowMain, taskslist);
                taskslistAlter = taskslist.ToList();
                taskslistAlter.Reverse();
                taskslistRoll = taskslist.ToList();
                taskslistRoll.Reverse();
               
                
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
                taskslist.Reverse();
                lstPreCondition.DataSource = taskslist;
                lstPreCondition.ValueMember = "id";
                lstPreCondition.DisplayMember = "name";
                lstAlternative.DataSource = taskslistAlter;
                lstAlternative.ValueMember = "id";
                lstAlternative.DisplayMember = "name";
                lstRoleCondition.DataSource = propertie.roleList;
                lstRoleCondition.ValueMember = "id";
                lstRoleCondition.DisplayMember = "name";
                lstPreCondition.SelectedIndex = -1;
                lstResourceCondition.SelectedIndex = -1;
                lstRoleCondition.SelectedIndex = -1;
                lstAlternative.SelectedIndex = -1;
                
              
                //List<Task> tasklist;

                /*
                tasklist = Task.getTaskByParentWorkflowID(global.strWorkflowID);
                cbTask.DataSource = tasklist;
                cbTask.DisplayMember = "name";
                cbTask.ValueMember="id";
                DateTime date = new DateTime();
                DateTime deadline = new DateTime();
                foreach (Task _task in tasklist)
                {
                    if (_task.id ==(string)cbTask.SelectedValue)
                    {
                        date = Convert.ToDateTime(_task.date);
                        deadline = Convert.ToDateTime(_task.deadline);
                        dateTimePicker_Date.Value = date;
                        dateTimePicker_Deadline.Value = deadline;
                    }



                }

                */
   

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
            }
          
         
        }
        
        private void propertiesFill(Workflow wfparm,List<Task> taskList)
        {
            if ((wfparm == null) || (wfparm.taskChildList == null))
            {
                return;
            }
          
            foreach (Task tEach in wfparm.taskChildList)
            {
                propertiesFill(tEach.workflowChild, taskList);
                taskList.Add(tEach);

            }
           
        }  
         
        private void btnOK_Click(object sender, EventArgs e)
        {
            //try
            //{
                
            //    StruktWebservice.StruktUserSoapClient tdStrukt = new StruktWebservice.StruktUserSoapClient();
            //    tdStrukt.AddUptadeTaskDescription(global.getValueFromStruktValue(taskUse.id),txtDetail.Text);

            //}
            //catch (Exception)
            //{
                
            //    throw;
            //}
            
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

            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult dResult = MessageBox.Show("Do you want to cancel this action?", "Please confirm", MessageBoxButtons.OKCancel);
            if (dResult == DialogResult.OK)
                this.Close();
        }

        private void frmTaskEdit_Paint(object sender, PaintEventArgs e)
        {
            Rectangle rc = new Rectangle(0, 0, this.ClientSize.Width, this.ClientSize.Height);
            using (LinearGradientBrush brush = new LinearGradientBrush(rc, Color.WhiteSmoke, Color.Tan, LinearGradientMode.Vertical))
            {

                e.Graphics.FillRectangle(brush, rc);

            }
        }



      
    }
}
