using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Office.Tools.Ribbon;

namespace ProcScribeOutlook
{
    public partial class RibbonMenu
    {
        private void RibbonMenu_Load(object sender, RibbonUIEventArgs e)
        {

        }

        private void rbtnOption_Click(object sender, RibbonControlEventArgs e)
        {
            frmOptions frmOp = new frmOptions();
            frmOp.ShowDialog();
        }
    }
}
