using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProcScribe
{
    public partial class UCListItem : UserControl
    {
        public UCListItem()
        {
            InitializeComponent();
        }

        private void UCListItem_MouseEnter(object sender, EventArgs e)
        {
            setColorMouseEnter();
        }

        private void UCListItem_MouseLeave(object sender, EventArgs e)
        {
            setColorMouseLeave();
        }

        private void setColorMouseEnter()
        {
            this.BackColor = global.ColorHover;
            lbTaskDesc.BackColor = global.ColorHover;
        }

        private void setColorMouseLeave()
        {
            this.BackColor = global.ColorMainTask;
            lbTaskDesc.BackColor = global.ColorMainTask;
        }

        private void lbTaskName_MouseEnter(object sender, EventArgs e)
        {
            UCListItem_MouseEnter(sender, e);
        }

        private void lbTaskName_MouseLeave(object sender, EventArgs e)
        {

        }


    }
}
