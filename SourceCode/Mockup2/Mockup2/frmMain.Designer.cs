namespace Mockup2
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pnCenter = new System.Windows.Forms.Panel();
            this.btnHide = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSaveProcessAs = new System.Windows.Forms.Button();
            this.btnLoadProcess = new System.Windows.Forms.Button();
            this.ccbProcess = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnOption = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSubAdd = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.pnControl = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.ctmTask = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addMainTaskToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addSubTaskToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteTaskToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editNameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.pnControl.SuspendLayout();
            this.ctmTask.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.264462F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 91.73553F));
            this.tableLayoutPanel1.Controls.Add(this.pnCenter, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnHide, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.923664F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90.07633F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(364, 525);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // pnCenter
            // 
            this.pnCenter.AllowDrop = true;
            this.pnCenter.AutoScroll = true;
            this.pnCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnCenter.Location = new System.Drawing.Point(34, 56);
            this.pnCenter.Name = "pnCenter";
            this.pnCenter.Size = new System.Drawing.Size(326, 465);
            this.pnCenter.TabIndex = 0;
            this.pnCenter.DragDrop += new System.Windows.Forms.DragEventHandler(this.pnCenter_DragDrop);
            this.pnCenter.DragEnter += new System.Windows.Forms.DragEventHandler(this.pnCenter_DragEnter);
            // 
            // btnHide
            // 
            this.btnHide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHide.Image = global::Mockup2.Properties.Resources.bt_skip_sw;
            this.btnHide.Location = new System.Drawing.Point(4, 4);
            this.btnHide.Name = "btnHide";
            this.btnHide.Size = new System.Drawing.Size(23, 45);
            this.btnHide.TabIndex = 1;
            this.btnHide.UseVisualStyleBackColor = true;
            this.btnHide.Click += new System.EventHandler(this.btnHide_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnSaveProcessAs);
            this.panel2.Controls.Add(this.btnLoadProcess);
            this.panel2.Controls.Add(this.ccbProcess);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(34, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(326, 45);
            this.panel2.TabIndex = 2;
            // 
            // btnSaveProcessAs
            // 
            this.btnSaveProcessAs.Image = global::Mockup2.Properties.Resources.save;
            this.btnSaveProcessAs.Location = new System.Drawing.Point(294, 8);
            this.btnSaveProcessAs.Name = "btnSaveProcessAs";
            this.btnSaveProcessAs.Size = new System.Drawing.Size(28, 23);
            this.btnSaveProcessAs.TabIndex = 3;
            this.btnSaveProcessAs.UseVisualStyleBackColor = true;
            // 
            // btnLoadProcess
            // 
            this.btnLoadProcess.Image = global::Mockup2.Properties.Resources.down1;
            this.btnLoadProcess.Location = new System.Drawing.Point(266, 8);
            this.btnLoadProcess.Name = "btnLoadProcess";
            this.btnLoadProcess.Size = new System.Drawing.Size(28, 23);
            this.btnLoadProcess.TabIndex = 2;
            this.btnLoadProcess.UseVisualStyleBackColor = true;
            this.btnLoadProcess.Click += new System.EventHandler(this.btnLoadProcess_Click);
            // 
            // ccbProcess
            // 
            this.ccbProcess.FormattingEnabled = true;
            this.ccbProcess.Items.AddRange(new object[] {
            "Structure Process 1",
            "Structure Process 2",
            "Structure Process 3"});
            this.ccbProcess.Location = new System.Drawing.Point(132, 9);
            this.ccbProcess.Name = "ccbProcess";
            this.ccbProcess.Size = new System.Drawing.Size(132, 21);
            this.ccbProcess.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Loaded Process";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnOption);
            this.panel3.Controls.Add(this.btnDelete);
            this.panel3.Controls.Add(this.btnSubAdd);
            this.panel3.Controls.Add(this.btnAdd);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(4, 56);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(23, 465);
            this.panel3.TabIndex = 3;
            // 
            // btnOption
            // 
            this.btnOption.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnOption.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOption.Image = global::Mockup2.Properties.Resources.applications;
            this.btnOption.Location = new System.Drawing.Point(0, 66);
            this.btnOption.Name = "btnOption";
            this.btnOption.Size = new System.Drawing.Size(23, 22);
            this.btnOption.TabIndex = 7;
            this.btnOption.UseVisualStyleBackColor = true;
            this.btnOption.Click += new System.EventHandler(this.btnOption_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Image = global::Mockup2.Properties.Resources.trash;
            this.btnDelete.Location = new System.Drawing.Point(0, 44);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(23, 22);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSubAdd
            // 
            this.btnSubAdd.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSubAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubAdd.Image = global::Mockup2.Properties.Resources._new;
            this.btnSubAdd.Location = new System.Drawing.Point(0, 22);
            this.btnSubAdd.Name = "btnSubAdd";
            this.btnSubAdd.Size = new System.Drawing.Size(23, 22);
            this.btnSubAdd.TabIndex = 6;
            this.btnSubAdd.UseVisualStyleBackColor = true;
            this.btnSubAdd.Click += new System.EventHandler(this.btnSubAdd_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Image = global::Mockup2.Properties.Resources.add;
            this.btnAdd.Location = new System.Drawing.Point(0, 0);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(23, 22);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Tag = "";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 559);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(364, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // pnControl
            // 
            this.pnControl.Controls.Add(this.button3);
            this.pnControl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnControl.Location = new System.Drawing.Point(0, 525);
            this.pnControl.Name = "pnControl";
            this.pnControl.Size = new System.Drawing.Size(364, 34);
            this.pnControl.TabIndex = 2;
            this.pnControl.Visible = false;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(285, 6);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 1;
            this.button3.Text = "Exit";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // ctmTask
            // 
            this.ctmTask.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addMainTaskToolStripMenuItem,
            this.addSubTaskToolStripMenuItem,
            this.deleteTaskToolStripMenuItem,
            this.editNameToolStripMenuItem});
            this.ctmTask.Name = "ctmTask";
            this.ctmTask.Size = new System.Drawing.Size(154, 92);
            // 
            // addMainTaskToolStripMenuItem
            // 
            this.addMainTaskToolStripMenuItem.Name = "addMainTaskToolStripMenuItem";
            this.addMainTaskToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.addMainTaskToolStripMenuItem.Text = "Add Main Task";
            this.addMainTaskToolStripMenuItem.Click += new System.EventHandler(this.addMainTaskToolStripMenuItem_Click);
            // 
            // addSubTaskToolStripMenuItem
            // 
            this.addSubTaskToolStripMenuItem.Name = "addSubTaskToolStripMenuItem";
            this.addSubTaskToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.addSubTaskToolStripMenuItem.Text = "Add Sub Task";
            this.addSubTaskToolStripMenuItem.Click += new System.EventHandler(this.addSubTaskToolStripMenuItem_Click);
            // 
            // deleteTaskToolStripMenuItem
            // 
            this.deleteTaskToolStripMenuItem.Name = "deleteTaskToolStripMenuItem";
            this.deleteTaskToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.deleteTaskToolStripMenuItem.Text = "Delete Task";
            this.deleteTaskToolStripMenuItem.Click += new System.EventHandler(this.deleteTaskToolStripMenuItem_Click);
            // 
            // editNameToolStripMenuItem
            // 
            this.editNameToolStripMenuItem.Name = "editNameToolStripMenuItem";
            this.editNameToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.editNameToolStripMenuItem.Text = "Edit Name";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 581);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.pnControl);
            this.Controls.Add(this.statusStrip1);
            this.Name = "frmMain";
            this.Text = "User  Guidance Application";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.pnControl.ResumeLayout(false);
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
        private System.Windows.Forms.ComboBox ccbProcess;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Panel pnControl;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSubAdd;
        private System.Windows.Forms.Button btnOption;
        private System.Windows.Forms.Button btnSaveProcessAs;
        private System.Windows.Forms.ContextMenuStrip ctmTask;
        private System.Windows.Forms.ToolStripMenuItem addMainTaskToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addSubTaskToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteTaskToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editNameToolStripMenuItem;
    }
}

