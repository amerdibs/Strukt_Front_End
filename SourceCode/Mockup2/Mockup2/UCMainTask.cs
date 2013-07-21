using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace Mockup2
{
    public partial class UCMainTask : UserControl
    {
        public event EventHandler MainTaskMouseDown;
        public event EventHandler MainTaskDragDrop;


        public Color preColor { get; set; }
        public Color colorBackGround { get; set; }
        public Task taskMember { get; set; }
        public int iLevel { get; set; }
        //public Task taskUse { get; set; }
        public byte collapseType { get; set; }
        public const byte collapseType_nochild = 0;
        public const byte collapseType_collapse = 1;
        public const byte collapseType_uncollapse = 2;

        public UCMainTask()
        {

            InitializeComponent();

            
        }



        private void tb_Leave(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            lbTitle.Text = tb.Text;
            this.Controls.Remove(tb);
        }

        private void tb_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
           {
               tb_Leave(sender, e);
           }
        }

        private void UCMainTask_MouseEnter(object sender, EventArgs e)
        {
            preColor = this.BackColor;
            this.BackColor = global.ColorHover;
        }

        private void UCMainTask_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = preColor;
        }


        private void lbTitle_Click_1(object sender, EventArgs e)
        {
            UCMainTask_MouseDown(this, new MouseEventArgs(Control.MouseButtons, 0, Control.MousePosition.X, Control.MousePosition.Y, 0));
        }

        private void btnProp_Click(object sender, EventArgs e)
        {
            frmTaskEdit frTaskEdit = new frmTaskEdit();
            frTaskEdit.taskUse = taskMember;
            frTaskEdit.strFormMode = frTaskEdit.formModeEdit;
            DialogResult dialog= frTaskEdit.ShowDialog();
            if (dialog != DialogResult.OK)
            {
                return;
            }
           Task returnTask= Task.editTask(taskMember);
           //Update Task Extend in Webservice
           ttTaskControl.SetToolTip(lbTitle, taskMember.description);
           StruktWebservice.StruktUserSoapClient struktWS = new StruktWebservice.StruktUserSoapClient();
           struktWS.setUpdateTaskExtend(global.getValueFromStruktValue(taskMember.id), taskMember.description, taskMember.attachmentType, taskMember.attachmentDetail);

           lbTitle.Text = returnTask.name;

        }

        private void UCMainTask_DragDrop(object sender, DragEventArgs e)
        {
            //Raise event to the parent control
            //Null check makes sure the parent control is attached to the event 
            //Pakorn 16062013
            global.dropTaskControlObject = this;
            if (this.MainTaskDragDrop != null)
            {
                this.MainTaskDragDrop(sender, e);
            }
        }

        private void UCMainTask_MouseDown(object sender, MouseEventArgs e)
        {
            //--- Mouse clicked event
            global.currentTaskControlID = this.GetHashCode();
            global.currentTaskControlType = global.currentTaskControlTypeMainTask;
            global.currentTaskControlObject = this;
            this.BackColor = global.ColorSelect;
            preColor = global.ColorSelect;

            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                if (this.MainTaskMouseDown != null)
                    this.MainTaskMouseDown(sender, e);
            }
            else
            {
                //--- Drag drop event
                global.dragTaskControlID = (sender as UserControl).GetHashCode();
                global.dragTaskControlObject = this;
                DoDragDrop((sender as UserControl).GetHashCode().ToString(), DragDropEffects.Link);

            }
        }

        private void UCMainTask_DragEnter(object sender, DragEventArgs e)
        {
            if ((e.AllowedEffect & DragDropEffects.Link) != 0 && e.Data.GetDataPresent(typeof(string)))
            {
                e.Effect = DragDropEffects.Link;
            }
        }



        private void btnLink_Click(object sender, EventArgs e)
        {

            if (taskMember.attachmentType == "LINK")
            {
                global.openLink(taskMember.attachmentDetail);
            }
            else
                if (taskMember.attachmentType == "APP")
                {
                    DataRow[] rResult = global.appTable.Select("app_name = '" + taskMember.attachmentDetail +"'");
                    if (rResult.Length > 0)
                        System.Diagnostics.Process.Start(rResult[0]["app_address"].ToString());
                }
                else
                    if (taskMember.attachmentType == "FILE")
                    {
                        System.Diagnostics.Process.Start(taskMember.attachmentDetail);
                    }
        }


       

        private void cbCheck_Click(object sender, EventArgs e)
        {
            if (cbCheck.Checked)
            {
                Cursor.Current = Cursors.WaitCursor;
                //  PropertiesStrukt.Status.updateStatus(taskMember, true);
                List<Task> taskList = new List<Task>();
                PropertiesStrukt.Status.updateTaskChildStatusFromActiveToComplete(taskMember, taskList);
                PropertiesStrukt.Status.updateTaskParentStatusFromActiveToComplete(taskMember, taskList);
                foreach (Object oEach in this.Parent.Controls)
                {
                    UCMainTask ucEach = (UCMainTask)oEach;
                    foreach (Task taskEach in taskList)
                    {
                        if (taskEach.id == ucEach.taskMember.id)
                        {
                            ucEach.cbCheck.Checked = true;
                        }
                    }
                }

                Cursor.Current = Cursors.Default;

            }
            else
            {
                Cursor.Current = Cursors.WaitCursor;
                List<Task> taskList = new List<Task>();
                if (this.taskMember.workflowChild.taskChildList != null && this.taskMember.workflowChild.taskChildList.Count > 0)
                {
                    DialogResult result = MessageBox.Show("if you unchecked this task all of it's subtasks will be unchecked", "Are you Sure", MessageBoxButtons.OKCancel);
                    if (result == System.Windows.Forms.DialogResult.OK)
                    {
                        PropertiesStrukt.Status.updateTaskParentStatusFromCompleteToActive(taskMember, taskList);
                        PropertiesStrukt.Status.updateTaskChildStatusFromCompleteToActive(taskMember, taskList);

                        foreach (Object oEach in this.Parent.Controls)
                        {
                            UCMainTask ucEach = (UCMainTask)oEach;
                            foreach (Task taskEach in taskList)
                            {
                                if (taskEach.id == ucEach.taskMember.id)
                                {
                                    ucEach.cbCheck.Checked = false;
                                }
                            }
                        }
                    }
                    if (result == System.Windows.Forms.DialogResult.Cancel)
                        this.cbCheck.Checked = true;

                }
                else
                {

                    PropertiesStrukt.Status.updateTaskParentStatusFromCompleteToActive(taskMember, taskList);
                    PropertiesStrukt.Status.updateTaskChildStatusFromCompleteToActive(taskMember, taskList);

                    foreach (Object oEach in this.Parent.Controls)
                    {
                        UCMainTask ucEach = (UCMainTask)oEach;
                        foreach (Task taskEach in taskList)
                        {
                            if (taskEach.id == ucEach.taskMember.id)
                            {
                                ucEach.cbCheck.Checked = false;
                            }
                        }
                    }
                }
            }
   
        }

        private void btnSendtoAssigner_Click(object sender, EventArgs e)
        {
            frmMessage fMsg = new frmMessage();
            ListBox lbUse = (ListBox)fMsg.Controls["pnBody"].Controls["lbUser"];
            lbUse.Items.Add(txtReceive.Text);
            fMsg.ShowDialog();
        }

        private void btnSendtoReceiver_Click(object sender, EventArgs e)
        {
            frmMessage fMsg = new frmMessage();
            ListBox lbUse = (ListBox)fMsg.Controls["pnBody"].Controls["lbUser"];
            foreach(DataRowView v in lbAssigned.SelectedItems)
            {
                lbUse.Items.Add(v.Row["u_name"]);
            }
            fMsg.ShowDialog();
        }

        private void cbCheck_CheckStateChanged(object sender, EventArgs e)
        {
            //this is only for the first prototype since the cbCheck_Click is called once again after the this if finish
            //the actuall state is back to active afterwords 
            if (this.taskMember.status_id == PropertiesStrukt.Status.statusNoNActive)
            {
                Cursor.Current = Cursors.WaitCursor;
                cbCheck.Checked = false;
                cbCheck.Enabled = false;
                Cursor.Current = Cursors.Default;
                MessageBox.Show("Sorry this task is not active");
                
                
            }
        }

        private void UCMainTask_Paint(object sender, PaintEventArgs e)
        {
            if (this.Height > 0)
            {
                Rectangle rc = new Rectangle(0, 0, this.ClientSize.Width, this.ClientSize.Height);
                using (LinearGradientBrush brush = new LinearGradientBrush(rc, this.BackColor, Color.White, LinearGradientMode.Horizontal))
                {

                    e.Graphics.FillRectangle(brush, rc);

                }
            }
        }

        public void setExistenceCollapeButtonRole()
        {   
            //Check children under this task
            if ((taskMember.workflowChild.taskChildList != null) && (taskMember.workflowChild.taskChildList.Count > 0))
            {
                pbCollape.Visible = true;
                collapseType = collapseType_collapse;
            }
            else
            {
                pbCollape.Visible = false;
                collapseType = collapseType_nochild;
            }

            //User's role control
            if (global.roleUser == User.roleExecutor)
                btnProp.Visible = false;

        }

        private void lbTitle_DragDrop(object sender, DragEventArgs e)
        {
            //Raise event to the parent control
            //Null check makes sure the parent control is attached to the event 
            //Pakorn 16062013
            global.dropTaskControlObject = this;
            if (this.MainTaskDragDrop != null)
            {
                this.MainTaskDragDrop(sender, e);
            }
        }

        private void lbTitle_DragEnter(object sender, DragEventArgs e)
        {
            if ((e.AllowedEffect & DragDropEffects.Link) != 0 && e.Data.GetDataPresent(typeof(string)))
            {
                e.Effect = DragDropEffects.Link;
            }
        }

        private void pnReceived_DragDrop(object sender, DragEventArgs e)
        {
            //Raise event to the parent control
            //Null check makes sure the parent control is attached to the event 
            //Pakorn 16062013
            global.dropTaskControlObject = this;
            if (this.MainTaskDragDrop != null)
            {
                this.MainTaskDragDrop(sender, e);
            }
        }

        private void pnReceived_DragEnter(object sender, DragEventArgs e)
        {
            if ((e.AllowedEffect & DragDropEffects.Link) != 0 && e.Data.GetDataPresent(typeof(string)))
            {
                e.Effect = DragDropEffects.Link;
            }
        }

        private void pnAssigned_DragDrop(object sender, DragEventArgs e)
        {
            //Raise event to the parent control
            //Null check makes sure the parent control is attached to the event 
            //Pakorn 16062013
            global.dropTaskControlObject = this;
            if (this.MainTaskDragDrop != null)
            {
                this.MainTaskDragDrop(sender, e);
            }
        }

        private void pnAssigned_DragEnter(object sender, DragEventArgs e)
        {
            if ((e.AllowedEffect & DragDropEffects.Link) != 0 && e.Data.GetDataPresent(typeof(string)))
            {
                e.Effect = DragDropEffects.Link;
            }
        }


      
    }
}
