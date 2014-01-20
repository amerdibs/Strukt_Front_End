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

namespace ProcScribe
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
           lbDesc.Text = taskMember.description;
           btnLink.Text = taskMember.linkDetail;
           if (taskMember.description.Length == 0)
               pbDesc.Visible = false;
           else
               pbDesc.Visible = true;
           StruktWebservice.StruktUserSoapClient struktWS = new StruktWebservice.StruktUserSoapClient();
           struktWS.setUpdateTaskExtend(global.getValueFromStruktValue(taskMember.id), taskMember.description, taskMember.attachmentType, taskMember.attachmentDetail, taskMember.keyword, taskMember.linkDetail);
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
            //do not use gradient color
            //if (this.Height > 0)
            //{
            //    Rectangle rc = new Rectangle(0, 0, this.ClientSize.Width, this.ClientSize.Height);
            //    using (LinearGradientBrush brush = new LinearGradientBrush(rc, this.BackColor, Color.White, LinearGradientMode.Horizontal))
            //    {

            //        e.Graphics.FillRectangle(brush, rc);

            //    }
            //}

            if (global.roleUser == User.roleExecutor)
                btnProp.Visible = false;
            else
                btnProp.Visible = true;

            if (collapseType == collapseType_uncollapse)
            {
                lbTail2.Visible = true;
                if (String.IsNullOrEmpty(this.taskMember.precedes_id))
                {
                    lbTail.Visible = false;
                }
                else
                {
                    lbTail.Visible = true;
                }
            }
            else
            {
                lbTail2.Visible = false;
                if (String.IsNullOrEmpty(this.taskMember.precedes_id))
                {
                    lbTail.Visible = false;
                }
                else
                {
                    lbTail.Visible = true;
                }
            }
            undrawTaskHeirarchy(this.taskMember.workflowParent.taskParent, 0);
            //undrawTaskHeirarchy(this.taskMember.workflowParent.taskParent);
            //if (this.taskMember.workflowParent.taskParent != null)
            //{
            //    if (String.IsNullOrEmpty(this.taskMember.workflowParent.taskParent.precedes_id))
            //    {
            //        for (int i = iLevel - 1 ; i < iLevel; i++)
            //        {
            //            if (this.Controls["lbTail_" + i.ToString()] != null)
            //            {
            //                Label lb = (Label)this.Controls["lbTail_" + i.ToString()];
            //                lb.Visible = false;
            //            }
            //        }
            //    }

            //    if (this.taskMember.workflowParent.taskParent.workflowParent.taskParent != null)
            //    {
            //        if (String.IsNullOrEmpty(this.taskMember.workflowParent.taskParent.workflowParent.taskParent.precedes_id))
            //        {
            //            for (int i = iLevel-2; i < iLevel; i++)
            //            {
            //                if (this.Controls["lbTail_" + i.ToString()] != null)
            //                {
            //                    Label lb = (Label)this.Controls["lbTail_" + i.ToString()];
            //                    lb.Visible = false;
            //                }
            //            }
            //        }



            //            if (this.taskMember.workflowParent.taskParent.workflowParent.taskParent.workflowParent.taskParent != null)
            //            {
            //                if (String.IsNullOrEmpty(this.taskMember.workflowParent.taskParent.workflowParent.taskParent.workflowParent.taskParent.precedes_id))
            //                {
            //                    for (int i = iLevel - 3; i < iLevel; i++)
            //                    {
            //                        if (this.Controls["lbTail_" + i.ToString()] != null)
            //                        {
            //                            Label lb = (Label)this.Controls["lbTail_" + i.ToString()];
            //                            lb.Visible = false;
            //                        }
            //                    }
            //                }
            //            }
                    


             //   }

                

                
            //}

            if (String.IsNullOrEmpty(this.taskMember.attachmentDetail))
            {
                btnLink.Visible = false;
            }
            else
            {
                btnLink.Visible = true;
                btnLink.Text = this.taskMember.linkDetail;
            }

            if (String.IsNullOrEmpty(this.taskMember.description))
            {
                lbDesc.Visible = false;
            }
            else
            {
                lbDesc.Visible = true;
            }


        }

        public void undrawTaskHeirarchy(Task taskParam, int iCutLevel)
        {
            //if (this.taskMember.workflowParent.taskParent != null)
            //{
            //    if (String.IsNullOrEmpty(this.taskMember.workflowParent.taskParent.precedes_id))
            //    {
            //        for (int i = iLevel - 1 ; i < iLevel; i++)
            //        {
            //            if (this.Controls["lbTail_" + i.ToString()] != null)
            //            {
            //                Label lb = (Label)this.Controls["lbTail_" + i.ToString()];
            //                lb.Visible = false;
            //            }
            //        }
            //    }
            if (taskParam != null)
            {
                if  (String.IsNullOrEmpty(taskParam.precedes_id))
                {
                    iCutLevel++;
                    //for (int i = 0; i < iLevel; i++)
                    //{

                    //        if (this.Controls["lbTail_" + i.ToString()] != null)
                    //        {
                    //            Label lb = (Label)this.Controls["lbTail_" + i.ToString()];
                    //            lb.Visible = true;
                    //        }

                    //}

                    //for (int i = iLevel - 1; i >= 0; i--)
                    for (int i = 0; i < iLevel; i++)
                    {
                        if (!checkIfParentHasPrecedes(taskParam, 0, i))
                        //if (true)
                        {
                            if (this.Controls["lbTail_" + i.ToString()] != null)
                            {
                                Label lb = (Label)this.Controls["lbTail_" + i.ToString()];
                                lb.Visible = false;
                            }
                        }
                    }
                }
                undrawTaskHeirarchy(taskParam.workflowParent.taskParent, iCutLevel); 
            }
        }

        public Boolean checkIfParentHasPrecedes(Task taskParam, int iDesiredLevel, int iLevel)
        {
            if (taskParam != null)
            {
                if (iDesiredLevel == iLevel)
                {
                    //if ((taskParam.workflowChild.taskChildList != null) && (taskParam.workflowChild.taskChildList.Count > 0))
                    if (String.IsNullOrEmpty(taskParam.precedes_id))
                        return false;
                    else
                        //return checkIfParentHasChild(taskParam.workflowParent.taskParent, iDesiredLevel, iLevel);
                        return true;
                }
                else
                {
                    iDesiredLevel++;
                    return checkIfParentHasPrecedes(taskParam.workflowParent.taskParent, iDesiredLevel, iLevel);
                }
            }
            else
                return false;




            //checkIfParentHasChild(taskParam.workflowParent.taskParent, iDesiredLevel, iLevel);
            //iDesiredLevel++;
            //if (taskParam != null)
            //{
            //    if (iDesiredLevel == iLevel)
            //    {
            //        if ((taskParam.workflowChild.taskChildList != null) && (taskParam.workflowChild.taskChildList.Count > 0))
            //            return true;
            //        else
            //            return false;
            //    }
            //    else
            //        return false;
            //}
            //else
            //    return false;
            ////checkIfParentHasChild(taskParam.workflowParent.taskParent, iDesiredLevel, iLevel);

            
        }

        public void drawTaskHeirarchyIfParentHasChild(Task taskParam)
        {
            if (taskParam != null)
            {
                if (String.IsNullOrEmpty(taskParam.precedes_id))
                {
                    for (int i = 0; i < iLevel; i++)
                    {
                        if (this.Controls["lbTail_" + i.ToString()] != null)
                        {
                            Label lb = (Label)this.Controls["lbTail_" + i.ToString()];
                            lb.Visible = false;
                        }
                    }
                }
                drawTaskHeirarchyIfParentHasChild(taskParam.workflowParent.taskParent);
            }
        }


        public void setExistenceCollapeButtonRoleChild()
        {
            //Check children under this task
            if ((taskMember.workflowChild.taskChildList != null) && (taskMember.workflowChild.taskChildList.Count > 0))
            {
                pbCollape.Visible = true;
                collapseType = collapseType_uncollapse;
                pbCollape.Image = Properties.Resources.uncollapes;
            }
            else
            {
                //pbCollape.Visible = false;
                collapseType = collapseType_nochild;
                pbCollape.Image = null;
            }

            //User's role control
            //if (global.roleUser == User.roleExecutor)
            //    btnProp.Visible = false;

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
                //pbCollape.Visible = false;
                collapseType = collapseType_nochild;
                pbCollape.Image = null;
            }

            //User's role control
            //if (global.roleUser == User.roleExecutor)
            //    btnProp.Visible = false;

        }

        private void lbTitle_DragDrop(object sender, DragEventArgs e)
        {
            //Raise event to the parent control
            //Null check makes sure the parent control is attached to the event 
            //Pakorn 16062013
            global.dropTaskControlObject = this;
            if (this.MainTaskDragDrop != null)
            {
                this.MainTaskDragDrop(this, e);
            }
        }

        private void lbTitle_DragEnter(object sender, DragEventArgs e)
        {
            if ((e.AllowedEffect & DragDropEffects.Link) != 0 && e.Data.GetDataPresent(typeof(string)))
            {
                e.Effect = DragDropEffects.Link;
            }
        }

        private void lbTitle_MouseDown(object sender, MouseEventArgs e)
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
                global.dragTaskControlID = (this as UserControl).GetHashCode();
                global.dragTaskControlObject = this;
                DoDragDrop((this as UserControl).GetHashCode().ToString(), DragDropEffects.Link);

            }
        }

        private void pbDesc_Click(object sender, EventArgs e)
        {
            if (this.Height == global.heightControlTaskNormal)
            {
                this.Height = global.heightControlTaskDesc;
                lbDesc.Height = 30;
                btnLink.Top = lbDesc.Top + lbDesc.Height + 2;
            }
            else if (this.Height == global.heightControlTaskDesc)
            {
                TextBox tb = new TextBox();
                this.Controls.Add(tb);
                tb.Multiline = true;
                tb.BorderStyle = BorderStyle.FixedSingle;
                tb.Width = lbDesc.Width;
                tb.Top = lbDesc.Top;
                tb.Left = lbDesc.Left;
                tb.Height = 150;
                tb.ScrollBars = ScrollBars.Vertical;
                tb.Text = taskMember.description.Replace("\n", Environment.NewLine);
                tb.Name = "tbDescLong";
                tb.ReadOnly = true;
                tb.Anchor = lbDesc.Anchor;
                tb.BringToFront();
                btnLink.Top = tb.Top + tb.Height + 2;
                pbDesc.BringToFront();
                this.Height = global.heightControlTaskDescLong;
                //this.Height = global.heightControlTaskNormal;
                //lbDesc.Height = 14;
            }
            else if (this.Height == global.heightControlTaskDescLong)
            {
                if (this.Controls["tbDescLong"] != null)
                {
                    this.Controls.Remove(this.Controls["tbDescLong"]);
                }
                //this.Height = global.heightControlTaskDesc;
                //btnLink.Top = 56;
                this.Height = global.heightControlTaskNormal;
                lbDesc.Height = 14;
                btnLink.Top = lbDesc.Top + lbDesc.Height + 2;
            }
        }

        public void generateLabelHierarchy()
        {
            for (int i = 0; i < iLevel; i++)
            {
                Label lb = new Label();
                this.Controls.Add(lb);
                lb.Name = "lbTail_" + i.ToString();
                lb.Width = 5;
                lb.Height = 200;
                lb.Top = 0;
                lb.Left = global.iIndentOfCheckBox * i;
                lb.BackColor = Color.Black;
            }
            
        }


        
    }
}
