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

namespace ProcScribeOutlook
{
    public partial class ThisAddIn
    {
        //String strIdentity;
        private void ThisAddIn_Startup(object sender, System.EventArgs e)
        {
            //strIdentity = Guid.NewGuid().ToString("N");
            globalOutlook.proscribeAddIn = this;
            
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
        }
        
        #endregion
    }
}
