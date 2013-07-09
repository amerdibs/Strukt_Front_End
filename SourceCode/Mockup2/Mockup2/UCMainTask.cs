using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        public UCMainTask()
        {

            InitializeComponent();

            
        }

        private void UCMainTask_Load(object sender, EventArgs e)
        {
            
        }

        private void lbTitle_Click(object sender, EventArgs e)
        {


            
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

        private void UCMainTask_Leave(object sender, EventArgs e)
        {
            /*
            foreach (Object cControl in this.Controls)
            {
                if (cControl.GetType() == typeof(TextBox))
                {
                    TextBox tb = (TextBox)cControl;
                    if (tb.Name == "TBtemp")
                    {
                        tb_Leave(sender, e);
                    }
                }
            }
            */
        }

        private void lbTitle_DoubleClick(object sender, EventArgs e)
        {
            TextBox tb = new TextBox();
            tb.Name = "TBtemp";
            tb.Text = lbTitle.Text;
            this.Controls.Add(tb);
            tb.Location = lbTitle.Location;
            tb.Height = lbTitle.Size.Height;
            tb.Width = 120;
            tb.BringToFront();
            tb.Leave += new EventHandler(tb_Leave);
            tb.KeyPress += new KeyPressEventHandler(tb_KeyPress);
        }

        private void lbTitle_Click_1(object sender, EventArgs e)
        {
            //UCMainTask_MouseDown(this, new MouseEventArgs(Control.MouseButtons, 0, Control.MousePosition.X, Control.MousePosition.Y, 0));
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

        private void UCMainTask_QueryContinueDrag(object sender, QueryContinueDragEventArgs e)
        {
            /*
            //If the left mouse button is up and the mouse is currently over LabelDrop
            if (Control.MouseButtons != MouseButtons.Left)
            {
                //Cancel the DragDrop Action
                e.Action = DragAction.Cancel;
                //Manually fire the MouseUp event
                

                UCMainTask_MouseUp(sender, new MouseEventArgs(Control.MouseButtons, 0, Control.MousePosition.X, Control.MousePosition.Y, 0));
            }*/
        }

        private void btnLink_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.uni-mannheim.de");
        }

        private void cbCheck_CheckedChanged(object sender, EventArgs e)
        {

            if (cbCheck.Checked)
            {
                PropertiesStrukt.Status.updateStatus(taskMember, true);
               //List <Workflow> parmWorkFowList=Workflow.getWorkflowByID(taskMember.child_workflow_id);
               // Workflow parmWorkFlow= parmWorkFowList[0];



               // List<Task> childTaskList = Task.getTaskByParentWorkflowID(global.getValueFromStruktValue(taskMember.child_workflow_id));

               // checktask(childTaskList,parmWorkFlow);


            }
            else
                PropertiesStrukt.Status.updateStatus(taskMember, false);
                //unchecktask(taskMember);
            
        }
        private void checktask(List<Task> taskList,Workflow workflow)
        {
            PropertiesStrukt p=new PropertiesStrukt();

            foreach (Task tEach in workflow.taskChildList)
            {
                checktask(taskList,tEach.workflowChild);
                //tEach.status_id = p.statusCompleted;
                return;

            }

        }
        private void unchecktask(Task taskparm)
        {
            PropertiesStrukt p = new PropertiesStrukt();
            //taskparm.status_id = p.statusActive;

        }
    }
}
