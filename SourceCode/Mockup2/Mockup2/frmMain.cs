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
    public partial class frmMain : Form
    {

        public frmMain()
        {
            InitializeComponent();
            //this.BackColor = global.ColorSubTask;
         
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            cbProcess.DataSource = global.processTable;
            cbProcess.ValueMember = "p_workflow_id";
            cbProcess.DisplayMember = "p_name";

            StruktWebservice.StruktUserSoapClient wsStrukt = new StruktWebservice.StruktUserSoapClient();
            global.userTable = wsStrukt.getUserAll();

            if (global.processTable.Columns.Contains("u_name"))
            {
                this.Text = global.processTable.Rows[0]["u_name"].ToString() + " >> Welcome to Guidance";
                tsUserName.Text = "User: " + global.processTable.Rows[0]["u_name"].ToString();

                //Assignment Checking
                bool bResult = Assignment.checkGetAssignmentByUserID(global.processTable.Rows[0]["u_strukt_user_id"].ToString());
                if (bResult)
                {
                    //We are interested only the assignments which we received for acknowledgement
                    foreach (Assignment asEach in global.assignmentReceivedList)
                    {
                        if (asEach.acknowledged == "false")
                        {
                            frmAcknowledge fAck = new frmAcknowledge();
                            Task tGet = Task.getTaskByID(global.getValueFromStruktValue(asEach.source_task_id))[0];
                            if (tGet != null)
                            {
                                DataTable dtUser = wsStrukt.getUserByStruktID(global.getValueFromStruktValue(tGet.user_id));
                                if (dtUser != null)
                                {
                                    fAck.Controls["txtUser"].Text = dtUser.Rows[0]["u_name"].ToString();
                                }
                                else
                                {
                                    fAck.Controls["txtUser"].Text = "not exists in Log-In: " + global.getValueFromStruktValue(tGet.user_id);
                                }
                            }

                            fAck.Controls["txtMsg"].Text = asEach.message;

                            DialogResult dResult = fAck.ShowDialog();
                            if (dResult == DialogResult.OK) //Update acknowledgement
                            {
                                Assignment asAckResult = Assignment.updateAssignmentAcknowledge(asEach);
                                if (asAckResult != null)
                                    asEach.acknowledged = "true";
                                else
                                {
                                    MessageBox.Show("Update assignment error");
                                    throw new System.Exception("Update assignment error");
                                }
                            }
                        }
                    }
                }

                btnLoadProcess_Click(sender, e);

            }
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult result1 = MessageBox.Show("Do you want to exit?",
        "Please confirm",
        MessageBoxButtons.OKCancel);
            if (result1 == System.Windows.Forms.DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result1 = MessageBox.Show("Do you want to exit?",
                                                    "Please confirm",
                                                    MessageBoxButtons.OKCancel);
            if (result1 != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
            
        }


        private void btnSubAdd_Click(object sender, EventArgs e)
        {
            if (pnCenter.Controls.Count == 0)
            {
                MessageBox.Show("Please add a task before.");
                return;
            }

            if ((global.workflowMain == null) || (global.workflowMain.taskChildList.Count == 0))
            {
                MessageBox.Show("Please load process before.");
                return;
            }
            else
                if (global.currentTaskControlID == 0)
                {
                    MessageBox.Show("Please select a task before.");
                    return;
                }
                else
                {
                    //2. Add new when select a Task 
                    //    2.1 get task from selected control and create new Task object
                    //    2.2 set parent_workflow_id use selected_task.childworkflow_id, user_id
                    //    2.3 get values from edit form
                    //       (If there are child tasks, new task must be added follow in the last task in this workflow)
                    //    2.4 save the new task
                    //        - post to create new child workflow and get object to update task object
                    //        2.4.1 save in Strukt first
                    //        - update child workflow
                    //        2.4.2 save in Object Structure
                    //    2.6 create new control and put in main panel

                    Object uControl = global.currentTaskControlObject;
                    UCMainTask uSelect = (UCMainTask)uControl;
                    Task taskParent = uSelect.taskMember;
                    Task taskNew = new Task();
                    taskNew.parent_workflow_id = taskParent.child_workflow_id;
                    taskNew.user_id = global.workflowMain.user_id;
                    taskNew.name = "New Task";

                    frmTaskEdit frmEdit = new frmTaskEdit();
                    frmEdit.strFormMode = frmEdit.formModeNew;
                    frmEdit.taskUse = taskNew;
                    DialogResult dResult = frmEdit.ShowDialog();
                    if (dResult != DialogResult.OK)
                    {
                        return;
                    }
                    Workflow wfNew = Workflow.addWorkflow();
                    wfNew.parent_task_id = taskNew.id;
                    taskNew.child_workflow_id = wfNew.id;
                    wfNew.user_id = global.workflowMain.user_id;

                    Task returnTaskAdd;
                    if ((uSelect.taskMember.workflowChild.taskChildList != null) && (uSelect.taskMember.workflowChild.taskChildList.Count > 0))
                    {
                        returnTaskAdd = Task.addTask(taskNew);
                        Task taskFollow = taskParent.workflowChild.taskChildList[0];
                        returnTaskAdd.follows_id = taskFollow.id;
                        taskFollow.precedes_id = returnTaskAdd.id;
                        Task taskReturn = Task.editTask(taskFollow);
                        returnTaskAdd = Task.editTask(returnTaskAdd);
                    }
                    else
                    {
                        returnTaskAdd = Task.addTask(taskNew);
                    }


                    Workflow returnChildWorkflow = Workflow.editWorkflow(wfNew);
                    returnTaskAdd.workflowChild = returnChildWorkflow;
                    returnTaskAdd.workflowParent = taskParent.workflowChild;



                    //Add Task and config UI
                    UCMainTask uMain = new UCMainTask();
                    uMain.Height = global.heightControlTaskNormal;
                    pnCenter.Controls.Add(uMain);
                    uMain.Dock = DockStyle.Top;
                    int iIndex = 0;
                    if ((uSelect.taskMember.workflowChild.taskChildList != null) && (uSelect.taskMember.workflowChild.taskChildList.Count > 0))
                    {
                        Task taskFollow = taskParent.workflowChild.taskChildList[0];
                        taskParent.workflowChild.taskChildList.Insert(0, returnTaskAdd);
                        foreach (UCMainTask ucmEach in pnCenter.Controls)
                        {
                            if (ucmEach.taskMember.id == taskFollow.id)
                            {
                                iIndex = pnCenter.Controls.GetChildIndex(ucmEach, true);
                                break;
                            }
                        }
                    }
                    else
                    {
                        iIndex = pnCenter.Controls.GetChildIndex(uSelect, true);
                        taskParent.workflowChild.taskChildList = new List<Task>();
                        taskParent.workflowChild.taskChildList.Add(returnTaskAdd);
                    }

                    pnCenter.Controls.SetChildIndex(uMain, iIndex);



                    uMain.taskMember = returnTaskAdd;
                    uMain.Controls["lbTitle"].Text = returnTaskAdd.name;

                    uMain.iLevel = uSelect.iLevel + 1;
                    uMain.BackColor = global.ColorMainTask;
                    uMain.Controls["cbCheck"].Left = uSelect.Controls["cbCheck"].Left + global.iIndentOfCheckBox;
                    uMain.Controls["lbTitle"].Left = uSelect.Controls["lbTitle"].Left + global.iIndentOfCheckBox;
                    uMain.BackColor = global.getColorTaskControlBackground(uMain.BackColor, uMain.iLevel);
                    uMain.colorBackGround = uMain.BackColor;
                  

                    uMain.MouseDown += new MouseEventHandler(EventHandlerFromMainTask_MouseDown);
                    uMain.DragDrop += new DragEventHandler(EventHandlerFromMainTask_DragDrop);

                }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            if ((global.workflowMain == null) || (global.workflowMain.taskChildList.Count == 0))
            {
                MessageBox.Show("Please load process before.\n We still don't implement this step right now.");
                return;
            }
            else
            if (global.currentTaskControlID == 0) 
            {
                //1. Add new when not select any Task
                //    1.1 get last Task from workflowMain and create new Task object
                //    1.2 set parent_workflow_id use main parent_workflow_id.id
                //    1.3 set follow_id,user_id from last task
                //    1.4 get values from edit form
                //    1.5 save the new task
                //        1.5.1 post to Strukt to create new child workflow and get object to update task object
                //        1.5.2 save in Strukt first
                //        1.5.3 update child workflow
                //        1.5.4 save in Object Structure
                //    1.6 update follow task
                //        1.6.1 set precedes_id to new task.id
                //    1.7 create new control and put in main panel
                
                Task taskNew = new Task();
                Task taskFollow = global.workflowMain.taskChildList[0];
                taskNew.parent_workflow_id = taskFollow.parent_workflow_id;
                taskNew.follows_id = global.workflowMain.taskChildList[0].id;
                taskNew.user_id = global.workflowMain.user_id;
                taskNew.name = "New Task";
                frmTaskEdit frmEdit = new frmTaskEdit();
                frmEdit.strFormMode = frmEdit.formModeNew;
                frmEdit.taskUse = taskNew;
                DialogResult dResult = frmEdit.ShowDialog();
                if (dResult != DialogResult.OK)
                {
                    return;
                }

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

                //Add Task and config UI
                UCMainTask uMain = new UCMainTask();
                uMain.Height = global.heightControlTaskNormal;
                pnCenter.Controls.Add(uMain);
                uMain.Dock = DockStyle.Top;
                uMain.BringToFront();
                uMain.taskMember = returnTaskAdd;
                uMain.Controls["lbTitle"].Text = returnTaskAdd.name;
                uMain.iLevel = 0;

                uMain.BackColor = global.ColorMainTask;
                uMain.colorBackGround = uMain.BackColor;

                uMain.MouseDown += new MouseEventHandler(EventHandlerFromMainTask_MouseDown);
                uMain.DragDrop += new DragEventHandler(EventHandlerFromMainTask_DragDrop);

            }
            else
            {
                //2. Add new when select a Task
                //    2.1 get task from selected control and create new Task object
                //        2.1.1 get task from under the selected control too 
                //    2.2 set parent_workflow_id use selected task parent_workflow_id.id
                //    2.3 set follow_id,user_id from selected task
                //          2.3.1 set precedes_id from task under the selected task
                //    2.4 get values from edit form
                //    2.5 save the new task
                //        2.5.1 post to Strukt to create new child workflow and get object to update task object
                //        2.5.2 save in Strukt first
                //        2.5.3 update child workflow
                //        2.5.4 save in Object Structure
                //    2.6 update follow task
                //        2.6.1 set precedes_id to new task.id
                //    2.7 update the task under follow task
                //        2.7.1 set follow_id to new task.id
                //    2.8 create new control and put in main panel

                Object uControl = global.currentTaskControlObject;
                UCMainTask uSelect = (UCMainTask)uControl;
                Task taskFollow = uSelect.taskMember;
                Task taskUnderFollow = null;
                if (taskFollow.workflowParent.taskChildList.IndexOf(taskFollow) - 1 >= 0)
                {
                    taskUnderFollow = taskFollow.workflowParent.taskChildList[taskFollow.workflowParent.taskChildList.IndexOf(taskFollow) - 1];
                }
                Task taskNew = new Task();
                taskNew.parent_workflow_id = taskFollow.parent_workflow_id;
                taskNew.follows_id = taskFollow.id;
                taskNew.user_id = global.workflowMain.user_id;
                taskNew.name = "New Task";
                if (taskUnderFollow != null)
                {
                    taskNew.precedes_id = taskUnderFollow.id;
                }
                frmTaskEdit frmEdit = new frmTaskEdit();
                frmEdit.strFormMode = frmEdit.formModeNew;
                frmEdit.taskUse = taskNew;
                DialogResult dResult = frmEdit.ShowDialog();
                if (dResult != DialogResult.OK)
                {
                    return;
                }
                Workflow wfNew = Workflow.addWorkflow();
                wfNew.parent_task_id = taskNew.id;
                taskNew.child_workflow_id = wfNew.id;
                wfNew.user_id = global.workflowMain.user_id;

                Task returnTaskAdd = Task.addTask(taskNew);
                Workflow returnChildWorkflow = Workflow.editWorkflow(wfNew);
                returnTaskAdd.workflowChild = returnChildWorkflow;
                returnTaskAdd.workflowParent = taskFollow.workflowParent;

                taskFollow.workflowParent.taskChildList.Insert(taskFollow.workflowParent.taskChildList.IndexOf(taskFollow)
                                                                , returnTaskAdd);
                taskFollow.precedes_id = returnTaskAdd.id;
                Task returnTaskFollow = Task.editTask(taskFollow);

                if (taskUnderFollow != null)
                {
                    taskUnderFollow.follows_id = returnTaskAdd.id;
                    Task returnTaskUnderFollow = Task.editTask(taskUnderFollow);
                }

                //Add Task and config UI
                UCMainTask uMain = new UCMainTask();
                uMain.Height = global.heightControlTaskNormal;
                pnCenter.Controls.Add(uMain);
                uMain.Dock = DockStyle.Top;
                Task taskDeepestChild = Task.getDeepestChild(uSelect.taskMember);
                if (taskDeepestChild == uSelect.taskMember)
                {
                    int iIndex = pnCenter.Controls.GetChildIndex(uSelect, true);
                    pnCenter.Controls.SetChildIndex(uMain, iIndex);
                }
                else
                {
                    foreach (UCMainTask ucmEach in pnCenter.Controls)
                    {
                        if (ucmEach.taskMember.id == taskDeepestChild.id)
                        {
                            int iIndex = pnCenter.Controls.GetChildIndex(ucmEach, true);
                            pnCenter.Controls.SetChildIndex(uMain, iIndex);
                            break;
                        }
                    }
                }

                uMain.taskMember = returnTaskAdd;
                uMain.Controls["lbTitle"].Text = returnTaskAdd.name;

                uMain.BackColor = global.ColorMainTask;
                uMain.Controls["cbCheck"].Left = uSelect.Controls["cbCheck"].Left;
                uMain.Controls["lbTitle"].Left = uSelect.Controls["lbTitle"].Left;
                uMain.BackColor = global.getColorTaskControlBackground(uMain.BackColor, uSelect.iLevel);
                uMain.colorBackGround = uMain.BackColor;
                uMain.iLevel = uSelect.iLevel;

                uMain.MouseDown += new MouseEventHandler(EventHandlerFromMainTask_MouseDown);
                uMain.DragDrop += new DragEventHandler(EventHandlerFromMainTask_DragDrop);
            }


        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (pnCenter.Controls.Count == 0)
            {
                MessageBox.Show("There are no any tasks.");
                return;
            }

            if (global.currentTaskControlID == 0)
            {
                MessageBox.Show("Please select a task to delete.");
                return;
            }

            DialogResult result1 = MessageBox.Show("Do you want to delete this task?",
                                        "Please confirm",
                                        MessageBoxButtons.OKCancel);
            if (result1 == System.Windows.Forms.DialogResult.OK)
            {
                UCMainTask uSelect = (UCMainTask)global.currentTaskControlObject;
                //1. We cannot delete the task which has child tasks under.
                //  check number of child tasks in its child workflow
                if ((uSelect.taskMember.workflowChild.taskChildList != null) && (uSelect.taskMember.workflowChild.taskChildList.Count > 0))
                {
                    MessageBox.Show("Please delete child tasks of this task before.");
                    return;
                }

                //If task in the only one task in workflow
                //delete select task, delete its child workflow
                //update into Strukt
                if ((uSelect.taskMember.follows_id == null) && (uSelect.taskMember.precedes_id == null))
                {
                    string strResult;
                    strResult = Workflow.deleteWorkflow(global.getValueFromStruktValue(uSelect.taskMember.workflowChild.id));
                    if (strResult != global.resultSuccessStrukt)
                    {
                        MessageBox.Show("There is error. Workflow cannot be deleted.");
                        return;
                    }
                    strResult = Task.deleteTask(global.getValueFromStruktValue(uSelect.taskMember.id));
                    if (strResult != global.resultSuccessStrukt)
                    {
                        MessageBox.Show("There is error. Task cannot be deleted.");
                        return;
                    }
                    Workflow wfPre = uSelect.taskMember.workflowParent;
                    wfPre.taskChildList.Remove(uSelect.taskMember);
                    uSelect.taskMember.workflowChild = null;
                    uSelect.taskMember = null;
                    pnCenter.Controls.Remove(uSelect);
                }
                //If task is at the first position of workflow
                //get the followed task
                //update followed task.follow_id = null
                //delete select task, delete its child workflow
                //update into Strukt
                else if (uSelect.taskMember.follows_id == null)
                {
                    Task taskFollow = uSelect.taskMember.workflowParent.taskChildList[uSelect.taskMember.workflowParent.taskChildList.IndexOf(uSelect.taskMember) - 1];
                    taskFollow.follows_id = null;

                    Task taskResult = Task.editTask(taskFollow);
                    string strResult;
                    strResult = Task.deleteTask(global.getValueFromStruktValue(uSelect.taskMember.id));
                    if (strResult != global.resultSuccessStrukt)
                    {
                        MessageBox.Show("There is error. Task cannot be deleted.");
                        return;
                    }
                    strResult = Workflow.deleteWorkflow(global.getValueFromStruktValue(uSelect.taskMember.workflowChild.id));
                    if (strResult != global.resultSuccessStrukt)
                    {
                        MessageBox.Show("There is error. Workflow cannot be deleted.");
                        return;
                    }
                    Workflow wfPre = uSelect.taskMember.workflowParent;
                    wfPre.taskChildList.Remove(uSelect.taskMember);
                    uSelect.taskMember.workflowChild = null;
                    uSelect.taskMember = null;
                    pnCenter.Controls.Remove(uSelect);

                }
                //If task is at the last position of workflow
                //get the precedes task
                //update precedes task.precedes id = null
                //delete select task, delete its child workflow
                //update into Strukt
                else if (uSelect.taskMember.precedes_id == null)
                {
                    Task taskPrecedes = uSelect.taskMember.workflowParent.taskChildList[uSelect.taskMember.workflowParent.taskChildList.IndexOf(uSelect.taskMember) + 1];
                    taskPrecedes.precedes_id = null;

                    Task taskResult = Task.editTask(taskPrecedes);
                    string strResult;
                    strResult = Task.deleteTask(global.getValueFromStruktValue(uSelect.taskMember.id));
                    if (strResult != global.resultSuccessStrukt)
                    {
                        MessageBox.Show("There is error. Task cannot be deleted.");
                        return;
                    }
                    strResult = Workflow.deleteWorkflow(global.getValueFromStruktValue(uSelect.taskMember.workflowChild.id));
                    if (strResult != global.resultSuccessStrukt)
                    {
                        MessageBox.Show("There is error. Workflow cannot be deleted.");
                        return;
                    }
                    Workflow wfPre = uSelect.taskMember.workflowParent;
                    wfPre.taskChildList.Remove(uSelect.taskMember);
                    uSelect.taskMember.workflowChild = null;
                    uSelect.taskMember = null;
                    pnCenter.Controls.Remove(uSelect);

                }
                //If task is in between 2 tasks
                //get the followed task
                //get the precedes task
                //update followed task.follow_id = precedes task.id
                //update precedes task.precedes id = followed task.id
                //delete select task, delete its child workflow
                //update into Strukt
                else
                {
                    Task taskPrecedes = uSelect.taskMember.workflowParent.taskChildList[uSelect.taskMember.workflowParent.taskChildList.IndexOf(uSelect.taskMember) + 1];
                    Task taskFollow = uSelect.taskMember.workflowParent.taskChildList[uSelect.taskMember.workflowParent.taskChildList.IndexOf(uSelect.taskMember) - 1];
                    taskPrecedes.precedes_id = taskFollow.id;
                    taskFollow.follows_id = taskPrecedes.id;


                    Task taskPResult = Task.editTask(taskPrecedes);
                    Task taskFResult = Task.editTask(taskFollow);
                    string strResult;
                    strResult = Task.deleteTask(global.getValueFromStruktValue(uSelect.taskMember.id));
                    if (strResult != global.resultSuccessStrukt)
                    {
                        MessageBox.Show("There is error. Task cannot be deleted.");
                        return;
                    }
                    strResult = Workflow.deleteWorkflow(global.getValueFromStruktValue(uSelect.taskMember.workflowChild.id));
                    if (strResult != global.resultSuccessStrukt)
                    {
                        MessageBox.Show("There is error. Workflow cannot be deleted.");
                        return;
                    }

                    Workflow wfPre = uSelect.taskMember.workflowParent;
                    wfPre.taskChildList.Remove(uSelect.taskMember);
                    uSelect.taskMember.workflowChild = null;
                    uSelect.taskMember = null;
                    pnCenter.Controls.Remove(uSelect);
                }

                global.currentTaskControlObject = null;
                global.currentTaskControlID = 0;

            }







            /*
            if (pnCenter.Controls.Count == 0)
            {
                MessageBox.Show("There are no any tasks.");
                return;
            }

            if (global.currentTaskControlID == 0)
            {
                MessageBox.Show("Please select a task to delete.");
                return;
            }

            DialogResult result1 = MessageBox.Show("Do you want to delete this task?",
                                        "Please confirm",
                                        MessageBoxButtons.OKCancel);
            if (result1 == System.Windows.Forms.DialogResult.OK)
            {
                Object uControl = global.currentTaskControlObject;
                if (uControl.GetType() == typeof(UCMainTask))
                {
                    UCMainTask uSelect = (UCMainTask)uControl;
                    pnCenter.Controls.Remove(uSelect);
                }
                else if (uControl.GetType() == typeof(UCSubTask))
                {
                    UCSubTask uSelect = (UCSubTask)uControl;
                    pnCenter.Controls.Remove(uSelect);
                }
                
                global.currentTaskControlObject = null;
                global.currentTaskControlID = 0;
            }
             */
        }

        private void btnOption_Click(object sender, EventArgs e)
        {
            frmOption fOp = new frmOption();
            fOp.Show();
        }

        private void addMainTaskToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnAdd_Click(sender, e);
        }

        private void addSubTaskToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnSubAdd_Click(sender, e);
        }

        private void deleteTaskToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnDelete_Click(sender, e);
        }

        public void EventHandlerFromMainTask_MouseDown(object sender, MouseEventArgs e)
        {
            clearOtherSelectColor();

            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                ctmTask.Show(Cursor.Position);
            }
            
        }

        public void EventHandlerFromSubTask_MouseDown(object sender, MouseEventArgs e)
        {
            clearOtherSelectColor();

            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                ctmTask.Show(Cursor.Position);
            }
        }

        private void pnCenter_DragEnter(object sender, DragEventArgs e)
        {
            if ((e.AllowedEffect & DragDropEffects.Link) != 0 &&  e.Data.GetDataPresent(typeof(string)))
            {
                e.Effect = DragDropEffects.Link;
            }
        }

        private void pnCenter_DragDrop(object sender, DragEventArgs e)
        {
            
            //For test
            //MessageBox.Show((string)e.Data.GetData(typeof(string)));

            Object uControl = global.dragTaskControlObject;

            UCMainTask uSelect = (UCMainTask)uControl;
            pnCenter.Controls.SetChildIndex(uSelect,0);
   
            global.dragTaskControlObject = null;
            global.dragTaskControlID = 0;
            
        }

        private void EventHandlerFromMainTask_DragDrop(object sender, DragEventArgs e)
        {
            
            // --- Mouse clicked event
            clearOtherSelectColor();
            
            // --- Drag drop event
            Object uControl = global.dragTaskControlObject;
            Object receiveControl = global.dropTaskControlObject;

            UCMainTask UCMainReceive = (UCMainTask)receiveControl;
            int intReceive = pnCenter.Controls.GetChildIndex(UCMainReceive);
            UCMainTask uSelect = (UCMainTask)uControl;
            pnCenter.Controls.SetChildIndex(uSelect, intReceive);
            global.dragTaskControlObject = null;
            global.dragTaskControlID = 0;

            
        }

        private void EventHandlerFromSubTask_DragDrop(object sender, DragEventArgs e)
        {
            /*
            // --- Mouse clicked event
            clearOtherSelectColor();

            // --- Drag drop event
            Object uControl = global.dragTaskControlObject;
            Object receiveControl = global.dropTaskControlObject;

            UCSubTask UCSubReceive = (UCSubTask)receiveControl;
            int intReceive = pnCenter.Controls.GetChildIndex(UCSubReceive);

            if (uControl.GetType() == typeof(UCMainTask))
            {
                UCMainTask uSelect = (UCMainTask)uControl;
                pnCenter.Controls.SetChildIndex(uSelect, intReceive);
            }
            else if (uControl.GetType() == typeof(UCSubTask))
            {
                UCSubTask uSelect = (UCSubTask)uControl;
                pnCenter.Controls.SetChildIndex(uSelect, intReceive);
            }

            global.dragTaskControlObject = null;
            global.dragTaskControlID = 0;
            */
        }

        private void clearOtherSelectColor()
        {
            foreach (Object uClickControl in pnCenter.Controls)
            {
                if (uClickControl.GetHashCode() != global.currentTaskControlID)
                {
                    UCMainTask uMain = (UCMainTask)uClickControl;
                    uMain.BackColor = uMain.colorBackGround;
                }
            }
        }

        private void btnLoadProcess_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                Workflow wfMain = Workflow.getWorkflowHierarchybyID(cbProcess.SelectedValue.ToString());
                global.workflowMain = wfMain;
                pnCenter.Controls.Clear();
                generateTaskControl(wfMain, 0);
                if (global.getValueFromStruktValue(wfMain.id) == "2120706644")
                    MessageBox.Show("Please load the other process (Procument). Do not use this process to test! Please read only.");

            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }

        private void btnHide_Click(object sender, EventArgs e)
        {

            if (global.hideWindows == false)
            {
                frmMain.ActiveForm.Left = System.Windows.Forms.Screen.AllScreens[0].Bounds.Width - 33;
                btnHide.Image = ((System.Drawing.Image)(Properties.Resources.bt_skip_bk));
                global.hideWindows = true;
            }
            else
            {
                frmMain.ActiveForm.Left = System.Windows.Forms.Screen.AllScreens[0].Bounds.Width - 420;
                btnHide.Image = ((System.Drawing.Image)(Properties.Resources.bt_skip_sw));
                global.hideWindows = false;
            }
        }

        //Create hierachy of Task Controls
        private void generateTaskControl(Workflow wfParam, int iLevel)
        {
            if ((wfParam == null) || (wfParam.taskChildList == null))
            {
                return;
            }
            foreach (Task tEach in wfParam.taskChildList)
            {
                generateTaskControl(tEach.workflowChild, iLevel + 1);
                UCMainTask uMain = new UCMainTask();
                uMain.taskMember = tEach;
                uMain.Height = global.getHeightTaskControl(tEach);
                uMain.iLevel = iLevel;
                pnCenter.Controls.Add(uMain);
                uMain.Dock = DockStyle.Top;
                uMain.BackColor = global.ColorMainTask;
                uMain.Controls["lbTitle"].Text = tEach.name;
                uMain.Controls["cbCheck"].Left = uMain.Controls["cbCheck"].Left + (global.iIndentOfCheckBox * iLevel);
                uMain.Controls["lbTitle"].Left = uMain.Controls["lbTitle"].Left + (global.iIndentOfCheckBox * iLevel);
                if (tEach.hasAssignmentReceived)
                {
                    Panel pnRec = (Panel)uMain.Controls["pnReceived"];
                    pnRec.Visible = true;
                    pnRec.Controls["lReceive"].Left = pnRec.Controls["lReceive"].Left + (global.iIndentOfCheckBox * iLevel);
                    pnRec.Controls["txtReceive"].Left = pnRec.Controls["txtReceive"].Left + (global.iIndentOfCheckBox * iLevel);
                    pnRec.Controls["btnSendtoAssigner"].Left = pnRec.Controls["btnSendtoAssigner"].Left + (global.iIndentOfCheckBox * iLevel);
                    Assignment asReceived = global.assignmentReceivedList.Find(o => o.target_task_id == tEach.id);
                    DataRow dtRow = User.getUserNameByStruktID(global.getValueFromStruktValue(asReceived.source_user_id));
                    pnRec.Controls["txtReceive"].Text = dtRow["u_name"].ToString();
                    pnRec.Controls["txtReceive"].Tag = dtRow["u_strukt_user_id"].ToString();
                }
                if (tEach.hasAssignmentSent)
                {
                    Panel pnAs = (Panel)uMain.Controls["pnAssigned"];
                    pnAs.Visible = true;
                    pnAs.Controls["lAssign"].Left = pnAs.Controls["lAssign"].Left + (global.iIndentOfCheckBox * iLevel);
                    pnAs.Controls["lbAssigned"].Left = pnAs.Controls["lbAssigned"].Left + (global.iIndentOfCheckBox * iLevel);
                    pnAs.Controls["btnSendtoReceiver"].Left = pnAs.Controls["btnSendtoReceiver"].Left + (global.iIndentOfCheckBox * iLevel);

                    DataTable dtSelectUser = new DataTable();
                    dtSelectUser.TableName = "user";
                    //very bad performance but I'll correct in next step.
                    dtSelectUser = global.userTable.Copy();
                    dtSelectUser.Rows.Clear();
                    List<Assignment> asSentList = global.assignmentSentList.FindAll(o => o.source_task_id == tEach.id);
                    foreach (Assignment asEach in asSentList)
                    {
                        DataRow dtRow = User.getUserNameByStruktID(global.getValueFromStruktValue(asEach.target_user_id));
                        if (dtRow != null)
                        {
                            dtSelectUser.Rows.Add(dtRow.ItemArray);
                        }
                    }
                    ListBox lbAssigned = (ListBox)pnAs.Controls["lbAssigned"];
                    lbAssigned.DataSource = dtSelectUser;
                    lbAssigned.DisplayMember = "u_name";
                    lbAssigned.ValueMember = "u_strukt_user_id";

                    //List<Assignment> asSentList = global.assignmentSentList.FindAll(o => o.source_task_id == tEach.id);
                    //ListBox lbAssigned = (ListBox)pnAs.Controls["lbAssigned"];
                    //lbAssigned.DataSource = asSentList;
                    //lbAssigned.DisplayMember = "target_task_id";
                    //lbAssigned.ValueMember = "target_task_id";

                }
        
                if (uMain.taskMember.status_id == PropertiesStrukt.Status.statusCompleted)
                {
                    CheckBox cbSelect = (CheckBox)uMain.Controls["cbCheck"];            
                    cbSelect.Checked = true;
                }
                uMain.BackColor = global.getColorTaskControlBackground(uMain.BackColor, iLevel);
                uMain.colorBackGround = uMain.BackColor;
                uMain.MouseDown += new MouseEventHandler(EventHandlerFromMainTask_MouseDown);
                uMain.DragDrop += new DragEventHandler(EventHandlerFromMainTask_DragDrop);



                /*
                    Object uControl = global.currentTaskControlObject;
                    if (uControl.GetType() == typeof(UCMainTask))
                    {
                        UCMainTask uSelect = (UCMainTask)uControl;
                        int iIndex = pnCenter.Controls.GetChildIndex(uSelect, true);
                        pnCenter.Controls.SetChildIndex(uMain, iIndex);
                    }
                */
                

            }

            
            

        }

        private void btnSaveProcessAs_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Save as... Please wait for phase 2");


            //UCMainTask uSelect = (UCMainTask)global.currentTaskControlObject;
            //Task tTask = Task.getDeepestChild(uSelect.taskMember);
            //MessageBox.Show(tTask.name);


            //PropertiesStrukt.TaskType ttTest = new PropertiesStrukt.TaskType();
            //ttTest.name = "Creating Email";
            //ttTest.id = Strukt.Type_Task_type + "1087742252";
            //PropertiesStrukt.TaskType ttResult = PropertiesStrukt.TaskType.editTaskType(ttTest);
            //MessageBox.Show(ttResult.id);
            
        }

        private void btnAddProcess_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Add new process... Please wait for phase 2");
        }

        private void editNameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (global.currentTaskControlObject == null)
            {
                MessageBox.Show("Please select a task");
                return;
            }
            UCMainTask umSelect = (UCMainTask)global.currentTaskControlObject;
            TextBox tb = new TextBox();
            tb.Name = "TBtemp";
            tb.Text = umSelect.Controls["lbTitle"].Text;
            umSelect.Controls.Add(tb);
            tb.Location = umSelect.Controls["lbTitle"].Location;
            tb.Height = umSelect.Controls["lbTitle"].Size.Height;
            tb.Width = 120;
            tb.BringToFront();
            tb.Leave += new EventHandler(tb_Leave);
            tb.KeyPress += new KeyPressEventHandler(tb_KeyPress);
        }

        private void tb_Leave(object sender, EventArgs e)
        {
            UCMainTask umSelect = (UCMainTask)global.currentTaskControlObject;
            TextBox tb = (TextBox)sender;
            umSelect.taskMember.name = tb.Text;
            Task.editTask(umSelect.taskMember);
            umSelect.Controls["lbTitle"].Text = tb.Text;         
            umSelect.Controls.Remove(tb);
        }

        private void tb_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                tb_Leave(sender, e);
            }
        }

        private void assignTaskToolStrip_Click(object sender, EventArgs e)
        {
            btnAssignment_Click(sender, e);
        }

        private void btnAssignment_Click(object sender, EventArgs e)
        {
            if (!global.processTable.Columns.Contains("u_name"))
            {
                MessageBox.Show("Please log-in before assign the task!");
                return;
            }

            frmAssign frmAs = new frmAssign();
            DialogResult dResult = frmAs.ShowDialog();
            if (DialogResult == DialogResult.OK)
            {
            }

        }


    }
}
