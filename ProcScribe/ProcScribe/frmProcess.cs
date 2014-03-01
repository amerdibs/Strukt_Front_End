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
            if (txtProcessName.Text.Trim() == "")
            {
                DialogResult = DialogResult.None;
                MessageBox.Show("Please input process name!", "Error Message");
                return;
            }




            if (formMode == "N")
            {
                global.taskProcessListSearch = TaskProcess.getTaskProcessAll();
                //Find process name duplication
                var VStr = from objTask in global.taskProcessListSearch
                            where (objTask.process_name.ToLower().Equals(txtProcessName.Text.ToLower()))
                            select new { objTask.process_name, objTask.process_workflow_id };
                if (VStr != null)
                {
                    int iCount = 0;
                    foreach (var tk in VStr.GroupBy(x => x.process_name).Select(y => y.First()))
                    {
                        iCount++;
                    }
                    if (iCount > 0)
                    {
                        MessageBox.Show("Please change the process name. This name exists in system.");
                        return;
                    }
                }

                StruktMain.StruktMainSoapClient wsStrukt = new StruktMain.StruktMainSoapClient();
                String strReturn = wsStrukt.addStruktProcess(txtProcessName.Text);
                StruktProcess strkP = JsonConvert.DeserializeObject<StruktProcess>(strReturn);
                strWorkflowID = strkP.workflowID;
            }
            else if (formMode == "E")
            {
                global.taskProcessListSearch = TaskProcess.getTaskProcessAll();

                //Find process name duplication
                var VStr = from objTask in global.taskProcessListSearch
                            where (objTask.process_name.ToLower().Equals(txtProcessName.Text.ToLower()))
                            select new { objTask.process_name, objTask.process_workflow_id };
                if (VStr != null)
                {
                    int iCount = 0;
                    foreach (var tk in VStr.GroupBy(x => x.process_name).Select(y => y.First()))
                    {
                        iCount++;
                    }
                    if (iCount > 0)
                    {
                        MessageBox.Show("Please change the process name. This name exists in system or was not changed.");
                        return;
                    }
                }

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
