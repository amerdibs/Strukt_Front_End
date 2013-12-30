using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace ProcScribeOutlook
{
    public partial class frmSearchResult : Form
    {
        public frmSearchResult()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmSearchResult_Load(object sender, EventArgs e)
        {
            foreach (TaskProcess tk in globalOutlook.taskProcessFoundList)
            {
                ListViewItem lvi = new ListViewItem(new String[] { tk.process_name, tk.name, tk.description, tk.keyword, tk.process_workflow_id });
                lvi.Tag = tk.id;
                listVSearchProcess.Items.Add(lvi);
            }
        }



        private void listVSearchProcess_MouseClick(object sender, MouseEventArgs e)
        {
            if (listVSearchProcess.SelectedItems != null)
            {
                ListViewItem lvi = listVSearchProcess.SelectedItems[0];
                Process p = new Process();
                p.StartInfo.FileName = globalOutlook.proscribePath;
                p.StartInfo.Arguments = globalOutlook.getValueFromStruktValue(lvi.SubItems[4].Text) + " " + globalOutlook.getValueFromStruktValue(lvi.Tag.ToString());
                MessageBox.Show(p.StartInfo.Arguments);
                p.StartInfo.UseShellExecute = false;
                p.StartInfo.RedirectStandardOutput = true;
                p.Start();
            }
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {

        }
    }
}
