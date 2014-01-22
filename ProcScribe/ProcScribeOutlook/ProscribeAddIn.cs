using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using Outlook = Microsoft.Office.Interop.Outlook;
using Office = Microsoft.Office.Core;
using System.Windows.Forms;
using System.Data;
using System.Drawing;
using Microsoft.Win32;

namespace ProcScribeOutlook
{
    public partial class ThisAddIn
    {
       
        //String strIdentity;
        private void ThisAddIn_Startup(object sender, System.EventArgs e)
        {
            //strIdentity = Guid.NewGuid().ToString("N");
            globalOutlook.proscribeAddIn = this;
            RegistryKey readReg;
            readReg = Registry.CurrentUser.OpenSubKey(globalOutlook.registryPath, true);
            if (readReg == null)
            {
                Registry.CurrentUser.CreateSubKey(globalOutlook.registryPath);
                readReg = Registry.CurrentUser.OpenSubKey(globalOutlook.registryPath, true);
            }
            if (readReg.GetValue("PROSCRIBEPATH") == null)
            {
                try
                {
                    RegistryKey key = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Uninstall");
                    string regfilepath = "";
                    if (key != null)       // Make sure there are Assemblies
                    {
                        foreach (string Keyname in key.GetSubKeyNames())
                        {
                            RegistryKey keySub = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Uninstall\\" + Keyname);
                            String strVal = keySub.GetValue("DisplayName", -1, RegistryValueOptions.None).ToString();
                            if (strVal != "-1")
                            {
                                if (strVal == "Proscribe")
                                {
                                    regfilepath = keySub.GetValue("InstallLocation").ToString();
                                }
                            }
                        }
                    }
                    readReg.SetValue("PROSCRIBEPATH", regfilepath + "ProcScribe.exe");
                }
                catch (Exception)
                {
                    throw;
                }
                
            }

            globalOutlook.proscribePath = readReg.GetValue("PROSCRIBEPATH").ToString();

            
            //MessageBox.Show(strIdentity);
            //MessageBox.Show(String.Format("There are {0} inspectors and {1} exploeres open.", this.Application.Inspectors.Count, this.Application.Explorers.Count));
        }

        private void ThisAddIn_Shutdown(object sender, System.EventArgs e)
        {
        }

        #region VSTO generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InternalStartup()
        {
            this.Startup += new System.EventHandler(ThisAddIn_Startup);
            this.Shutdown += new System.EventHandler(ThisAddIn_Shutdown);
            //this.Application.Inspectors.NewInspector += Inspectors_NewInspector;
            this.Application.ItemLoad += Application_ItemLoad;
            
            //this.Application.Inspectors.NewInspector += Outlook.InspectorsEvents(ThisAddIn_NewInspector);
            //this.Application.Inspectors.NewInspector += new System.EventHandler(ThisAddIn_NewInspector);
            //this.Application.Inspectors.NewInspector += new Outlook.InspectorEvents_NewInspectorEventHandler(ThisAddIn_NewInspector);
        }

        void Application_ItemLoad(object Item)
        {
            //MessageBox.Show("yyy");
            if (globalOutlook.boolAuto)
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
            
            throw new NotImplementedException();
        }

        //private void Inspectors_NewInspector(Outlook.Inspector Inspector)
        //{
        //    MessageBox.Show("xxx");
        //    throw new NotImplementedException();
        //}



        #endregion
    }
}
