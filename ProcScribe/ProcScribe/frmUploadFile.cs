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

namespace ProcScribe
{
    public partial class frmUploadFile : Form
    {
        public string strSelect { get; set; }
        private string URL = "http://www.pakorn.somee.com/strukthelp/upload/";
        private string localFilePath = @"C:\Users\SvenLaptop\Documents\GitHub\Strukt_Front_End\ProcScribe\FileFolderTest\";
        
        public frmUploadFile()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            /*DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK) // Test result.
            {
                textBox1.Text = openFileDialog1.FileName;
            }
            textBox1.Text = openFileDialog1.SafeFileName;*/
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*using (WebClient client = new WebClient())
            {
                client.UploadFile(URL, localFilePath);
            }*/
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void webBrowser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void frmUploadFile_Load(object sender, EventArgs e)
        {
            List<FileList> lFile = new List<FileList>();
            lFile = getFileListAll();
            if (lFile != null)
            {
                foreach (FileList fileN in lFile)
                {
                    //MessageBox.Show(fileN.fileName);
                    //MessageBox.Show(fileN.fileSize);
                    //MessageBox.Show(fileN.fileCreatedDate);
                }
            }
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
    }
}
