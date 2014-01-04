﻿using System;
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

namespace ProcScribe
{
    public partial class frmUploadFile : Form
    {
        public string strSelect { get; set; }
        private string URL = "http://www.pakorn.somee.com/strukthelp/upload/";
        private string localFilePath = @"C:\Users\SvenLaptop\Documents\GitHub\Strukt_Front_End\ProcScribe\FileFolderTest\TeamViewer_Setup_de.exe";
        public frmUploadFile()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK) // Test result.
            {
                textBox1.Text = openFileDialog1.FileName;
            }
            textBox1.Text = openFileDialog1.SafeFileName;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (WebClient client = new WebClient())
            {
                client.UploadFile(URL, localFilePath);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }
      
    }
}
