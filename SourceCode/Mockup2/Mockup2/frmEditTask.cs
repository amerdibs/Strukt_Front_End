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
                

               /* 
                string work_flow_id = cbTask.SelectedValue.ToString();
                Task _task[] = Task.getTaskByParentWorkflowID(work_flow_id);*/
                cbTask.SelectedIndex = 1;
                Properties_Strukt propertie = Properties_Strukt.getProperties_StruktAll();
                cbLocation.DataSource = propertie.locationList;
                cbLocation.ValueMember = "id";
                cbLocation.DisplayMember = "name";
                cbStatus.DataSource = propertie.statusList;
                cbStatus.ValueMember = "id";
                cbStatus.DisplayMember = "name";
                cbTaskType.DataSource = propertie.taskTypeList;
                cbTaskType.ValueMember="id";
                cbTaskType.DisplayMember = "name";
                cbProject.DataSource = propertie.projectList;
                cbProject.ValueMember = "id";
                cbProject.DisplayMember = "name";
                List<Task> tasklist;
                tasklist = Task.getTaskByParentWorkflowID(global.strWorkflowID);
                cbTask.DataSource = tasklist;
                cbTask.DisplayMember = "name";
                cbTask.ValueMember="id";
                try
                {
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
                }
                catch (Exception)
                {
                    
                    throw;
                }
               
               
             
               
                
             //   dateTimePicker_Date.DataBindings=tas

               

               
            //for (int i = 0; i <propertie.locationList.Count; i++)
			//{
            //    CBX_Location.Items.Add(propertie.locationList[i].name);
			//}
           
            
                       
             //CBX_Location.DataSource = propertie.locationList;
       
            
		
	}
	catch (Exception)
	{
		
		throw;
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
