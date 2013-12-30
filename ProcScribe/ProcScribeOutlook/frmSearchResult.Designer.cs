namespace ProcScribeOutlook
{
    partial class frmSearchResult
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
            this.pnSelect = new System.Windows.Forms.Panel();
            this.listVSearchProcess = new System.Windows.Forms.ListView();
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pnCommand = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.pnSelect.SuspendLayout();
            this.pnCommand.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnSelect
            // 
            this.pnSelect.Controls.Add(this.listVSearchProcess);
            this.pnSelect.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnSelect.Location = new System.Drawing.Point(0, 0);
            this.pnSelect.Name = "pnSelect";
            this.pnSelect.Size = new System.Drawing.Size(508, 298);
            this.pnSelect.TabIndex = 0;
            // 
            // listVSearchProcess
            // 
            this.listVSearchProcess.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.listVSearchProcess.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listVSearchProcess.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader7,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader8});
            this.listVSearchProcess.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listVSearchProcess.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listVSearchProcess.FullRowSelect = true;
            this.listVSearchProcess.GridLines = true;
            this.listVSearchProcess.HotTracking = true;
            this.listVSearchProcess.HoverSelection = true;
            this.listVSearchProcess.Location = new System.Drawing.Point(0, 0);
            this.listVSearchProcess.MultiSelect = false;
            this.listVSearchProcess.Name = "listVSearchProcess";
            this.listVSearchProcess.Size = new System.Drawing.Size(508, 298);
            this.listVSearchProcess.TabIndex = 2;
            this.listVSearchProcess.UseCompatibleStateImageBehavior = false;
            this.listVSearchProcess.View = System.Windows.Forms.View.Details;
            this.listVSearchProcess.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listVSearchProcess_MouseClick);
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Process Name";
            this.columnHeader7.Width = 150;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Task Name";
            this.columnHeader4.Width = 250;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Description";
            this.columnHeader5.Width = 0;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Keyword";
            this.columnHeader6.Width = 100;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "WorkflowID";
            this.columnHeader8.Width = 0;
            // 
            // pnCommand
            // 
            this.pnCommand.Controls.Add(this.btnClose);
            this.pnCommand.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnCommand.Location = new System.Drawing.Point(0, 298);
            this.pnCommand.Name = "pnCommand";
            this.pnCommand.Size = new System.Drawing.Size(508, 36);
            this.pnCommand.TabIndex = 1;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(407, 6);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(89, 23);
            this.btnClose.TabIndex = 13;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmSearchResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 334);
            this.Controls.Add(this.pnCommand);
            this.Controls.Add(this.pnSelect);
            this.Name = "frmSearchResult";
            this.Text = "Select the task";
            this.Load += new System.EventHandler(this.frmSearchResult_Load);
            this.pnSelect.ResumeLayout(false);
            this.pnCommand.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnSelect;
        private System.Windows.Forms.Panel pnCommand;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ListView listVSearchProcess;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader8;
    }
}