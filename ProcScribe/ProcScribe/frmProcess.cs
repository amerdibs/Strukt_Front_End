using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace ProcScribe
{
    public partial class frmProcess : Form
    {
        public String formMode;
        private frmMain frmParent;
        public Boolean boolOK = false;
        public String strWorkflowID;

        public frmProcess()
        {
            InitializeComponent();
        }

        public frmProcess(frmMain fMain)
        {
            InitializeComponent();
            frmParent = fMain;
        }

        private void btn_process_Click(object sender, EventArgs e)
        {
            if (formMode == "N")
            {
                StruktMain.StruktMainSoapClient wsStrukt = new StruktMain.StruktMainSoapClient();
                String strReturn = wsStrukt.addStruktProcess(txtProcessName.Text);
                StruktProcess strkP = JsonConvert.DeserializeObject<StruktProcess>(strReturn);
                strWorkflowID = strkP.workflowID;
            }
            else if (formMode == "E")
            {
                StruktMain.StruktMainSoapClient wsStrukt = new StruktMain.StruktMainSoapClient();

                String strReturn = wsStrukt.editStruktProcessName(global.processID, txtProcessName.Text);
                StruktProcess strkP = JsonConvert.DeserializeObject<StruktProcess>(strReturn);
                strWorkflowID = strkP.workflowID;

            }

            boolOK = true;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
