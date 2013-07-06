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
            cbProcess.SelectedIndex = 0;

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
                MessageBox.Show("Please add a main task before.");
                return;
            }





            /*
            UCSubTask uSub = new UCSubTask();
            pnCenter.Controls.Add(uSub);
            uSub.Dock = DockStyle.Top;
            //uSub.BringToFront();
            if (global.currentTaskControlID == 0)
            {
                uSub.BringToFront();
            }
            else
            {
                Object uControl = global.currentTaskControlObject;
                if (uControl.GetType() == typeof(UCMainTask))
                {
                    UCMainTask uSelect = (UCMainTask)uControl;
                    int iIndex = pnCenter.Controls.GetChildIndex(uSelect, true);
                    pnCenter.Controls.SetChildIndex(uSub, iIndex);
                }
                else if (uControl.GetType() == typeof(UCSubTask))
                {
                    UCSubTask uSelect = (UCSubTask)uControl;
                    int iIndex = pnCenter.Controls.GetChildIndex(uSelect, true);
                    pnCenter.Controls.SetChildIndex(uSub, iIndex);
                }
            }

            uSub.MouseDown += new MouseEventHandler(EventHandlerFromSubTask_MouseDown);
            uSub.DragDrop += new DragEventHandler(EventHandlerFromSubTask_DragDrop);
             */
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            //UCMainTask uMain = new UCMainTask();
            //pnCenter.Controls.Add(uMain);
            //uMain.Dock = DockStyle.Top;
            //uMain.BringToFront();
            //uMain.taskMember = taskNew;
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

                global.workflowMain.taskChildList.Insert(0, returnTaskAdd);
                global.workflowMain.taskChildList[1].precedes_id = returnTaskAdd.id;
                Task returnTaskFollow = Task.editTask(global.workflowMain.taskChildList[1]);

                //Add Task and config UI
                UCMainTask uMain = new UCMainTask();
                pnCenter.Controls.Add(uMain);
                uMain.Dock = DockStyle.Top;
                uMain.BringToFront();
                uMain.taskMember = returnTaskAdd;
                uMain.Controls["lbTitle"].Text = returnTaskAdd.name;

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
                pnCenter.Controls.Add(uMain);
                uMain.Dock = DockStyle.Top;
                int iIndex = pnCenter.Controls.GetChildIndex(uSelect, true);
                pnCenter.Controls.SetChildIndex(uMain, iIndex);
                uMain.taskMember = returnTaskAdd;
                uMain.Controls["lbTitle"].Text = returnTaskAdd.name;

                uMain.BackColor = global.ColorMainTask;
                uMain.Controls["cbCheck"].Left = uSelect.Controls["cbCheck"].Left;
                uMain.Controls["lbTitle"].Left = uSelect.Controls["lbTitle"].Left;
                uMain.BackColor = Color.FromArgb(uMain.BackColor.R, uMain.BackColor.G, uMain.BackColor.B - (byte)(global.iGradientOfColor * uSelect.iLevel));
                uMain.colorBackGround = uMain.BackColor;

                uMain.MouseDown += new MouseEventHandler(EventHandlerFromMainTask_MouseDown);
                uMain.DragDrop += new DragEventHandler(EventHandlerFromMainTask_DragDrop);
            }

            //uMain.MouseDown += new MouseEventHandler(EventHandlerFromMainTask_MouseDown);
            //uMain.DragDrop += new DragEventHandler(EventHandlerFromMainTask_DragDrop);
            /*
            UCMainTask uMain = new UCMainTask();
            pnCenter.Controls.Add(uMain);
            uMain.Dock = DockStyle.Top;
            if (global.currentTaskControlID == 0)
            {
                uMain.BringToFront();
            }
            else
            {
                Object uControl = global.currentTaskControlObject;
                if (uControl.GetType() == typeof(UCMainTask))
                {
                    UCMainTask uSelect = (UCMainTask)uControl;
                    int iIndex = pnCenter.Controls.GetChildIndex(uSelect, true);
                    pnCenter.Controls.SetChildIndex(uMain, iIndex);
                }
                else if (uControl.GetType() == typeof(UCSubTask))
                {
                    UCSubTask uSelect = (UCSubTask)uControl;
                    int iIndex = pnCenter.Controls.GetChildIndex(uSelect, true);
                    pnCenter.Controls.SetChildIndex(uMain, iIndex);
                }
            }
            
            uMain.MouseDown += new MouseEventHandler(EventHandlerFromMainTask_MouseDown);
            uMain.DragDrop += new DragEventHandler(EventHandlerFromMainTask_DragDrop);
             * 
             * */

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
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
            /*
            foreach (Object uClickControl in pnCenter.Controls)
            {
                if (uClickControl.GetHashCode() != global.currentTaskControlID)
                {
                    if (uClickControl.GetType() == typeof(UCMainTask))
                    {
                        UCMainTask uMain = (UCMainTask)uClickControl;
                        uMain.BackColor = global.ColorMainTask;
                    }
                    else if (uClickControl.GetType() == typeof(UCSubTask))
                    {
                        UCSubTask uSub = (UCSubTask)uClickControl;
                        uSub.BackColor = global.ColorSubTask;
                    }
                }
            }
             * */
        }

        private void btnLoadProcess_Click(object sender, EventArgs e)
        {
            Workflow wfMain = Workflow.getWorkflowHierarchybyID(cbProcess.Text);
            global.workflowMain = wfMain;
            pnCenter.Controls.Clear();
            generateTaskControl(wfMain, 0);
            //MessageBox.Show("OK");
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
                frmMain.ActiveForm.Left = System.Windows.Forms.Screen.AllScreens[0].Bounds.Width - 400;
                btnHide.Image = ((System.Drawing.Image)(Properties.Resources.bt_skip_sw));
                global.hideWindows = false;
            }
        }

        //Create hierachy of Task Controls
        private void generateTaskControl(Workflow wfParam, int iLevel)
        {
            if (wfParam == null)
            {
                return;
            }
            foreach (Task tEach in wfParam.taskChildList)
            {
                generateTaskControl(tEach.workflowChild, iLevel + 1);
                UCMainTask uMain = new UCMainTask();
                uMain.taskMember = tEach;
                uMain.iLevel = iLevel;
                pnCenter.Controls.Add(uMain);
                uMain.Dock = DockStyle.Top;
                uMain.BackColor = global.ColorMainTask;
                uMain.Controls["lbTitle"].Text = tEach.name;
                uMain.Controls["cbCheck"].Left = uMain.Controls["cbCheck"].Left + (global.iIndentOfCheckBox * iLevel);
                uMain.Controls["lbTitle"].Left = uMain.Controls["lbTitle"].Left + (global.iIndentOfCheckBox * iLevel);
                uMain.BackColor = Color.FromArgb(uMain.BackColor.R, uMain.BackColor.G, uMain.BackColor.B - (byte)(global.iGradientOfColor * iLevel));
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
            
            PropertiesStrukt.TaskType ttTest = new PropertiesStrukt.TaskType();
            ttTest.name = "Creating Email";
            ttTest.id = Strukt.Type_Task_type + "1087742252";
            PropertiesStrukt.TaskType ttResult = PropertiesStrukt.TaskType.editTaskType(ttTest);
            MessageBox.Show(ttResult.id);
            
        }


    }
}
