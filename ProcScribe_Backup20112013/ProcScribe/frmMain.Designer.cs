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
            this.btnHide = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnOption = new System.Windows.Forms.Button();
            this.btnAddProcess = new System.Windows.Forms.Button();
            this.btnSaveProcessAs = new System.Windows.Forms.Button();
            this.btnLoadProcess = new System.Windows.Forms.Button();
            this.cbProcess = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabCenter = new System.Windows.Forms.TabControl();
            this.tpGuide = new System.Windows.Forms.TabPage();
            this.pnCenter = new System.Windows.Forms.Panel();
            this.tpSearch = new System.Windows.Forms.TabPage();
            this.pnSearch = new System.Windows.Forms.Panel();
            this.pnSearchResult = new System.Windows.Forms.Panel();
            this.listVSearch = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pnSearchTop = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.pnDesigner = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSubAdd = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsUserName = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsRole = new System.Windows.Forms.ToolStripStatusLabel();
            this.ctmTask = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addMainTaskToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addSubTaskToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteTaskToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.editNameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ttMainForm = new System.Windows.Forms.ToolTip(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnCenterBack = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabCenter.SuspendLayout();
            this.tpGuide.SuspendLayout();
            this.tpSearch.SuspendLayout();
            this.pnSearch.SuspendLayout();
            this.pnSearchResult.SuspendLayout();
            this.pnSearchTop.SuspendLayout();
            this.pnDesigner.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.ctmTask.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.264464F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 91.73553F));
            this.tableLayoutPanel1.Controls.Add(this.btnHide, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tabCenter, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.pnDesigner, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 108);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 88F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(384, 471);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btnHide
            // 
            this.btnHide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHide.Image = global::ProcScribe.Properties.Resources.bt_skip_sw;
            this.btnHide.Location = new System.Drawing.Point(3, 3);
            this.btnHide.Name = "btnHide";
            this.btnHide.Size = new System.Drawing.Size(23, 26);
            this.btnHide.TabIndex = 9;
            this.ttMainForm.SetToolTip(this.btnHide, "Hide Application");
            this.btnHide.UseVisualStyleBackColor = true;
            this.btnHide.Click += new System.EventHandler(this.btnHide_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.btnAddProcess);
            this.panel2.Controls.Add(this.btnSaveProcessAs);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(34, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(347, 26);
            this.panel2.TabIndex = 2;
            // 
            // btnOption
            // 
            this.btnOption.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOption.Image = global::ProcScribe.Properties.Resources.applications;
            this.btnOption.Location = new System.Drawing.Point(343, 0);
            this.btnOption.Name = "btnOption";
            this.btnOption.Size = new System.Drawing.Size(41, 21);
            this.btnOption.TabIndex = 8;
            this.ttMainForm.SetToolTip(this.btnOption, "Settings");
            this.btnOption.UseVisualStyleBackColor = true;
            this.btnOption.Click += new System.EventHandler(this.btnOption_Click);
            // 
            // btnAddProcess
            // 
            this.btnAddProcess.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddProcess.Location = new System.Drawing.Point(474, 8);
            this.btnAddProcess.Name = "btnAddProcess";
            this.btnAddProcess.Size = new System.Drawing.Size(40, 21);
            this.btnAddProcess.TabIndex = 4;
            this.btnAddProcess.Text = "New";
            this.btnAddProcess.UseVisualStyleBackColor = true;
            this.btnAddProcess.Visible = false;
            this.btnAddProcess.Click += new System.EventHandler(this.btnAddProcess_Click);
            // 
            // btnSaveProcessAs
            // 
            this.btnSaveProcessAs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveProcessAs.Image = global::ProcScribe.Properties.Resources.save;
            this.btnSaveProcessAs.Location = new System.Drawing.Point(426, 7);
            this.btnSaveProcessAs.Name = "btnSaveProcessAs";
            this.btnSaveProcessAs.Size = new System.Drawing.Size(28, 21);
            this.btnSaveProcessAs.TabIndex = 3;
            this.btnSaveProcessAs.UseVisualStyleBackColor = true;
            this.btnSaveProcessAs.Visible = false;
            this.btnSaveProcessAs.Click += new System.EventHandler(this.btnSaveProcessAs_Click);
            // 
            // btnLoadProcess
            // 
            this.btnLoadProcess.BackColor = System.Drawing.Color.Transparent;
            this.btnLoadProcess.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoadProcess.Image = global::ProcScribe.Properties.Resources.down1;
            this.btnLoadProcess.Location = new System.Drawing.Point(237, 3);
            this.btnLoadProcess.Name = "btnLoadProcess";
            this.btnLoadProcess.Size = new System.Drawing.Size(42, 21);
            this.btnLoadProcess.TabIndex = 2;
            this.ttMainForm.SetToolTip(this.btnLoadProcess, "Load");
            this.btnLoadProcess.UseVisualStyleBackColor = false;
            this.btnLoadProcess.Click += new System.EventHandler(this.btnLoadProcess_Click);
            // 
            // cbProcess
            // 
            this.cbProcess.AccessibleName = "";
            this.cbProcess.FormattingEnabled = true;
            this.cbProcess.Items.AddRange(new object[] {
            "910664516",
            "2036565491"});
            this.cbProcess.Location = new System.Drawing.Point(60, 3);
            this.cbProcess.Name = "cbProcess";
            this.cbProcess.Size = new System.Drawing.Size(172, 21);
            this.cbProcess.TabIndex = 1;
            this.cbProcess.Text = "‏Search for Processes...";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Process";
            // 
            // tabCenter
            // 
            this.tabCenter.Controls.Add(this.tpGuide);
            this.tabCenter.Controls.Add(this.tpSearch);
            this.tabCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabCenter.Location = new System.Drawing.Point(34, 35);
            this.tabCenter.Name = "tabCenter";
            this.tabCenter.SelectedIndex = 0;
            this.tabCenter.Size = new System.Drawing.Size(347, 408);
            this.tabCenter.TabIndex = 3;
            this.tabCenter.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabCenter_Selected);
            // 
            // tpGuide
            // 
            this.tpGuide.Controls.Add(this.pnCenter);
            this.tpGuide.Location = new System.Drawing.Point(4, 22);
            this.tpGuide.Name = "tpGuide";
            this.tpGuide.Padding = new System.Windows.Forms.Padding(3);
            this.tpGuide.Size = new System.Drawing.Size(339, 382);
            this.tpGuide.TabIndex = 0;
            this.tpGuide.Text = "Guide";
            this.tpGuide.UseVisualStyleBackColor = true;
            // 
            // pnCenter
            // 
            this.pnCenter.AllowDrop = true;
            this.pnCenter.AutoScroll = true;
            this.pnCenter.BackColor = System.Drawing.Color.Transparent;
            this.pnCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnCenter.Location = new System.Drawing.Point(3, 3);
            this.pnCenter.Name = "pnCenter";
            this.pnCenter.Size = new System.Drawing.Size(333, 376);
            this.pnCenter.TabIndex = 4;
            this.pnCenter.DragDrop += new System.Windows.Forms.DragEventHandler(this.pnCenter_DragDrop);
            this.pnCenter.DragEnter += new System.Windows.Forms.DragEventHandler(this.pnCenter_DragEnter);
            this.pnCenter.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnCenter_MouseDown);
            // 
            // tpSearch
            // 
            this.tpSearch.Controls.Add(this.pnSearch);
            this.tpSearch.Location = new System.Drawing.Point(4, 22);
            this.tpSearch.Name = "tpSearch";
            this.tpSearch.Padding = new System.Windows.Forms.Padding(3);
            this.tpSearch.Size = new System.Drawing.Size(339, 375);
            this.tpSearch.TabIndex = 1;
            this.tpSearch.Text = "Search";
            this.tpSearch.UseVisualStyleBackColor = true;
            // 
            // pnSearch
            // 
            this.pnSearch.Controls.Add(this.pnSearchResult);
            this.pnSearch.Controls.Add(this.pnSearchTop);
            this.pnSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnSearch.Location = new System.Drawing.Point(3, 3);
            this.pnSearch.Name = "pnSearch";
            this.pnSearch.Size = new System.Drawing.Size(333, 369);
            this.pnSearch.TabIndex = 0;
            // 
            // pnSearchResult
            // 
            this.pnSearchResult.AutoScroll = true;
            this.pnSearchResult.Controls.Add(this.listVSearch);
            this.pnSearchResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnSearchResult.Location = new System.Drawing.Point(0, 41);
            this.pnSearchResult.Name = "pnSearchResult";
            this.pnSearchResult.Size = new System.Drawing.Size(333, 328);
            this.pnSearchResult.TabIndex = 1;
            // 
            // listVSearch
            // 
            this.listVSearch.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.listVSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listVSearch.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listVSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listVSearch.FullRowSelect = true;
            this.listVSearch.GridLines = true;
            this.listVSearch.HotTracking = true;
            this.listVSearch.HoverSelection = true;
            this.listVSearch.Location = new System.Drawing.Point(0, 0);
            this.listVSearch.MultiSelect = false;
            this.listVSearch.Name = "listVSearch";
            this.listVSearch.Size = new System.Drawing.Size(333, 328);
            this.listVSearch.TabIndex = 0;
            this.listVSearch.UseCompatibleStateImageBehavior = false;
            this.listVSearch.View = System.Windows.Forms.View.Details;
            this.listVSearch.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listVSearch_MouseClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Name";
            this.columnHeader1.Width = 139;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Description";
            this.columnHeader2.Width = 127;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Keyword";
            // 
            // pnSearchTop
            // 
            this.pnSearchTop.Controls.Add(this.btnSearch);
            this.pnSearchTop.Controls.Add(this.txtSearch);
            this.pnSearchTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnSearchTop.Location = new System.Drawing.Point(0, 0);
            this.pnSearchTop.Name = "pnSearchTop";
            this.pnSearchTop.Size = new System.Drawing.Size(333, 41);
            this.pnSearchTop.TabIndex = 0;
            // 
            // btnSearch
            // 
            this.btnSearch.Image = global::ProcScribe.Properties.Resources.file_find;
            this.btnSearch.Location = new System.Drawing.Point(225, 9);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(42, 21);
            this.btnSearch.TabIndex = 12;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(9, 9);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(210, 20);
            this.txtSearch.TabIndex = 11;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // pnDesigner
            // 
            this.pnDesigner.AccessibleDescription = "";
            this.pnDesigner.Controls.Add(this.btnDelete);
            this.pnDesigner.Controls.Add(this.btnSubAdd);
            this.pnDesigner.Controls.Add(this.btnAdd);
            this.pnDesigner.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnDesigner.Location = new System.Drawing.Point(3, 35);
            this.pnDesigner.Name = "pnDesigner";
            this.pnDesigner.Size = new System.Drawing.Size(25, 408);
            this.pnDesigner.TabIndex = 3;
            // 
            // btnDelete
            // 
            this.btnDelete.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Image = global::ProcScribe.Properties.Resources.trash;
            this.btnDelete.Location = new System.Drawing.Point(0, 44);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(25, 22);
            this.btnDelete.TabIndex = 7;
            this.ttMainForm.SetToolTip(this.btnDelete, "Delete Task");
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
            this.btnSubAdd.Size = new System.Drawing.Size(25, 22);
            this.btnSubAdd.TabIndex = 6;
            this.ttMainForm.SetToolTip(this.btnSubAdd, "Add Sub Task");
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
            this.btnAdd.Size = new System.Drawing.Size(25, 22);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Tag = "";
            this.ttMainForm.SetToolTip(this.btnAdd, "Add Task");
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.Transparent;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsUserName,
            this.tsRole});
            this.statusStrip1.Location = new System.Drawing.Point(0, 579);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(384, 22);
            this.statusStrip1.TabIndex = 1;
            // 
            // tsUserName
            // 
            this.tsUserName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsUserName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tsUserName.Name = "tsUserName";
            this.tsUserName.Size = new System.Drawing.Size(87, 17);
            this.tsUserName.Text = "No User Log-In";
            // 
            // tsRole
            // 
            this.tsRole.ForeColor = System.Drawing.Color.SteelBlue;
            this.tsRole.Name = "tsRole";
            this.tsRole.Size = new System.Drawing.Size(30, 17);
            this.tsRole.Text = "Role";
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
            // panel1
            // 
            this.panel1.Controls.Add(this.btnOption);
            this.panel1.Controls.Add(this.cbProcess);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnLoadProcess);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(384, 24);
            this.panel1.TabIndex = 2;
            // 
            // pnCenterBack
            // 
            this.pnCenterBack.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnCenterBack.Location = new System.Drawing.Point(0, 24);
            this.pnCenterBack.Name = "pnCenterBack";
            this.pnCenterBack.Size = new System.Drawing.Size(384, 100);
            this.pnCenterBack.TabIndex = 3;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 601);
            this.Controls.Add(this.pnCenterBack);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.statusStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProcScribe - Easy User Guidance";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.frmMain_Paint);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.tabCenter.ResumeLayout(false);
            this.tpGuide.ResumeLayout(false);
            this.tpSearch.ResumeLayout(false);
            this.pnSearch.ResumeLayout(false);
            this.pnSearchResult.ResumeLayout(false);
            this.pnSearchTop.ResumeLayout(false);
            this.pnSearchTop.PerformLayout();
            this.pnDesigner.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ctmTask.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        private System.Windows.Forms.Button btnOption;
        private System.Windows.Forms.TabControl tabCenter;
        private System.Windows.Forms.TabPage tpGuide;
        private System.Windows.Forms.TabPage tpSearch;
        private System.Windows.Forms.ToolStripStatusLabel tsRole;
        private System.Windows.Forms.Panel pnSearch;
        private System.Windows.Forms.Panel pnSearchTop;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Panel pnSearchResult;
        private System.Windows.Forms.ListView listVSearch;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnCenterBack;
    }
}

