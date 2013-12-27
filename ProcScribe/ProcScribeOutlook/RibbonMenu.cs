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
using System.Diagnostics;

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
            Process p = new Process();
            p.StartInfo.FileName = globalOutlook.proscribePath;
            //p.StartInfo.Arguments = "/c dir *.cs";
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.RedirectStandardOutput = true;
            p.Start();
            //globalOutlook.proscribeAddIn.Application.ActiveExplorer().
        }
    }
}
