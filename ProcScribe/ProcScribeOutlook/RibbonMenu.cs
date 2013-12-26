using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Office.Tools.Ribbon;
using Outlook = Microsoft.Office.Interop.Outlook;
using Office = Microsoft.Office.Core;
using System.Windows.Forms;
using System.Data;
using System.Drawing;

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

        private void rbtnDiscover_Click(object sender, RibbonControlEventArgs e)
        {
            List<TaskProcess> taskProcessList = TaskProcess.getTaskProcessAll();
            //globalOutlook.proscribeAddIn.Application.ActiveExplorer().
        }
    }
}
