using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Office.Tools.Ribbon;
using Outlook = Microsoft.Office.Interop.Outlook;
//using Word = Microsoft.Office.Interop.Word;
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
            globalOutlook.taskProcessFoundList = new List<TaskProcess>();
            List<TaskProcess> taskProcessList = TaskProcess.getTaskProcessAll();
            if (globalOutlook.proscribeAddIn.Application.ActiveExplorer() != null)
            {
                Outlook.Explorer activeExp = globalOutlook.proscribeAddIn.Application.ActiveExplorer();
                if (activeExp.CurrentFolder.DefaultItemType == Outlook.OlItemType.olMailItem)
                {
                    object selObject = activeExp.Selection[1];
                    if (selObject is Outlook.MailItem)
                    {
                        Outlook.MailItem mailItem = (Outlook.MailItem)selObject;
                        String strMail = mailItem.Body;
                        foreach (TaskProcess taskP in taskProcessList)
                        {
                            if (!String.IsNullOrEmpty(taskP.keyword))
                            {
                                if (strMail.Contains(taskP.keyword))
                                {
                                    //MessageBox.Show(taskP.keyword);
                                    globalOutlook.taskProcessFoundList.Add(taskP);
                                }
                            }
                                
                        }
                        if (globalOutlook.taskProcessFoundList.Count > 0)
                        {
                            frmSearchResult frmSR = new frmSearchResult();
                            frmSR.ShowDialog();
                        }
                        //MessageBox.Show(mailItem.Body);
                        //Word.Document wed = mailItem.GetInspector.WordEditor;
                        //Word.Selection wsel = wed.Application.Selection;
                        

                    }
                }
            }
            
            





            //Process p = new Process();
            //p.StartInfo.FileName = globalOutlook.proscribePath;
            ////p.StartInfo.Arguments = "/c dir *.cs";
            //p.StartInfo.UseShellExecute = false;
            //p.StartInfo.RedirectStandardOutput = true;
            //p.Start();
            //globalOutlook.proscribeAddIn.Application.ActiveExplorer().
        }
    }
}
