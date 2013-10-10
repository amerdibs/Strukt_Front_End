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
using System.Runtime.InteropServices;
using Microsoft.Win32;


namespace ProcScribe
{
    public partial class frmMain : Form
    {
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd,
                         int Msg, int wParam, int lParam);

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        public frmMain()
        {
            InitializeComponent();
         
        }

        private void checkAssignmentUpdateControl(object sender, EventArgs e)
        {
            if (global.processTable.Columns.Contains("u_name"))
            {
                //Assignment Checking
                bool bResult = Assignment.checkGetAssignmentByUserID(global.processTable.Rows[0]["u_strukt_user_id"].ToString());
                if (bResult)
                {
                    MessageBox.Show("There is a new assigned task to you.");
                    //We are interested only the assignments which we received for acknowledgement
                    foreach (Assignment asEach in global.assignmentReceivedList)
                    {
                        if (asEach.acknowledged == "false")
                        {
                            frmAcknowledge fAck = new frmAcknowledge();
                            Task tGet = Task.getTaskByID(global.getValueFromStruktValue(asEach.source_task_id))[0];
                            if (tGet != null)
                            {
                                StruktWebservice.StruktUserSoapClient wsStrukt = new StruktWebservice.StruktUserSoapClient();

                                DataTable dtUser = wsStrukt.getUserByStruktID(global.getValueFromStruktValue(tGet.user_id));
                                if (dtUser != null)
                                {
                                    fAck.Controls["pnBody"].Controls["txtUser"].Text = dtUser.Rows[0]["u_name"].ToString();
                                }
                                else
                                {
                                    fAck.Controls["pnBody"].Text = "not exists in Log-In: " + global.getValueFromStruktValue(tGet.user_id);
                                }
                            }

                            fAck.Controls["pnBody"].Controls["txtMsg"].Text = asEach.message;

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
                    btnLoadProcess_Click(sender, e);
                }
            }
        }


        private void frmMain_Load(object sender, EventArgs e)
        {
            //Set appearance by options from registry
            RegistryKey readReg;
            readReg = Registry.CurrentUser.OpenSubKey(global.registryPath, true);
            if (readReg == null)
            {
                Registry.CurrentUser.CreateSubKey(global.registryPath);
                readReg = Registry.CurrentUser.OpenSubKey(global.registryPath, true);
                readReg.SetValue("ALLWAYTOP", "FALSE");
            }
            String strTop = readReg.GetValue("ALLWAYTOP","FALSE").ToString();
            if (strTop == "FALSE")
            {
                this.TopMost = false;
            }
            else
            {
                this.TopMost = true;
            }



            //Get all processes
            StruktWebservice.StruktUserSoapClient wsStrukt = new StruktWebservice.StruktUserSoapClient();
            global.processTable = wsStrukt.getProcessAll();

            cbProcess.DataSource = global.processTable;
            cbProcess.ValueMember = "p_workflow_id";
            cbProcess.DisplayMember = "p_name";

            global.userTable = wsStrukt.getUserAll();
            global.appTable = wsStrukt.getAppListAll();

            if (global.processTable.Columns.Contains("u_name"))
            {
                this.Text = global.processTable.Rows[0]["u_name"].ToString() + " >> Welcome to Guidance";

                //Set user role
                if (global.processTable.Rows[0]["u_role"] != null)
                    global.roleUser = global.processTable.Rows[0]["u_role"].ToString();

                if (global.roleUser == User.roleExecutor)
                {
                    btnAdd.Visible = false;
                    btnSubAdd.Visible = false;
                    btnDelete.Visible = false;
                }


                if (global.roleUser == User.roleExecutor)
                    tsUserName.Text = "User: " + global.processTable.Rows[0]["u_name"].ToString() + "     Role: Executor" ;
                else
                    if (global.roleUser == User.roleDesigner)
                        tsUserName.Text = "User: " + global.processTable.Rows[0]["u_name"].ToString() + "     Role: Process Designer";

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
                                    fAck.Controls["pnBody"].Controls["txtUser"].Text = dtUser.Rows[0]["u_name"].ToString();
                                }
                                else
                                {
                                    fAck.Controls["pnBody"].Text = "not exists in Log-In: " + global.getValueFromStruktValue(tGet.user_id);
                                }
                            }

                            fAck.Controls["pnBody"].Controls["txtMsg"].Text = asEach.message;

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
                    Task returnTaskAdd0 = Task.addTask(taskNew);
                    wfNew.parent_task_id = returnTaskAdd0.id;
                    returnTaskAdd0.child_workflow_id = wfNew.id;
                    wfNew.user_id = global.workflowMain.user_id;
                    Workflow returnChildWorkflow = Workflow.editWorkflow(wfNew);
                    Task returnTaskAdd = Task.editTask(returnTaskAdd0);
                    
                    if ((uSelect.taskMember.workflowChild.taskChildList != null) && (uSelect.taskMember.workflowChild.taskChildList.Count > 0))
                    {
                        
                        Task taskFollow = taskParent.workflowChild.taskChildList[0];
                        returnTaskAdd.follows_id = taskFollow.id;
                        taskFollow.precedes_id = returnTaskAdd.id;
                        Task taskReturn = Task.editTask(taskFollow);
                        returnTaskAdd = Task.editTask(returnTaskAdd);
                    }




                    returnTaskAdd.workflowChild = returnChildWorkflow;
                    returnTaskAdd.workflowParent = taskParent.workflowChild;



                    //Add Task and config UI
                    UCMainTask uMain = new UCMainTask();
                    uMain.Height = global.heightControlTaskNormal;
                    pnCenter.Controls.Add(uMain);
                    uMain.Dock = DockStyle.Top;
                   
                    returnTaskAdd.description = frmEdit.taskUse.description;
                    returnTaskAdd.attachmentType = frmEdit.taskUse.attachmentType;
                    returnTaskAdd.attachmentDetail = frmEdit.taskUse.attachmentDetail;

                    uMain.taskMember = returnTaskAdd;

                    int iIndex = 0;
                    if ((uSelect.taskMember.workflowChild.taskChildList != null) && (uSelect.taskMember.workflowChild.taskChildList.Count > 0))
                    {
                        //Task taskFollow = taskParent.workflowChild.taskChildList[0];
                        //taskParent.workflowChild.taskChildList.Insert(0, returnTaskAdd);
                        //foreach (UCMainTask ucmEach in pnCenter.Controls)
                        //{
                        //    if (ucmEach.taskMember.id == taskFollow.id)
                        //    {
                        //        iIndex = pnCenter.Controls.GetChildIndex(ucmEach, true);
                        //        break;
                        //    }
                        //}
                        Task taskFollow = taskParent.workflowChild.taskChildList[0];
                        taskParent.workflowChild.taskChildList.Insert(0, returnTaskAdd);
                        Task taskFollowDeepest = Task.getDeepestChild(taskFollow);
                        UCMainTask ucUse = getUCMainTaskByTask(taskFollowDeepest);
                        iIndex = pnCenter.Controls.GetChildIndex(ucUse, true);
                    }
                    else
                    {
                        iIndex = pnCenter.Controls.GetChildIndex(uSelect, true);
                        taskParent.workflowChild.taskChildList = new List<Task>();
                        taskParent.workflowChild.taskChildList.Add(returnTaskAdd);
                    }

                    pnCenter.Controls.SetChildIndex(uMain, iIndex);



                    uMain.Controls["lbTitle"].Text = returnTaskAdd.name;

                    uMain.iLevel = uSelect.iLevel + 1;
                    uMain.BackColor = global.ColorMainTask;
                    uMain.Controls["cbCheck"].Left = uSelect.Controls["cbCheck"].Left + global.iIndentOfCheckBox;
                    uMain.Controls["lbTitle"].Width = uMain.Controls["lbTitle"].Width - global.iIndentOfCheckBox;
                    uMain.Controls["lbTitle"].Left = uSelect.Controls["lbTitle"].Left + global.iIndentOfCheckBox;
                    uMain.Controls["pbCollape"].Left = uSelect.Controls["pbCollape"].Left + global.iIndentOfCheckBox;
                    uMain.setExistenceCollapeButtonRole();
                    UCMainTask ucParent = getUCMainTaskByTask(taskParent);
                    ucParent.setExistenceCollapeButtonRoleChild();
                    uMain.BackColor = global.getColorTaskControlBackground(uMain.BackColor, uMain.iLevel);
                    uMain.colorBackGround = uMain.BackColor;
                  
                    uMain.MouseDown += new MouseEventHandler(EventHandlerFromMainTask_MouseDown);
                    uMain.DragDrop += new DragEventHandler(EventHandlerFromMainTask_DragDrop);
                    PictureBox pbCollapse = (PictureBox)uMain.Controls["pbCollape"];
                    pbCollapse.MouseClick += pbCollapse_MouseClick;
                    Label lbTitle = (Label)uMain.Controls["lbTitle"];
                    lbTitle.MouseDown += new MouseEventHandler(EventHandlerFromMainTask_MouseDown);
                    lbTitle.DragDrop += new DragEventHandler(EventHandlerFromMainTask_DragDrop);

                    //Update Task Extend in Webservice
                    ttMainForm.SetToolTip(uMain.Controls["lbTitle"], uMain.taskMember.description);
                    StruktWebservice.StruktUserSoapClient struktWS = new StruktWebservice.StruktUserSoapClient();
                    struktWS.setUpdateTaskExtend(global.getValueFromStruktValue(uMain.taskMember.id), uMain.taskMember.description, uMain.taskMember.attachmentType, uMain.taskMember.attachmentDetail);
                    if (uMain.taskMember.attachmentType != "NONE" && uMain.taskMember.attachmentType != "" && uMain.taskMember.attachmentType != null)
                    {
                        uMain.Controls["btnLink"].Enabled = true;
                    }


                    checkAssignmentUpdateControl(sender, e);
                }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {



            if ((global.workflowMain == null) && ((global.workflowMain.taskChildList == null) || (global.workflowMain.taskChildList.Count == 0)))
            {
                MessageBox.Show("Please load process before.\n We still don't implement this step right now.");
                return;
            }
            else
            if ((global.workflowMain != null) && ((global.workflowMain.taskChildList == null) || (global.workflowMain.taskChildList.Count == 0)))
            {
                //0. Add new when there is no any task in main workflow
                Task taskNew = new Task();
                taskNew.parent_workflow_id = global.workflowMain.id;
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
                Task returnTaskAdd0 = Task.addTask(taskNew);


                wfNew.parent_task_id = returnTaskAdd0.id;
                returnTaskAdd0.child_workflow_id = wfNew.id;
                wfNew.user_id = global.workflowMain.user_id;
                Workflow returnChildWorkflow = Workflow.editWorkflow(wfNew);
                Task returnTaskAdd = Task.editTask(returnTaskAdd0);


                returnTaskAdd.workflowChild = returnChildWorkflow;
                returnTaskAdd.workflowParent = global.workflowMain;
                global.workflowMain.taskChildList = new List<Task>();
                global.workflowMain.taskChildList.Add(returnTaskAdd);

                returnTaskAdd.description = frmEdit.taskUse.description;
                returnTaskAdd.attachmentType = frmEdit.taskUse.attachmentType;
                returnTaskAdd.attachmentDetail = frmEdit.taskUse.attachmentDetail;

                //Add Task and config UI
                UCMainTask uMain = new UCMainTask();
                uMain.Height = global.heightControlTaskNormal;
                pnCenter.Controls.Add(uMain);
                uMain.Dock = DockStyle.Top;
                uMain.BringToFront();
                uMain.taskMember = returnTaskAdd;
                uMain.Controls["lbTitle"].Text = returnTaskAdd.name;
                uMain.setExistenceCollapeButtonRole();
                uMain.iLevel = 0;

                uMain.BackColor = global.ColorMainTask;
                uMain.colorBackGround = uMain.BackColor;

                uMain.MouseDown += new MouseEventHandler(EventHandlerFromMainTask_MouseDown);
                uMain.DragDrop += new DragEventHandler(EventHandlerFromMainTask_DragDrop);
                PictureBox pbCollapse = (PictureBox)uMain.Controls["pbCollape"];
                pbCollapse.MouseClick += pbCollapse_MouseClick;
                Label lbTitle = (Label)uMain.Controls["lbTitle"];
                lbTitle.MouseDown += new MouseEventHandler(EventHandlerFromMainTask_MouseDown);
                lbTitle.DragDrop += new DragEventHandler(EventHandlerFromMainTask_DragDrop);

                //Update Task Extend in Webservice
                ttMainForm.SetToolTip(uMain.Controls["lbTitle"], uMain.taskMember.description);
                StruktWebservice.StruktUserSoapClient struktWS = new StruktWebservice.StruktUserSoapClient();
                struktWS.setUpdateTaskExtend(global.getValueFromStruktValue(uMain.taskMember.id), uMain.taskMember.description, uMain.taskMember.attachmentType, uMain.taskMember.attachmentDetail);
                if (uMain.taskMember.attachmentType != "NONE" && uMain.taskMember.attachmentType != "" && uMain.taskMember.attachmentType != null)
                {
                    uMain.Controls["btnLink"].Enabled = true;
                }

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
                Task returnTaskAdd0 = Task.addTask(taskNew);


                wfNew.parent_task_id = returnTaskAdd0.id;
                returnTaskAdd0.child_workflow_id = wfNew.id;
                wfNew.user_id = global.workflowMain.user_id;
                Workflow returnChildWorkflow = Workflow.editWorkflow(wfNew);
                Task returnTaskAdd = Task.editTask(returnTaskAdd0);


                returnTaskAdd.workflowChild = returnChildWorkflow;
                returnTaskAdd.workflowParent = global.workflowMain;

                global.workflowMain.taskChildList.Insert(0, returnTaskAdd);
                global.workflowMain.taskChildList[1].precedes_id = returnTaskAdd.id;
                Task returnTaskFollow = Task.editTask(global.workflowMain.taskChildList[1]);

                returnTaskAdd.description = frmEdit.taskUse.description;
                returnTaskAdd.attachmentType = frmEdit.taskUse.attachmentType;
                returnTaskAdd.attachmentDetail = frmEdit.taskUse.attachmentDetail;

                //Add Task and config UI
                UCMainTask uMain = new UCMainTask();
                uMain.Height = global.heightControlTaskNormal;
                pnCenter.Controls.Add(uMain);
                uMain.Dock = DockStyle.Top;
                uMain.BringToFront();
                uMain.taskMember = returnTaskAdd;
                uMain.Controls["lbTitle"].Text = returnTaskAdd.name;
                uMain.setExistenceCollapeButtonRole();
                uMain.iLevel = 0;

                uMain.BackColor = global.ColorMainTask;
                uMain.colorBackGround = uMain.BackColor;

                uMain.MouseDown += new MouseEventHandler(EventHandlerFromMainTask_MouseDown);
                uMain.DragDrop += new DragEventHandler(EventHandlerFromMainTask_DragDrop);
                PictureBox pbCollapse = (PictureBox)uMain.Controls["pbCollape"];
                pbCollapse.MouseClick += pbCollapse_MouseClick;
                Label lbTitle = (Label)uMain.Controls["lbTitle"];
                lbTitle.MouseDown += new MouseEventHandler(EventHandlerFromMainTask_MouseDown);
                lbTitle.DragDrop += new DragEventHandler(EventHandlerFromMainTask_DragDrop);

                //Update Task Extend in Webservice
                ttMainForm.SetToolTip(uMain.Controls["lbTitle"], uMain.taskMember.description);
                StruktWebservice.StruktUserSoapClient struktWS = new StruktWebservice.StruktUserSoapClient();
                struktWS.setUpdateTaskExtend(global.getValueFromStruktValue(uMain.taskMember.id), uMain.taskMember.description, uMain.taskMember.attachmentType, uMain.taskMember.attachmentDetail);
                if (uMain.taskMember.attachmentType != "NONE" && uMain.taskMember.attachmentType != "" && uMain.taskMember.attachmentType != null)
                {
                    uMain.Controls["btnLink"].Enabled = true;
                }
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
                Task returnTaskAdd0 = Task.addTask(taskNew);

                wfNew.parent_task_id = returnTaskAdd0.id;
                returnTaskAdd0.child_workflow_id = wfNew.id;
                wfNew.user_id = global.workflowMain.user_id;
                Workflow returnChildWorkflow = Workflow.editWorkflow(wfNew);
                Task returnTaskAdd = Task.editTask(returnTaskAdd0);
                

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

                returnTaskAdd.description = frmEdit.taskUse.description;
                returnTaskAdd.attachmentType = frmEdit.taskUse.attachmentType;
                returnTaskAdd.attachmentDetail = frmEdit.taskUse.attachmentDetail;

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
                uMain.Controls["pbCollape"].Left = uSelect.Controls["pbCollape"].Left;
                uMain.setExistenceCollapeButtonRole();
                uMain.BackColor = global.getColorTaskControlBackground(uMain.BackColor, uSelect.iLevel);
                uMain.colorBackGround = uMain.BackColor;
                uMain.iLevel = uSelect.iLevel;

                uMain.MouseDown += new MouseEventHandler(EventHandlerFromMainTask_MouseDown);
                uMain.DragDrop += new DragEventHandler(EventHandlerFromMainTask_DragDrop);
                PictureBox pbCollapse = (PictureBox)uMain.Controls["pbCollape"];
                pbCollapse.MouseClick += pbCollapse_MouseClick;
                Label lbTitle = (Label)uMain.Controls["lbTitle"];
                lbTitle.MouseDown += new MouseEventHandler(EventHandlerFromMainTask_MouseDown);
                lbTitle.DragDrop += new DragEventHandler(EventHandlerFromMainTask_DragDrop);

                //Update Task Extend in Webservice
                ttMainForm.SetToolTip(uMain.Controls["lbTitle"], uMain.taskMember.description);
                StruktWebservice.StruktUserSoapClient struktWS = new StruktWebservice.StruktUserSoapClient();
                struktWS.setUpdateTaskExtend(global.getValueFromStruktValue(uMain.taskMember.id), uMain.taskMember.description, uMain.taskMember.attachmentType, uMain.taskMember.attachmentDetail);
                if (uMain.taskMember.attachmentType != "NONE" && uMain.taskMember.attachmentType != "" && uMain.taskMember.attachmentType != null)
                {
                    uMain.Controls["btnLink"].Enabled = true;
                }
            }

            checkAssignmentUpdateControl(sender, e);
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
                    strResult = Task.deleteTask(global.getValueFromStruktValue(uSelect.taskMember.id));
                    if (strResult != global.resultSuccessStrukt)
                    {
                        MessageBox.Show("There is error. Task cannot be deleted.");
                        return;
                    }

                    //When we delete that only one child task, the most of behavior, Strukt will delete its child workflow too.
                    //If we still insist to delete, we will meet error(500).
                    //strResult = Workflow.deleteWorkflow(global.getValueFromStruktValue(uSelect.taskMember.workflowChild.id));
                    //if (strResult != global.resultSuccessStrukt)
                    //{
                    //    MessageBox.Show("There is error. Workflow cannot be deleted.");
                    //    return;
                    //}

                    Workflow wfPre = uSelect.taskMember.workflowParent;
                    wfPre.taskChildList.Remove(uSelect.taskMember);
                    uSelect.taskMember.workflowChild = null;
                    uSelect.taskMember = null;
                    pnCenter.Controls.Remove(uSelect);

                    UCMainTask ucParent = getUCMainTaskByTask(wfPre.taskParent);
                    if (ucParent != null)
                        ucParent.setExistenceCollapeButtonRole();
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
                    //strResult = Workflow.deleteWorkflow(global.getValueFromStruktValue(uSelect.taskMember.workflowChild.id));
                    //if (strResult != global.resultSuccessStrukt)
                    //{
                    //    MessageBox.Show("There is error. Workflow cannot be deleted.");
                    //    return;
                    //}
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
                    //strResult = Workflow.deleteWorkflow(global.getValueFromStruktValue(uSelect.taskMember.workflowChild.id));
                    //if (strResult != global.resultSuccessStrukt)
                    //{
                    //    MessageBox.Show("There is error. Workflow cannot be deleted.");
                    //    return;
                    //}
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
                    //strResult = Workflow.deleteWorkflow(global.getValueFromStruktValue(uSelect.taskMember.workflowChild.id));
                    //if (strResult != global.resultSuccessStrukt)
                    //{
                    //    MessageBox.Show("There is error. Workflow cannot be deleted.");
                    //    return;
                    //}

                    Workflow wfPre = uSelect.taskMember.workflowParent;
                    wfPre.taskChildList.Remove(uSelect.taskMember);
                    uSelect.taskMember.workflowChild = null;
                    uSelect.taskMember = null;
                    pnCenter.Controls.Remove(uSelect);
                }

                global.currentTaskControlObject = null;
                global.currentTaskControlID = 0;

            }

            checkAssignmentUpdateControl(sender, e);





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
                
                global.currentTas= null;
                global.currentTaskControlID = 0;
            }
             */
        }

        private void btnOption_Click(object sender, EventArgs e)
        {
            frmOption fOp = new frmOption(this);
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
                if (global.roleUser == User.roleDesigner)
                    ctmTask.Show(Cursor.Position);
            }
            
        }

        public void EventHandlerFromSubTask_MouseDown(object sender, MouseEventArgs e)
        {
            clearOtherSelectColor();

            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                if (global.roleUser == User.roleDesigner)
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

            //Check user role
            if (global.roleUser == User.roleExecutor)
                return;

            // --- Drag drop event
            //The task is dropped on the panel.
            //We assign the last task of workflow to dropped object;
            global.dropTaskControlObject = getUCMainTaskByTaskID(global.workflowMain.taskChildList[0].id);
            EventHandlerFromMainTask_DragDrop(sender, e);

        }

        private void EventHandlerFromMainTask_DragDrop(object sender, DragEventArgs e)
        {
            // --- Mouse clicked event
            clearOtherSelectColor();

            //Error checking
            if (global.dragTaskControlObject == global.dropTaskControlObject)
                return;

            //Check user role
            if (global.roleUser == User.roleExecutor)
                return;

            // --- Drag drop event
            //The task is dropped on the UC main task.
            Object dragControl = global.dragTaskControlObject;
            Object receiveControl = global.dropTaskControlObject;

            UCMainTask ucReceive = (UCMainTask)receiveControl;
            UCMainTask ucDrag = (UCMainTask)dragControl;
            UCMainTask ucUpper = null;

            //The dragged task and dropped task must be in the same workflow.
            if (ucReceive.taskMember.parent_workflow_id != ucDrag.taskMember.parent_workflow_id)
            {
                MessageBox.Show("Please change order of tasks which are in the same workflow", "Cannot change the order of tasks");
                global.dragTaskControlObject = null;
                global.dragTaskControlID = 0;
                return;
            }


            Cursor.Current = Cursors.WaitCursor;

            try
            {
                //After move operation, we will clean the footprint of the task
                //    the dragged task come from first task in list
                //        change old follow task.follow_task_id to null
                //    the dragged task come from between two tasks
                //        change old upper(precedes) task.precedes_id to old follow task.id
                //        change old follow task.follow_id to old upper(precedes) task.id
                //    the dragged task come from last task in list
                //        change old upper(precedes) task.precedes_id to null
                UCMainTask ucOldFollow = null;
                UCMainTask ucOldUpper = null;
                if (ucDrag.taskMember.follows_id == null)
                {
                    if (ucDrag.taskMember.precedes_id != ucReceive.taskMember.id)
                    {
                        ucOldFollow = getUCMainTaskByTaskID(ucDrag.taskMember.precedes_id);
                        ucOldFollow.taskMember.follows_id = null;
                    }
                }
                else
                    if (ucDrag.taskMember.precedes_id == null)
                    {
                        ucOldUpper = getUCMainTaskByTaskID(ucDrag.taskMember.follows_id);
                        ucOldUpper.taskMember.precedes_id = null;
                    }
                    else
                        if ((ucDrag.taskMember.follows_id != null) && (ucDrag.taskMember.precedes_id != null))
                        {
                            ucOldUpper = getUCMainTaskByTaskID(ucDrag.taskMember.follows_id);
                            ucOldFollow = getUCMainTaskByTaskID(ucDrag.taskMember.precedes_id);
                            ucOldUpper.taskMember.precedes_id = ucOldFollow.taskMember.id;
                            ucOldFollow.taskMember.follows_id = ucOldUpper.taskMember.id;

                        }

                //There are 3 situations which depend on the dropped destination.
                //1.Drop task at the top of the list
                //    load itself, load the first task of the list
                //        itself
                //            change precedes id to followed task id
                //            set follow id to null
                //        first task of the list
                //            change follow id to dropped task 
                if (ucReceive.taskMember.follows_id == null)
                {
                    ucDrag.taskMember.precedes_id = ucReceive.taskMember.id;
                    ucDrag.taskMember.follows_id = null;
                    ucReceive.taskMember.follows_id = ucDrag.taskMember.id;
                }

                //2.Drop task at the end of the list
                //    load itself, load the last task of the list
                //        itself
                //            change follow_id to the last task
                //            change precedes_id to null
                //        the last task of the list
                //            change precedes id to dropped task id
                else
                    if (ucReceive.taskMember.precedes_id == null)
                    {
                        ucDrag.taskMember.follows_id = ucReceive.taskMember.id;
                        ucDrag.taskMember.precedes_id = null;
                        ucReceive.taskMember.precedes_id = ucDrag.taskMember.id;
                    }

                //3.Drop task which is in between the other tasks
                    //    load itself, load the upper(precesdes) task, load the follow task
                    //        itself
                    //            change  follow_id to followed task id
                    //            change precedes_id to upper(precedes) task id
                    //        the upper(precesdes) task
                    //            change follow id to dragged task id
                    //        the follow task
                    //            change precedes id to dragged task id
                    else
                        if ((ucReceive.taskMember.precedes_id != null) && (ucReceive.taskMember.follows_id != null))
                        {
                            ucUpper = getUCMainTaskByTaskID(ucReceive.taskMember.follows_id);

                            if (ucUpper == ucDrag)
                            {
                                MessageBox.Show("Please move task from down to top");
                                return;
                            }

                            ucDrag.taskMember.follows_id = ucUpper.taskMember.id;
                            ucDrag.taskMember.precedes_id = ucReceive.taskMember.id;
                            ucUpper.taskMember.precedes_id = ucDrag.taskMember.id;
                            ucReceive.taskMember.follows_id = ucDrag.taskMember.id;
                        }




                if (ucOldFollow != null)
                {
                    Task taskReturnOldFollow = Task.editTask(ucOldFollow.taskMember);
                }

                if (ucOldUpper != null)
                {
                    Task taskReturnOldUpper = Task.editTask(ucOldUpper.taskMember);
                }

                if (ucUpper != null)
                {
                    Task taskReturnUpper = Task.editTask(ucUpper.taskMember);
                }
                Task taskReturnReceive = Task.editTask(ucReceive.taskMember);
                Task taskReturnDrag = Task.editTask(ucDrag.taskMember);
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
            

            //Change order of tasks
            if ((ucDrag.taskMember.workflowChild.taskChildList != null) && (ucDrag.taskMember.workflowChild.taskChildList.Count > 0))
            {
                btnLoadProcess_Click(sender, e);
            }
            else
            {
                int intReceive = pnCenter.Controls.GetChildIndex(ucReceive);
                pnCenter.Controls.SetChildIndex(ucDrag, intReceive);
            }


            global.dragTaskControlObject = null;
            global.dragTaskControlID = 0;

            
        }

        private void EventHandlerFromMainTask_CollapseClick(object sender, EventArgs e)
        {



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
                //Create main workflow object
                Workflow wfMain = Workflow.getWorkflowHierarchybyID(cbProcess.SelectedValue.ToString(),null);
                global.workflowMain = wfMain;
                pnCenter.Controls.Clear();

                //Generate task control
                generateTaskControl(wfMain, 0);
                setCollapeControlsAfterProcessLoad();

                //Create task extension and tooltips
                List<Task> taskList = new List<Task>();
                global.getTaskListFromAllWorkflow(global.workflowMain, taskList);
                List<string> listStrTaskID = new List<string>();
                foreach (Task tEach in taskList)
                {
                    listStrTaskID.Add(global.getValueFromStruktValue(tEach.id));
                }
                string[] arStr = new string[listStrTaskID.Count];
                listStrTaskID.CopyTo(arStr);
                StruktWebservice.StruktUserSoapClient struktWS = new StruktWebservice.StruktUserSoapClient();
                DataTable dtDesc = struktWS.getTaskExtendByList(arStr);
                if (dtDesc != null)
                {
                    foreach (DataRow dtRow in dtDesc.Rows)
                    {
                        foreach (Object obj in pnCenter.Controls)
                        {
                            UCMainTask ucMain = (UCMainTask)obj;
                            if (global.getValueFromStruktValue(ucMain.taskMember.id) == dtRow["tk_task_id"].ToString())
                            {
                                ttMainForm.SetToolTip(ucMain.Controls["lbTitle"], dtRow["tk_description"].ToString());
                                ucMain.taskMember.description = dtRow["tk_description"].ToString();
                                ucMain.taskMember.attachmentType = dtRow["tk_link_type"].ToString();
                                ucMain.taskMember.attachmentDetail = dtRow["tk_address"].ToString();
                                if (ucMain.taskMember.attachmentType != "NONE" && ucMain.taskMember.attachmentType != "" && ucMain.taskMember.attachmentType != null)
                                {
                                    ucMain.Controls["btnLink"].Enabled = true;
                                }
                            }

                        }
                }
                

                }



                //if (global.getValueFromStruktValue(wfMain.id) == "2120706644")
                //    MessageBox.Show("Please load the other process (Procument). Do not use this process to test! Please read only.");

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
                //comment after collapse implementation
                //uMain.Height = global.getHeightTaskControl(tEach);
                uMain.iLevel = iLevel;
                pnCenter.Controls.Add(uMain);
                uMain.Dock = DockStyle.Top;
                uMain.BackColor = global.ColorMainTask;
                uMain.Controls["lbTitle"].Text = tEach.name;
                uMain.Controls["cbCheck"].Left = uMain.Controls["cbCheck"].Left + (global.iIndentOfCheckBox * iLevel);
                uMain.Controls["lbTitle"].Width = uMain.Controls["lbTitle"].Width - (global.iIndentOfCheckBox * iLevel);
                uMain.Controls["lbTitle"].Left = uMain.Controls["lbTitle"].Left + (global.iIndentOfCheckBox * iLevel);
                uMain.Controls["pbCollape"].Left = uMain.Controls["pbCollape"].Left + (global.iIndentOfCheckBox * iLevel);
                uMain.setExistenceCollapeButtonRole();
                
        
                if (uMain.taskMember.status_id == PropertiesStrukt.Status.statusCompleted)
                {
                    CheckBox cbSelect = (CheckBox)uMain.Controls["cbCheck"];            
                    cbSelect.Checked = true;
                }
                uMain.BackColor = global.getColorTaskControlBackground(uMain.BackColor, iLevel);
                uMain.colorBackGround = uMain.BackColor;
                uMain.MouseDown += new MouseEventHandler(EventHandlerFromMainTask_MouseDown);
                uMain.DragDrop += new DragEventHandler(EventHandlerFromMainTask_DragDrop);
                PictureBox pbCollapse = (PictureBox)uMain.Controls["pbCollape"];
                pbCollapse.MouseClick += pbCollapse_MouseClick;
                Label lbTitle = (Label)uMain.Controls["lbTitle"];
                lbTitle.MouseDown += new MouseEventHandler(EventHandlerFromMainTask_MouseDown);
                lbTitle.DragDrop += new DragEventHandler(EventHandlerFromMainTask_DragDrop);

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



        private void frmMain_Paint(object sender, PaintEventArgs e)
        {
            Rectangle rc = new Rectangle(0, 0, this.ClientSize.Width, this.ClientSize.Height);
            using (LinearGradientBrush brush = new LinearGradientBrush(rc, Color.WhiteSmoke, Color.BurlyWood, LinearGradientMode.Vertical))
            {

                e.Graphics.FillRectangle(brush, rc);

            }

        }



        private void pnControl_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void lbTitle_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }


        private void setCollapeControlsAfterProcessLoad()
        {
            //set all controls to collapse 
            foreach (Object objEach in pnCenter.Controls)
            {
                UCMainTask ucTask = (UCMainTask)objEach;
                ucTask.Height = global.heightControlTaskCollape;
            }

            //set child of main workflow to normal 
            foreach (Object objEach in pnCenter.Controls)
            {
                UCMainTask ucTask = (UCMainTask)objEach;
                Task tFind = global.workflowMain.taskChildList.Find(o => o.id == ucTask.taskMember.id);
                if (tFind != null)
                {
                    ucTask.Height = global.getHeightTaskControl(tFind);
                }
            }

        }

        private void setCollapeControls(Workflow wfParam, bool bCollapse)
        {
            if ((wfParam.taskChildList == null) || (wfParam.taskChildList.Count == 0))
            {
                return;
            }

            foreach (Object objEach in pnCenter.Controls)
            {
                UCMainTask ucTask = (UCMainTask)objEach;
                Task tFind = wfParam.taskChildList.Find(o => o.id == ucTask.taskMember.id);
                if (tFind != null)
                {
                    if (bCollapse)
                    {
                        ucTask.Height = global.heightControlTaskCollape;
                    }
                    else
                    {
                        ucTask.Height = global.getHeightTaskControl(ucTask.taskMember);
                    }
                }
                
            }
           
        }

        void pbCollapse_MouseClick(object sender, MouseEventArgs e)
        {
            PictureBox pbCollapse = (PictureBox)sender;
            UCMainTask ucMain = (UCMainTask)pbCollapse.Parent;
            if (ucMain.collapseType == UCMainTask.collapseType_collapse)
            {
                setCollapeControls(ucMain.taskMember.workflowChild, false);
                pbCollapse.Image = Properties.Resources.uncollapes;
                ucMain.collapseType = UCMainTask.collapseType_uncollapse;
            }
            else if (ucMain.collapseType == UCMainTask.collapseType_uncollapse)
            {
                setCollapeControls(ucMain.taskMember.workflowChild, true);
                pbCollapse.Image = Properties.Resources.collapes;
                ucMain.collapseType = UCMainTask.collapseType_collapse;
            }
        }

        //set  focus at panel for scrollable panel
        private void pnCenter_MouseDown(object sender, MouseEventArgs e)
        {
            if (!pnCenter.Focused)
                pnCenter.Focus();
        }

        private UCMainTask getUCMainTaskByTask(Task taskParam)
        {
            UCMainTask ucRet = null;

            foreach(Object obj in pnCenter.Controls)
            {
                UCMainTask ucMain = (UCMainTask)obj;
                if (ucMain.taskMember.id == taskParam.id)
                {
                    ucRet = ucMain;
                }
            }
            return ucRet;
        }


        private UCMainTask getUCMainTaskByTaskID(string strTaskID)
        {
            UCMainTask ucRet = null;

            foreach (Object obj in pnCenter.Controls)
            {
                UCMainTask ucMain = (UCMainTask)obj;
                if (ucMain.taskMember.id == strTaskID)
                {
                    ucRet = ucMain;
                }
            }
            return ucRet;
        }

        private void cbProcess_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pnCenter_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
