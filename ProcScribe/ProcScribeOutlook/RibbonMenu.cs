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
using Microsoft.Win32;


namespace ProcScribeOutlook
{
    public partial class RibbonMenu
    {
        private void RibbonMenu_Load(object sender, RibbonUIEventArgs e)
        {
            if (globalOutlook.boolAuto)
            {
                tbtnAuto.Checked = true;
                tbtnAuto.Label = "Automatic On";
            }
            else
            {
                tbtnAuto.Checked = false;
                tbtnAuto.Label = "Automatic Off";
            }
        }

        private void rbtnOption_Click(object sender, RibbonControlEventArgs e)
        {
            frmOptions frmOp = new frmOptions();
            frmOp.ShowDialog();
        }

        public static void discoverAction()
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


        private void rbtnDiscover_Click(object sender, RibbonControlEventArgs e)
        {
            discoverAction();
        }

        private void tbtnAuto_Click(object sender, RibbonControlEventArgs e)
        {
            RegistryKey readReg;
            readReg = Registry.CurrentUser.OpenSubKey(globalOutlook.registryPath, true);
            if (readReg == null)
            {
                Registry.CurrentUser.CreateSubKey(globalOutlook.registryPath);
                readReg = Registry.CurrentUser.OpenSubKey(globalOutlook.registryPath, true);
            }

            if (tbtnAuto.Checked)
            {
                globalOutlook.boolAuto = true;
                readReg.SetValue("OUTLOOKAUTO", "true");
                tbtnAuto.Label = "Automatic On";
                discoverAction();
            }
            else
            {
                globalOutlook.boolAuto = false;
                readReg.SetValue("OUTLOOKAUTO", "false");
                tbtnAuto.Label = "Automatic Off";
            }
        }
    }
}
