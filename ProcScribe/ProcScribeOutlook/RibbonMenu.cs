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
            Outlook.MailItem mailItem = null;
            if (globalOutlook.proscribeAddIn.Application.ActiveInspector() != null)
            {
                Outlook.Inspector activeInsp = globalOutlook.proscribeAddIn.Application.ActiveInspector();
                if (activeInsp.CurrentItem is Outlook.MailItem)
                {
                    mailItem = (Outlook.MailItem)activeInsp.CurrentItem;
                }
            }
            else
                if (globalOutlook.proscribeAddIn.Application.ActiveExplorer() != null)
                {
                    Outlook.Explorer activeExp = globalOutlook.proscribeAddIn.Application.ActiveExplorer();
                    if (activeExp.CurrentFolder.DefaultItemType == Outlook.OlItemType.olMailItem)
                    {
                        object selObject = activeExp.Selection[1];
                        if (selObject is Outlook.MailItem)
                        {
                            mailItem = (Outlook.MailItem)selObject;
                        }
                    }
                }

            if (mailItem != null)
            {
                String strMail = mailItem.Body.ToLower();

                foreach (TaskProcess taskP in taskProcessList)
                {
                    if (!String.IsNullOrEmpty(taskP.keyword))
                    {
                        String[] asKeyword = taskP.keyword.Split(',');
                        foreach (String sKeyword in asKeyword)
                        {
                            String sKeyTrim = sKeyword.Trim().ToLower();
                            if (!String.IsNullOrEmpty(sKeyTrim))
                            {
                                if (strMail.Contains(sKeyTrim))
                                {
                                    if (!globalOutlook.taskProcessFoundList.Contains(taskP))
                                        globalOutlook.taskProcessFoundList.Add(taskP);
                                }
                            }    
                        }
                    }
                }
                if (globalOutlook.taskProcessFoundList.Count > 0)
                {
                    frmSearchResult frmSR = new frmSearchResult();
                    frmSR.ShowDialog();
                }
            }
        }
    }
}
