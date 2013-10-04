namespace ProcScribe
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pnCenter = new System.Windows.Forms.Panel();
            this.btnHide = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnAddProcess = new System.Windows.Forms.Button();
            this.btnSaveProcessAs = new System.Windows.Forms.Button();
            this.btnLoadProcess = new System.Windows.Forms.Button();
            this.cbProcess = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnDesigner = new System.Windows.Forms.Panel();
            this.btnOption = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSubAdd = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsUserName = new System.Windows.Forms.ToolStripStatusLabel();
            this.ctmTask = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addMainTaskToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addSubTaskToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteTaskToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.editNameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ttMainForm = new System.Windows.Forms.ToolTip(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnDesigner.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.ctmTask.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.264462F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 91.73553F));
            this.tableLayoutPanel1.Controls.Add(this.pnCenter, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnHide, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.pnDesigner, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.923664F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90.07633F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(395, 579);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // pnCenter
            // 
            this.pnCenter.AllowDrop = true;
            this.pnCenter.AutoScroll = true;
            this.pnCenter.BackColor = System.Drawing.Color.Transparent;
            this.pnCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnCenter.Location = new System.Drawing.Point(35, 60);
            this.pnCenter.Name = "pnCenter";
            this.pnCenter.Size = new System.Drawing.Size(357, 516);
            this.pnCenter.TabIndex = 0;
            this.pnCenter.DragDrop += new System.Windows.Forms.DragEventHandler(this.pnCenter_DragDrop);
            this.pnCenter.DragEnter += new System.Windows.Forms.DragEventHandler(this.pnCenter_DragEnter);
            this.pnCenter.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnCenter_MouseDown);
            // 
            // btnHide
            // 
            this.btnHide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHide.Image = global::ProcScribe.Properties.Resources.bt_skip_sw;
            this.btnHide.Location = new System.Drawing.Point(3, 3);
            this.btnHide.Name = "btnHide";
            this.btnHide.Size = new System.Drawing.Size(23, 45);
            this.btnHide.TabIndex = 1;
            this.btnHide.UseVisualStyleBackColor = true;
            this.btnHide.Click += new System.EventHandler(this.btnHide_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.btnAddProcess);
            this.panel2.Controls.Add(this.btnSaveProcessAs);
            this.panel2.Controls.Add(this.btnLoadProcess);
            this.panel2.Controls.Add(this.cbProcess);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(35, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(357, 51);
            this.panel2.TabIndex = 2;
            // 
            // btnAddProcess
            // 
            this.btnAddProcess.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddProcess.Image = global::ProcScribe.Properties.Resources.add1;
            this.btnAddProcess.Location = new System.Drawing.Point(322, 8);
            this.btnAddProcess.Name = "btnAddProcess";
            this.btnAddProcess.Size = new System.Drawing.Size(28, 23);
            this.btnAddProcess.TabIndex = 4;
            this.btnAddProcess.UseVisualStyleBackColor = true;
            this.btnAddProcess.Visible = false;
            this.btnAddProcess.Click += new System.EventHandler(this.btnAddProcess_Click);
            // 
            // btnSaveProcessAs
            // 
            this.btnSaveProcessAs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveProcessAs.Image = global::ProcScribe.Properties.Resources.save;
            this.btnSaveProcessAs.Location = new System.Drawing.Point(294, 8);
            this.btnSaveProcessAs.Name = "btnSaveProcessAs";
            this.btnSaveProcessAs.Size = new System.Drawing.Size(28, 23);
            this.btnSaveProcessAs.TabIndex = 3;
            this.btnSaveProcessAs.UseVisualStyleBackColor = true;
            this.btnSaveProcessAs.Visible = false;
            this.btnSaveProcessAs.Click += new System.EventHandler(this.btnSaveProcessAs_Click);
            // 
            // btnLoadProcess
            // 
            this.btnLoadProcess.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoadProcess.Image = global::ProcScribe.Properties.Resources.down1;
            this.btnLoadProcess.Location = new System.Drawing.Point(266, 8);
            this.btnLoadProcess.Name = "btnLoadProcess";
            this.btnLoadProcess.Size = new System.Drawing.Size(28, 23);
            this.btnLoadProcess.TabIndex = 2;
            this.btnLoadProcess.UseVisualStyleBackColor = true;
            this.btnLoadProcess.Click += new System.EventHandler(this.btnLoadProcess_Click);
            // 
            // cbProcess
            // 
            this.cbProcess.FormattingEnabled = true;
            this.cbProcess.Items.AddRange(new object[] {
            "910664516",
            "2036565491"});
            this.cbProcess.Location = new System.Drawing.Point(54, 9);
            this.cbProcess.Name = "cbProcess";
            this.cbProcess.Size = new System.Drawing.Size(210, 21);
            this.cbProcess.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Process";
            // 
            // pnDesigner
            // 
            this.pnDesigner.Controls.Add(this.btnOption);
            this.pnDesigner.Controls.Add(this.btnDelete);
            this.pnDesigner.Controls.Add(this.btnSubAdd);
            this.pnDesigner.Controls.Add(this.btnAdd);
            this.pnDesigner.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnDesigner.Location = new System.Drawing.Point(3, 60);
            this.pnDesigner.Name = "pnDesigner";
            this.pnDesigner.Size = new System.Drawing.Size(26, 516);
            this.pnDesigner.TabIndex = 3;
            // 
            // btnOption
            // 
            this.btnOption.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnOption.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOption.Image = global::ProcScribe.Properties.Resources.applications;
            this.btnOption.Location = new System.Drawing.Point(0, 66);
            this.btnOption.Name = "btnOption";
            this.btnOption.Size = new System.Drawing.Size(26, 22);
            this.btnOption.TabIndex = 7;
            this.btnOption.UseVisualStyleBackColor = true;
            this.btnOption.Click += new System.EventHandler(this.btnOption_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Image = global::ProcScribe.Properties.Resources.trash;
            this.btnDelete.Location = new System.Drawing.Point(0, 44);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(26, 22);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSubAdd
            // 
            this.btnSubAdd.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSubAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubAdd.Image = global::ProcScribe.Properties.Resources.new_child;
            this.btnSubAdd.Location = new System.Drawing.Point(0, 22);
            this.btnSubAdd.Name = "btnSubAdd";
            this.btnSubAdd.Size = new System.Drawing.Size(26, 22);
            this.btnSubAdd.TabIndex = 6;
            this.btnSubAdd.UseVisualStyleBackColor = true;
            this.btnSubAdd.Click += new System.EventHandler(this.btnSubAdd_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Image = global::ProcScribe.Properties.Resources.add;
            this.btnAdd.Location = new System.Drawing.Point(0, 0);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(26, 22);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Tag = "";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.Transparent;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsUserName});
            this.statusStrip1.Location = new System.Drawing.Point(0, 579);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(395, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tsUserName
            // 
            this.tsUserName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.tsUserName.ForeColor = System.Drawing.Color.Blue;
            this.tsUserName.Name = "tsUserName";
            this.tsUserName.Size = new System.Drawing.Size(91, 17);
            this.tsUserName.Text = "No User Log-In";
            // 
            // ctmTask
            // 
            this.ctmTask.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addMainTaskToolStripMenuItem,
            this.addSubTaskToolStripMenuItem,
            this.deleteTaskToolStripMenuItem,
            this.toolStripSeparator1,
            this.editNameToolStripMenuItem});
            this.ctmTask.Name = "ctmTask";
            this.ctmTask.Size = new System.Drawing.Size(155, 98);
            // 
            // addMainTaskToolStripMenuItem
            // 
            this.addMainTaskToolStripMenuItem.Name = "addMainTaskToolStripMenuItem";
            this.addMainTaskToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.addMainTaskToolStripMenuItem.Text = "Add Task";
            this.addMainTaskToolStripMenuItem.Click += new System.EventHandler(this.addMainTaskToolStripMenuItem_Click);
            // 
            // addSubTaskToolStripMenuItem
            // 
            this.addSubTaskToolStripMenuItem.Name = "addSubTaskToolStripMenuItem";
            this.addSubTaskToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.addSubTaskToolStripMenuItem.Text = "Add Child Task";
            this.addSubTaskToolStripMenuItem.Click += new System.EventHandler(this.addSubTaskToolStripMenuItem_Click);
            // 
            // deleteTaskToolStripMenuItem
            // 
            this.deleteTaskToolStripMenuItem.Name = "deleteTaskToolStripMenuItem";
            this.deleteTaskToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.deleteTaskToolStripMenuItem.Text = "Delete Task";
            this.deleteTaskToolStripMenuItem.Click += new System.EventHandler(this.deleteTaskToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(151, 6);
            // 
            // editNameToolStripMenuItem
            // 
            this.editNameToolStripMenuItem.Name = "editNameToolStripMenuItem";
            this.editNameToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.editNameToolStripMenuItem.Text = "Edit Name";
            this.editNameToolStripMenuItem.Click += new System.EventHandler(this.editNameToolStripMenuItem_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 601);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.statusStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProcScribe";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.frmMain_Paint);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pnDesigner.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ctmTask.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel pnCenter;
        private System.Windows.Forms.Button btnHide;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnLoadProcess;
        private System.Windows.Forms.ComboBox cbProcess;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Panel pnDesigner;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSubAdd;
        private System.Windows.Forms.Button btnOption;
        private System.Windows.Forms.Button btnSaveProcessAs;
        private System.Windows.Forms.ContextMenuStrip ctmTask;
        private System.Windows.Forms.ToolStripMenuItem addMainTaskToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addSubTaskToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteTaskToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editNameToolStripMenuItem;
        private System.Windows.Forms.Button btnAddProcess;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripStatusLabel tsUserName;
        private System.Windows.Forms.ToolTip ttMainForm;
    }
}

