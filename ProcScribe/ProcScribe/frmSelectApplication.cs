using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProcScribe
{
    public partial class frmSelectApplication : Form
    {
        public string strSelect { get; set; }

        public frmSelectApplication()
        {
            InitializeComponent();
        }

        private void frmSelectApplication_Load(object sender, EventArgs e)
        {

            foreach (DataRow dtRow in global.appTable.Rows)
            {
               lvAppList.Items.Add(new ListViewItem(new string[] { dtRow["app_name"].ToString()}));
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            strSelect = lvAppList.SelectedItems[0].Text;
            Hide();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}
