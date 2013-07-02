using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
                cbLocation.SelectedValue = taskUse.location_id;
                cbStatus.SelectedValue = taskUse.status_id;
                cbTaskType.SelectedValue = taskUse.type_id;
                cbProject.SelectedValue = taskUse.project_id;
                dtpDate.Value = global.convertFromStruktDateTime(taskUse.date);
                dtpDeadline.Value = global.convertFromStruktDateTime(taskUse.deadline);
            }
          
         
        }
        
        private void propertiesFill(Workflow wfparm,List<Task> taskList)
        {
            if (wfparm == null)
            {
                return;
            }
          
            foreach (Task tEach in wfparm.taskList)
            {
                propertiesFill(tEach.workflowMember,taskList);
                taskList.Add(tEach);

            }
           
        }  
         
        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

      
    }
}
