namespace ProcScribe
{
    partial class frmProcess
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblprocessName = new System.Windows.Forms.Label();
            this.txt_processName = new System.Windows.Forms.TextBox();
            this.btn_process = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblprocessName
            // 
            this.lblprocessName.AutoSize = true;
            this.lblprocessName.Location = new System.Drawing.Point(26, 39);
            this.lblprocessName.Name = "lblprocessName";
            this.lblprocessName.Size = new System.Drawing.Size(74, 13);
            this.lblprocessName.TabIndex = 0;
            this.lblprocessName.Text = "Process name";
            // 
            // txt_processName
            // 
            this.txt_processName.Location = new System.Drawing.Point(107, 36);
            this.txt_processName.Name = "txt_processName";
            this.txt_processName.Size = new System.Drawing.Size(255, 20);
            this.txt_processName.TabIndex = 1;
            // 
            // btn_process
            // 
            this.btn_process.Location = new System.Drawing.Point(173, 72);
            this.btn_process.Name = "btn_process";
            this.btn_process.Size = new System.Drawing.Size(75, 23);
            this.btn_process.TabIndex = 2;
            this.btn_process.Text = "OK";
            this.btn_process.UseVisualStyleBackColor = true;
            this.btn_process.Click += new System.EventHandler(this.btn_process_Click);
            // 
            // frmProcess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 120);
            this.Controls.Add(this.btn_process);
            this.Controls.Add(this.txt_processName);
            this.Controls.Add(this.lblprocessName);
            this.Name = "frmProcess";
            this.Text = "frmProcess";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblprocessName;
        private System.Windows.Forms.TextBox txt_processName;
        private System.Windows.Forms.Button btn_process;
    }
}