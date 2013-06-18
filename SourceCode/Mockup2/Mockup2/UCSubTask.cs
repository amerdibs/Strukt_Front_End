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
    public partial class UCSubTask : UserControl
    {
        public Color preColor;
        public event EventHandler SubTaskMouseDown;
        public event EventHandler SubTaskDragDrop;

        public UCSubTask()
        {
            InitializeComponent();
            this.BackColor = global.ColorSubTask;
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

        private void UCSubTask_Load(object sender, EventArgs e)
        {

        }

        private void UCSubTask_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = preColor;
        }

        private void UCSubTask_MouseEnter(object sender, EventArgs e)
        {
            preColor = this.BackColor;
            this.BackColor = global.ColorHover;
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
            //UCSubTask_MouseDown(this, new MouseEventArgs(Control.MouseButtons, 0, Control.MousePosition.X, Control.MousePosition.Y, 0));
        }

        private void btnProp_Click(object sender, EventArgs e)
        {
            frmTaskEdit frmTE = new frmTaskEdit();
            frmTE.ShowDialog();
        }

        private void UCSubTask_DragEnter(object sender, DragEventArgs e)
        {
            if ((e.AllowedEffect & DragDropEffects.Link) != 0 && e.Data.GetDataPresent(typeof(string)))
            {
                e.Effect = DragDropEffects.Link;
            }
        }

        private void UCSubTask_MouseDown(object sender, MouseEventArgs e)
        {
            // --- Mouse Clicked event
            global.currentTaskControlID = this.GetHashCode();
            global.currentTaskControlType = global.currentTaskControlTypeSubTask;
            global.currentTaskControlObject = this;
            this.BackColor = global.ColorSelect;
            preColor = global.ColorSelect;

            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                if (this.SubTaskMouseDown != null)
                    this.SubTaskMouseDown(sender, e);
            }
            else
            {
                // --- Drag drop event
                global.dragTaskControlID = (sender as UserControl).GetHashCode();
                global.dragTaskControlObject = this;
                DoDragDrop((sender as UserControl).GetHashCode().ToString(), DragDropEffects.Link);
            }
        }

        private void UCSubTask_DragDrop(object sender, DragEventArgs e)
        {
            //Raise event to the parent control
            //Null check makes sure the parent control is attached to the event 
            //Pakorn 16062013
            global.dropTaskControlObject = this;
            if (this.SubTaskDragDrop != null)
            {
                this.SubTaskDragDrop(sender, e);
            }
                
        }

        private void btnLink_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.youtube.com/watch?v=t-WInuA12pc");
        }
    }
}
