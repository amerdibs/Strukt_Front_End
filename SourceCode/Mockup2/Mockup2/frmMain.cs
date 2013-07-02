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
            UCMainTask uMain = new UCMainTask();
            pnCenter.Controls.Add(uMain);
            uMain.Dock = DockStyle.Top;
            if (global.currentTaskControlID == 0)
            {
                uMain.BringToFront();
                Task taskNew = new Task();
                taskNew.follows_id = global.workflowMain.taskList[0].id;
                taskNew.name = "New Task";
                uMain.taskMember = taskNew;
                frmTaskEdit frmEdit = new frmTaskEdit();
                frmEdit.strFormMode = frmEdit.formModeNew;
                frmEdit.taskUse = taskNew;
                frmEdit.ShowDialog();


            }
            else
            {
                Object uControl = global.currentTaskControlObject;
                //Error checking
                if (uControl.GetType() == typeof(UCMainTask))
                {
                    UCMainTask uSelect = (UCMainTask)uControl;
                    int iIndex = pnCenter.Controls.GetChildIndex(uSelect, true);
                    pnCenter.Controls.SetChildIndex(uMain, iIndex);





                }
            }

            uMain.MouseDown += new MouseEventHandler(EventHandlerFromMainTask_MouseDown);
            uMain.DragDrop += new DragEventHandler(EventHandlerFromMainTask_DragDrop);
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
            Workflow wfMain = Workflow.getWorkflowHierachybyID(cbProcess.Text);
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
            foreach (Task tEach in wfParam.taskList)
            {
                generateTaskControl(tEach.workflowMember, iLevel + 1);
                UCMainTask uMain = new UCMainTask();
                uMain.taskMember = tEach;
                pnCenter.Controls.Add(uMain);
                uMain.Dock = DockStyle.Top;
                uMain.BackColor = global.ColorMainTask;
                uMain.Controls["lbTitle"].Text = tEach.name;
                uMain.Controls["cbCheck"].Left = uMain.Controls["cbCheck"].Left + (12 * iLevel);
                uMain.Controls["lbTitle"].Left = uMain.Controls["lbTitle"].Left + (12 * iLevel);
                uMain.BackColor = Color.FromArgb(uMain.BackColor.R, uMain.BackColor.G, uMain.BackColor.B - (byte)(40 * iLevel));
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
            /*
            PropertiesStrukt.TaskType ttTest = new PropertiesStrukt.TaskType();
            ttTest.name = "Manually";
            PropertiesStrukt.TaskType ttResult = PropertiesStrukt.TaskType.addTaskType(ttTest);
            MessageBox.Show(ttResult.id);
            */
        }


    }
}
