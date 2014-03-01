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
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSubAdd = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnOption = new System.Windows.Forms.Button();
            this.btnLoadProcess = new System.Windows.Forms.Button();
            this.cbProcess = new System.Windows.Forms.ComboBox();
            this.tabCenter = new System.Windows.Forms.TabControl();
            this.tpGuide = new System.Windows.Forms.TabPage();
            this.pnCenter = new System.Windows.Forms.Panel();
            this.pnCenterHead = new System.Windows.Forms.Panel();
            this.lbProcessHead = new System.Windows.Forms.Label();
            this.lbProcess = new System.Windows.Forms.Label();
            this.tpSearch = new System.Windows.Forms.TabPage();
            this.pnSearch = new System.Windows.Forms.Panel();
            this.pnSearchResult = new System.Windows.Forms.Panel();
            this.listVSearchProcessName = new System.Windows.Forms.ListView();
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listVSearchProcess = new System.Windows.Forms.ListView();
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listVSearch = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pnSearchTop = new System.Windows.Forms.Panel();
            this.rbAllProcess = new System.Windows.Forms.RadioButton();
            this.rbInProcess = new System.Windows.Forms.RadioButton();
            this.rbOnlyProcess = new System.Windows.Forms.RadioButton();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsUserName = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsRole = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.ctmTask = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addMainTaskToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addSubTaskToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteTaskToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.editNameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ttMainForm = new System.Windows.Forms.ToolTip(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnDesigner = new System.Windows.Forms.Panel();
            this.btnDeleteProcess = new System.Windows.Forms.Button();
            this.btn_modifyProcess = new System.Windows.Forms.Button();
            this.btn_createProcess = new System.Windows.Forms.Button();
            this.tabCenter.SuspendLayout();
            this.tpGuide.SuspendLayout();
            this.pnCenterHead.SuspendLayout();
            this.tpSearch.SuspendLayout();
            this.pnSearch.SuspendLayout();
            this.pnSearchResult.SuspendLayout();
            this.pnSearchTop.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.ctmTask.SuspendLayout();
            this.pnDesigner.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Image = global::ProcScribe.Properties.Resources.trash;
            this.btnDelete.Location = new System.Drawing.Point(359, 0);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(25, 22);
            this.btnDelete.TabIndex = 7;
            this.ttMainForm.SetToolTip(this.btnDelete, "Delete Task");
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSubAdd
            // 
            this.btnSubAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSubAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubAdd.Image = global::ProcScribe.Properties.Resources.new_child;
            this.btnSubAdd.Location = new System.Drawing.Point(334, 0);
            this.btnSubAdd.Name = "btnSubAdd";
            this.btnSubAdd.Size = new System.Drawing.Size(25, 22);
            this.btnSubAdd.TabIndex = 6;
            this.ttMainForm.SetToolTip(this.btnSubAdd, "Add Sub Task");
            this.btnSubAdd.UseVisualStyleBackColor = true;
            this.btnSubAdd.Click += new System.EventHandler(this.btnSubAdd_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Image = global::ProcScribe.Properties.Resources.add;
            this.btnAdd.Location = new System.Drawing.Point(309, 0);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(25, 22);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Tag = "";
            this.ttMainForm.SetToolTip(this.btnAdd, "Add Task");
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnOption
            // 
            this.btnOption.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOption.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOption.Image = global::ProcScribe.Properties.Resources.applications;
            this.btnOption.Location = new System.Drawing.Point(342, 0);
            this.btnOption.Name = "btnOption";
            this.btnOption.Size = new System.Drawing.Size(41, 19);
            this.btnOption.TabIndex = 8;
            this.ttMainForm.SetToolTip(this.btnOption, "Settings");
            this.btnOption.UseVisualStyleBackColor = true;
            this.btnOption.Click += new System.EventHandler(this.btnOption_Click);
            // 
            // btnLoadProcess
            // 
            this.btnLoadProcess.BackColor = System.Drawing.Color.Transparent;
            this.btnLoadProcess.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoadProcess.Image = global::ProcScribe.Properties.Resources.down1;
            this.btnLoadProcess.Location = new System.Drawing.Point(323, 4);
            this.btnLoadProcess.Name = "btnLoadProcess";
            this.btnLoadProcess.Size = new System.Drawing.Size(42, 21);
            this.btnLoadProcess.TabIndex = 2;
            this.ttMainForm.SetToolTip(this.btnLoadProcess, "Load");
            this.btnLoadProcess.UseVisualStyleBackColor = false;
            this.btnLoadProcess.Visible = false;
            this.btnLoadProcess.Click += new System.EventHandler(this.btnLoadProcess_Click);
            // 
            // cbProcess
            // 
            this.cbProcess.AccessibleName = "";
            this.cbProcess.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProcess.FormattingEnabled = true;
            this.cbProcess.Items.AddRange(new object[] {
            "910664516",
            "2036565491"});
            this.cbProcess.Location = new System.Drawing.Point(178, 4);
            this.cbProcess.Name = "cbProcess";
            this.cbProcess.Size = new System.Drawing.Size(139, 21);
            this.cbProcess.TabIndex = 1;
            this.cbProcess.Visible = false;
            // 
            // tabCenter
            // 
            this.tabCenter.Controls.Add(this.tpGuide);
            this.tabCenter.Controls.Add(this.tpSearch);
            this.tabCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabCenter.Location = new System.Drawing.Point(0, 12);
            this.tabCenter.Name = "tabCenter";
            this.tabCenter.SelectedIndex = 0;
            this.tabCenter.Size = new System.Drawing.Size(384, 543);
            this.tabCenter.TabIndex = 3;
            this.tabCenter.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabCenter_Selected);
            // 
            // tpGuide
            // 
            this.tpGuide.Controls.Add(this.pnCenter);
            this.tpGuide.Controls.Add(this.pnCenterHead);
            this.tpGuide.Location = new System.Drawing.Point(4, 22);
            this.tpGuide.Name = "tpGuide";
            this.tpGuide.Padding = new System.Windows.Forms.Padding(3);
            this.tpGuide.Size = new System.Drawing.Size(376, 517);
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
            this.pnCenter.Location = new System.Drawing.Point(3, 34);
            this.pnCenter.Name = "pnCenter";
            this.pnCenter.Size = new System.Drawing.Size(370, 480);
            this.pnCenter.TabIndex = 4;
            this.pnCenter.DragDrop += new System.Windows.Forms.DragEventHandler(this.pnCenter_DragDrop);
            this.pnCenter.DragEnter += new System.Windows.Forms.DragEventHandler(this.pnCenter_DragEnter);
            this.pnCenter.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnCenter_MouseDown);
            // 
            // pnCenterHead
            // 
            this.pnCenterHead.Controls.Add(this.lbProcessHead);
            this.pnCenterHead.Controls.Add(this.lbProcess);
            this.pnCenterHead.Controls.Add(this.btnLoadProcess);
            this.pnCenterHead.Controls.Add(this.cbProcess);
            this.pnCenterHead.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnCenterHead.Location = new System.Drawing.Point(3, 3);
            this.pnCenterHead.Name = "pnCenterHead";
            this.pnCenterHead.Size = new System.Drawing.Size(370, 31);
            this.pnCenterHead.TabIndex = 5;
            // 
            // lbProcessHead
            // 
            this.lbProcessHead.BackColor = System.Drawing.Color.Black;
            this.lbProcessHead.Location = new System.Drawing.Point(0, 20);
            this.lbProcessHead.Name = "lbProcessHead";
            this.lbProcessHead.Size = new System.Drawing.Size(5, 23);
            this.lbProcessHead.TabIndex = 4;
            this.lbProcessHead.Visible = false;
            // 
            // lbProcess
            // 
            this.lbProcess.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbProcess.Location = new System.Drawing.Point(-3, 5);
            this.lbProcess.Name = "lbProcess";
            this.lbProcess.Size = new System.Drawing.Size(166, 23);
            this.lbProcess.TabIndex = 3;
            // 
            // tpSearch
            // 
            this.tpSearch.Controls.Add(this.pnSearch);
            this.tpSearch.Location = new System.Drawing.Point(4, 22);
            this.tpSearch.Name = "tpSearch";
            this.tpSearch.Padding = new System.Windows.Forms.Padding(3);
            this.tpSearch.Size = new System.Drawing.Size(376, 517);
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
            this.pnSearch.Size = new System.Drawing.Size(370, 511);
            this.pnSearch.TabIndex = 0;
            // 
            // pnSearchResult
            // 
            this.pnSearchResult.AutoScroll = true;
            this.pnSearchResult.Controls.Add(this.listVSearchProcessName);
            this.pnSearchResult.Controls.Add(this.listVSearchProcess);
            this.pnSearchResult.Controls.Add(this.listVSearch);
            this.pnSearchResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnSearchResult.Location = new System.Drawing.Point(0, 53);
            this.pnSearchResult.Name = "pnSearchResult";
            this.pnSearchResult.Size = new System.Drawing.Size(370, 458);
            this.pnSearchResult.TabIndex = 1;
            // 
            // listVSearchProcessName
            // 
            this.listVSearchProcessName.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.listVSearchProcessName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listVSearchProcessName.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader9,
            this.columnHeader10});
            this.listVSearchProcessName.FullRowSelect = true;
            this.listVSearchProcessName.GridLines = true;
            this.listVSearchProcessName.HotTracking = true;
            this.listVSearchProcessName.HoverSelection = true;
            this.listVSearchProcessName.Location = new System.Drawing.Point(0, 190);
            this.listVSearchProcessName.MultiSelect = false;
            this.listVSearchProcessName.Name = "listVSearchProcessName";
            this.listVSearchProcessName.Size = new System.Drawing.Size(370, 87);
            this.listVSearchProcessName.TabIndex = 2;
            this.listVSearchProcessName.UseCompatibleStateImageBehavior = false;
            this.listVSearchProcessName.View = System.Windows.Forms.View.Details;
            this.listVSearchProcessName.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listVSearchProcessName_MouseClick);
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Process Name";
            this.columnHeader9.Width = 300;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "WorkflowID";
            this.columnHeader10.Width = 0;
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
            this.listVSearchProcess.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listVSearchProcess.FullRowSelect = true;
            this.listVSearchProcess.GridLines = true;
            this.listVSearchProcess.HotTracking = true;
            this.listVSearchProcess.HoverSelection = true;
            this.listVSearchProcess.Location = new System.Drawing.Point(0, 93);
            this.listVSearchProcess.MultiSelect = false;
            this.listVSearchProcess.Name = "listVSearchProcess";
            this.listVSearchProcess.Size = new System.Drawing.Size(370, 91);
            this.listVSearchProcess.TabIndex = 1;
            this.listVSearchProcess.UseCompatibleStateImageBehavior = false;
            this.listVSearchProcess.View = System.Windows.Forms.View.Details;
            this.listVSearchProcess.SelectedIndexChanged += new System.EventHandler(this.listVSearchProcess_SelectedIndexChanged);
            this.listVSearchProcess.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listVSearchProcess_MouseClick);
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Process Name";
            this.columnHeader7.Width = 95;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Task Name";
            this.columnHeader4.Width = 144;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Description";
            this.columnHeader5.Width = 86;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Keyword";
            this.columnHeader6.Width = 58;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "WorkflowID";
            this.columnHeader8.Width = 0;
            // 
            // listVSearch
            // 
            this.listVSearch.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.listVSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listVSearch.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listVSearch.FullRowSelect = true;
            this.listVSearch.GridLines = true;
            this.listVSearch.HotTracking = true;
            this.listVSearch.HoverSelection = true;
            this.listVSearch.Location = new System.Drawing.Point(0, 0);
            this.listVSearch.MultiSelect = false;
            this.listVSearch.Name = "listVSearch";
            this.listVSearch.Size = new System.Drawing.Size(370, 87);
            this.listVSearch.TabIndex = 0;
            this.listVSearch.UseCompatibleStateImageBehavior = false;
            this.listVSearch.View = System.Windows.Forms.View.Details;
            this.listVSearch.SelectedIndexChanged += new System.EventHandler(this.listVSearch_SelectedIndexChanged);
            this.listVSearch.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listVSearch_MouseClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Task Name";
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
            this.pnSearchTop.Controls.Add(this.rbAllProcess);
            this.pnSearchTop.Controls.Add(this.rbInProcess);
            this.pnSearchTop.Controls.Add(this.rbOnlyProcess);
            this.pnSearchTop.Controls.Add(this.txtSearch);
            this.pnSearchTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnSearchTop.Location = new System.Drawing.Point(0, 0);
            this.pnSearchTop.Name = "pnSearchTop";
            this.pnSearchTop.Size = new System.Drawing.Size(370, 53);
            this.pnSearchTop.TabIndex = 0;
            // 
            // rbAllProcess
            // 
            this.rbAllProcess.AutoSize = true;
            this.rbAllProcess.Checked = true;
            this.rbAllProcess.Location = new System.Drawing.Point(9, 33);
            this.rbAllProcess.Name = "rbAllProcess";
            this.rbAllProcess.Size = new System.Drawing.Size(87, 17);
            this.rbAllProcess.TabIndex = 16;
            this.rbAllProcess.TabStop = true;
            this.rbAllProcess.Text = "All processes";
            this.rbAllProcess.UseVisualStyleBackColor = true;
            this.rbAllProcess.Click += new System.EventHandler(this.rbAllProcess_Click);
            // 
            // rbInProcess
            // 
            this.rbInProcess.AutoSize = true;
            this.rbInProcess.Location = new System.Drawing.Point(113, 33);
            this.rbInProcess.Name = "rbInProcess";
            this.rbInProcess.Size = new System.Drawing.Size(101, 17);
            this.rbInProcess.TabIndex = 15;
            this.rbInProcess.Text = "Loaded process";
            this.rbInProcess.UseVisualStyleBackColor = true;
            this.rbInProcess.Click += new System.EventHandler(this.rbInProcess_Click);
            // 
            // rbOnlyProcess
            // 
            this.rbOnlyProcess.AutoSize = true;
            this.rbOnlyProcess.Location = new System.Drawing.Point(228, 33);
            this.rbOnlyProcess.Name = "rbOnlyProcess";
            this.rbOnlyProcess.Size = new System.Drawing.Size(92, 17);
            this.rbOnlyProcess.TabIndex = 14;
            this.rbOnlyProcess.Text = "Process name";
            this.rbOnlyProcess.UseVisualStyleBackColor = true;
            this.rbOnlyProcess.Click += new System.EventHandler(this.rbOnlyProcess_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(9, 9);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(318, 20);
            this.txtSearch.TabIndex = 11;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.Transparent;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsUserName,
            this.tsRole,
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2});
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
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel2.Text = "toolStripStatusLabel2";
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
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(384, 12);
            this.panel1.TabIndex = 2;
            this.panel1.Visible = false;
            // 
            // pnDesigner
            // 
            this.pnDesigner.Controls.Add(this.btnDeleteProcess);
            this.pnDesigner.Controls.Add(this.btn_modifyProcess);
            this.pnDesigner.Controls.Add(this.btn_createProcess);
            this.pnDesigner.Controls.Add(this.btnDelete);
            this.pnDesigner.Controls.Add(this.btnAdd);
            this.pnDesigner.Controls.Add(this.btnSubAdd);
            this.pnDesigner.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnDesigner.Location = new System.Drawing.Point(0, 555);
            this.pnDesigner.Name = "pnDesigner";
            this.pnDesigner.Size = new System.Drawing.Size(384, 24);
            this.pnDesigner.TabIndex = 4;
            // 
            // btnDeleteProcess
            // 
            this.btnDeleteProcess.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteProcess.Location = new System.Drawing.Point(189, 1);
            this.btnDeleteProcess.Name = "btnDeleteProcess";
            this.btnDeleteProcess.Size = new System.Drawing.Size(91, 23);
            this.btnDeleteProcess.TabIndex = 10;
            this.btnDeleteProcess.Text = "Delete process";
            this.btnDeleteProcess.UseVisualStyleBackColor = true;
            this.btnDeleteProcess.Click += new System.EventHandler(this.btnDeleteProcess_Click);
            // 
            // btn_modifyProcess
            // 
            this.btn_modifyProcess.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_modifyProcess.Location = new System.Drawing.Point(98, 1);
            this.btn_modifyProcess.Name = "btn_modifyProcess";
            this.btn_modifyProcess.Size = new System.Drawing.Size(91, 23);
            this.btn_modifyProcess.TabIndex = 9;
            this.btn_modifyProcess.Text = "Modify Process";
            this.btn_modifyProcess.UseVisualStyleBackColor = true;
            this.btn_modifyProcess.Click += new System.EventHandler(this.btn_modifyProcess_Click);
            // 
            // btn_createProcess
            // 
            this.btn_createProcess.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_createProcess.Location = new System.Drawing.Point(7, 1);
            this.btn_createProcess.Name = "btn_createProcess";
            this.btn_createProcess.Size = new System.Drawing.Size(91, 23);
            this.btn_createProcess.TabIndex = 8;
            this.btn_createProcess.Text = "Create process";
            this.btn_createProcess.UseVisualStyleBackColor = true;
            this.btn_createProcess.Click += new System.EventHandler(this.btn_createProcess_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 601);
            this.Controls.Add(this.btnOption);
            this.Controls.Add(this.tabCenter);
            this.Controls.Add(this.pnDesigner);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Process Guidance";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.frmMain_Paint);
            this.tabCenter.ResumeLayout(false);
            this.tpGuide.ResumeLayout(false);
            this.pnCenterHead.ResumeLayout(false);
            this.tpSearch.ResumeLayout(false);
            this.pnSearch.ResumeLayout(false);
            this.pnSearchResult.ResumeLayout(false);
            this.pnSearchTop.ResumeLayout(false);
            this.pnSearchTop.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ctmTask.ResumeLayout(false);
            this.pnDesigner.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnCenter;
        private System.Windows.Forms.Button btnLoadProcess;
        private System.Windows.Forms.ComboBox cbProcess;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSubAdd;
        private System.Windows.Forms.ContextMenuStrip ctmTask;
        private System.Windows.Forms.ToolStripMenuItem addMainTaskToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addSubTaskToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteTaskToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editNameToolStripMenuItem;
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
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Panel pnSearchResult;
        private System.Windows.Forms.ListView listVSearch;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnDesigner;
        private System.Windows.Forms.Panel pnCenterHead;
        private System.Windows.Forms.Label lbProcessHead;
        private System.Windows.Forms.Label lbProcess;
        private System.Windows.Forms.ListView listVSearchProcess;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.RadioButton rbAllProcess;
        private System.Windows.Forms.RadioButton rbInProcess;
        private System.Windows.Forms.RadioButton rbOnlyProcess;
        private System.Windows.Forms.ListView listVSearchProcessName;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.Button btnDeleteProcess;
        private System.Windows.Forms.Button btn_modifyProcess;
        private System.Windows.Forms.Button btn_createProcess;
    }
}

