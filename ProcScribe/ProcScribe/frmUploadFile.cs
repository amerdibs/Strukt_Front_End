using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;
using Newtonsoft.Json;
using ProcScribe.StruktWebservice;

namespace ProcScribe
{
    public partial class frmUploadFile : Form
    {
        public string strSelect { get; set; }
        public frmTaskEdit frmEdit;
        
        public frmUploadFile()
        {
            InitializeComponent();
        }

        public frmUploadFile(frmTaskEdit pfrmEdit)
        {
            InitializeComponent();
            frmEdit = pfrmEdit;
        }

        private void webBrowser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void frmUploadFile_Load(object sender, EventArgs e)
        {
            webBrowser.Url = new Uri(global.PathUploadFile);
            btnRefresh_Click(sender, e);
        }

        public static List<FileList> getFileListAll()
        {
            try
            {
                string strReturn = "";
                StruktMain.StruktMainSoapClient wsStrukt = new StruktMain.StruktMainSoapClient();
                strReturn = wsStrukt.getFileList();
                if (strReturn == null)
                    return null;
                List<FileList> lFile = new List<FileList>();
                lFile = JsonConvert.DeserializeObject<List<FileList>>(strReturn);
                return lFile;

            }
            catch (Exception e)
            {
                global.getExceptionThrow(e);
                throw e;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            List<FileList> lFile = new List<FileList>();
            lFile = getFileListAll();
            var items = listView1.Items;
            if (lFile != null)
            {
                foreach (FileList fileN in lFile)
                {
                    ListViewItem item = new ListViewItem(fileN.fileName);
                    item.SubItems.Add(fileN.fileSize);
                    item.SubItems.Add(fileN.fileCreatedDate);
                    listView1.Items.AddRange(new ListViewItem[] { item });
                }
            }
        }

        private void webBrowser_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            btnRefresh_Click(sender, e);
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems != null)
            {
                ListViewItem lvi = listView1.SelectedItems[0];
                frmEdit.taskUse.attachmentDetail = global.PathSharedFile + lvi.Text;
                frmEdit.Controls["groupBox2"].Controls["txtAddress"].Text = global.PathSharedFile + lvi.Text;
                Close();
            }
        }



    }
}
