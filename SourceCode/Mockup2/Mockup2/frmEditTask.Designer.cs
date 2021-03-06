﻿namespace Mockup2
{
    partial class frmTaskEdit
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
            this.pnName = new System.Windows.Forms.Panel();
            this.txtTaskName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbTask = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.gbProp = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtDetail = new System.Windows.Forms.TextBox();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.cbProject = new System.Windows.Forms.ComboBox();
            this.dtpDeadline = new System.Windows.Forms.DateTimePicker();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.cbLocation = new System.Windows.Forms.ComboBox();
            this.cbTaskType = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbModel = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbNone = new System.Windows.Forms.RadioButton();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.rbFile = new System.Windows.Forms.RadioButton();
            this.rbApp = new System.Windows.Forms.RadioButton();
            this.rbLink = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lstResourceCondition = new System.Windows.Forms.ListBox();
            this.lstRoleCondition = new System.Windows.Forms.ListBox();
            this.lstAlternative = new System.Windows.Forms.ListBox();
            this.lstPreCondition = new System.Windows.Forms.ListBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.ofFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.pnName.SuspendLayout();
            this.panel2.SuspendLayout();
            this.gbProp.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnName
            // 
            this.pnName.BackColor = System.Drawing.Color.Transparent;
            this.pnName.Controls.Add(this.txtTaskName);
            this.pnName.Controls.Add(this.label1);
            this.pnName.Controls.Add(this.cbTask);
            this.pnName.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnName.Location = new System.Drawing.Point(0, 0);
            this.pnName.Name = "pnName";
            this.pnName.Size = new System.Drawing.Size(355, 41);
            this.pnName.TabIndex = 0;
            // 
            // txtTaskName
            // 
            this.txtTaskName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTaskName.Location = new System.Drawing.Point(42, 10);
            this.txtTaskName.Name = "txtTaskName";
            this.txtTaskName.Size = new System.Drawing.Size(307, 20);
            this.txtTaskName.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Task";
            // 
            // cbTask
            // 
            this.cbTask.FormattingEnabled = true;
            this.cbTask.Items.AddRange(new object[] {
            "Main Task 1",
            "________Sub Task 1",
            "________Sub Task 2",
            "________Sub Task 3",
            "________Sub Task 4",
            "Main Task 2",
            "________Sub Task 2_1",
            "________Sub Task 2_2",
            "________Sub Task 2_3",
            "________Sub Task 2_4"});
            this.cbTask.Location = new System.Drawing.Point(12, 10);
            this.cbTask.Name = "cbTask";
            this.cbTask.Size = new System.Drawing.Size(18, 21);
            this.cbTask.TabIndex = 0;
            this.cbTask.Visible = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.btnOK);
            this.panel2.Controls.Add(this.btnCancel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 272);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(355, 40);
            this.panel2.TabIndex = 1;
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOK.Image = global::Mockup2.Properties.Resources.ball_green;
            this.btnOK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOK.Location = new System.Drawing.Point(188, 6);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "Save";
            this.btnOK.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Image = global::Mockup2.Properties.Resources.ball_red;
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(269, 6);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // gbProp
            // 
            this.gbProp.BackColor = System.Drawing.Color.Transparent;
            this.gbProp.Controls.Add(this.label3);
            this.gbProp.Controls.Add(this.label13);
            this.gbProp.Controls.Add(this.txtDetail);
            this.gbProp.Controls.Add(this.cbStatus);
            this.gbProp.Controls.Add(this.cbProject);
            this.gbProp.Controls.Add(this.dtpDeadline);
            this.gbProp.Controls.Add(this.dtpDate);
            this.gbProp.Controls.Add(this.cbLocation);
            this.gbProp.Controls.Add(this.cbTaskType);
            this.gbProp.Controls.Add(this.label8);
            this.gbProp.Controls.Add(this.label7);
            this.gbProp.Controls.Add(this.label6);
            this.gbProp.Controls.Add(this.label5);
            this.gbProp.Controls.Add(this.label2);
            this.gbProp.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbProp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbProp.Location = new System.Drawing.Point(0, 41);
            this.gbProp.Name = "gbProp";
            this.gbProp.Size = new System.Drawing.Size(355, 135);
            this.gbProp.TabIndex = 2;
            this.gbProp.TabStop = false;
            this.gbProp.Text = "Properties";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(108, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Task Type";
            this.label3.Visible = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.Blue;
            this.label13.Location = new System.Drawing.Point(12, 79);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(34, 13);
            this.label13.TabIndex = 17;
            this.label13.Text = "Detail";
            // 
            // txtDetail
            // 
            this.txtDetail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDetail.ForeColor = System.Drawing.Color.Blue;
            this.txtDetail.Location = new System.Drawing.Point(58, 77);
            this.txtDetail.Multiline = true;
            this.txtDetail.Name = "txtDetail";
            this.txtDetail.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDetail.Size = new System.Drawing.Size(291, 48);
            this.txtDetail.TabIndex = 16;
            // 
            // cbStatus
            // 
            this.cbStatus.DropDownWidth = 100;
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Items.AddRange(new object[] {
            "Main Task 1",
            "\tSub Task 1",
            "\tSub Task 2",
            "\tSub Task 3",
            "\tSub Task 4",
            "Main Task 2",
            "\tSub Task 2_1",
            "\tSub Task 2_2",
            "\tSub Task 2_3",
            "\tSub Task 2_4",
            ""});
            this.cbStatus.Location = new System.Drawing.Point(58, 18);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(118, 21);
            this.cbStatus.TabIndex = 15;
            // 
            // cbProject
            // 
            this.cbProject.FormattingEnabled = true;
            this.cbProject.Items.AddRange(new object[] {
            "Main Task 1",
            "\tSub Task 1",
            "\tSub Task 2",
            "\tSub Task 3",
            "\tSub Task 4",
            "Main Task 2",
            "\tSub Task 2_1",
            "\tSub Task 2_2",
            "\tSub Task 2_3",
            "\tSub Task 2_4",
            ""});
            this.cbProject.Location = new System.Drawing.Point(257, 147);
            this.cbProject.Name = "cbProject";
            this.cbProject.Size = new System.Drawing.Size(36, 21);
            this.cbProject.TabIndex = 14;
            this.cbProject.Visible = false;
            // 
            // dtpDeadline
            // 
            this.dtpDeadline.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDeadline.Location = new System.Drawing.Point(239, 51);
            this.dtpDeadline.Name = "dtpDeadline";
            this.dtpDeadline.Size = new System.Drawing.Size(110, 20);
            this.dtpDeadline.TabIndex = 13;
            // 
            // dtpDate
            // 
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Location = new System.Drawing.Point(58, 48);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(118, 20);
            this.dtpDate.TabIndex = 12;
            // 
            // cbLocation
            // 
            this.cbLocation.FormattingEnabled = true;
            this.cbLocation.Items.AddRange(new object[] {
            "Main Task 1",
            "\tSub Task 1",
            "\tSub Task 2",
            "\tSub Task 3",
            "\tSub Task 4",
            "Main Task 2",
            "\tSub Task 2_1",
            "\tSub Task 2_2",
            "\tSub Task 2_3",
            "\tSub Task 2_4",
            ""});
            this.cbLocation.Location = new System.Drawing.Point(239, 18);
            this.cbLocation.Name = "cbLocation";
            this.cbLocation.Size = new System.Drawing.Size(110, 21);
            this.cbLocation.TabIndex = 10;
            // 
            // cbTaskType
            // 
            this.cbTaskType.DropDownWidth = 100;
            this.cbTaskType.FormattingEnabled = true;
            this.cbTaskType.Items.AddRange(new object[] {
            "Main Task 1",
            "\tSub Task 1",
            "\tSub Task 2",
            "\tSub Task 3",
            "\tSub Task 4",
            "Main Task 2",
            "\tSub Task 2_1",
            "\tSub Task 2_2",
            "\tSub Task 2_3",
            "\tSub Task 2_4",
            ""});
            this.cbTaskType.Location = new System.Drawing.Point(78, 147);
            this.cbTaskType.Name = "cbTaskType";
            this.cbTaskType.Size = new System.Drawing.Size(24, 21);
            this.cbTaskType.TabIndex = 8;
            this.cbTaskType.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(204, 150);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Project";
            this.label8.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(185, 51);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Deadline";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(186, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Location";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Staus";
            // 
            // cbModel
            // 
            this.cbModel.FormattingEnabled = true;
            this.cbModel.Items.AddRange(new object[] {
            "Main Task 1",
            "\tSub Task 1",
            "\tSub Task 2",
            "\tSub Task 3",
            "\tSub Task 4",
            "Main Task 2",
            "\tSub Task 2_1",
            "\tSub Task 2_2",
            "\tSub Task 2_3",
            "\tSub Task 2_4",
            ""});
            this.cbModel.Location = new System.Drawing.Point(50, 41);
            this.cbModel.Name = "cbModel";
            this.cbModel.Size = new System.Drawing.Size(35, 21);
            this.cbModel.TabIndex = 9;
            this.cbModel.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Model";
            this.label4.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.rbNone);
            this.groupBox2.Controls.Add(this.btnBrowse);
            this.groupBox2.Controls.Add(this.txtAddress);
            this.groupBox2.Controls.Add(this.rbFile);
            this.groupBox2.Controls.Add(this.rbApp);
            this.groupBox2.Controls.Add(this.rbLink);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Location = new System.Drawing.Point(0, 176);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(355, 96);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tools";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // rbNone
            // 
            this.rbNone.AutoSize = true;
            this.rbNone.Checked = true;
            this.rbNone.Location = new System.Drawing.Point(19, 20);
            this.rbNone.Name = "rbNone";
            this.rbNone.Size = new System.Drawing.Size(51, 17);
            this.rbNone.TabIndex = 5;
            this.rbNone.TabStop = true;
            this.rbNone.Text = "None";
            this.rbNone.UseVisualStyleBackColor = true;
            this.rbNone.Click += new System.EventHandler(this.rbNone_Click);
            // 
            // btnBrowse
            // 
            this.btnBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrowse.Image = global::Mockup2.Properties.Resources.folder_find;
            this.btnBrowse.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBrowse.Location = new System.Drawing.Point(268, 69);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnBrowse.TabIndex = 4;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // txtAddress
            // 
            this.txtAddress.Enabled = false;
            this.txtAddress.Location = new System.Drawing.Point(19, 43);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(324, 20);
            this.txtAddress.TabIndex = 3;
            // 
            // rbFile
            // 
            this.rbFile.AutoSize = true;
            this.rbFile.Location = new System.Drawing.Point(268, 20);
            this.rbFile.Name = "rbFile";
            this.rbFile.Size = new System.Drawing.Size(41, 17);
            this.rbFile.TabIndex = 2;
            this.rbFile.Text = "File";
            this.rbFile.UseVisualStyleBackColor = true;
            this.rbFile.Click += new System.EventHandler(this.rbFile_Click);
            // 
            // rbApp
            // 
            this.rbApp.AutoSize = true;
            this.rbApp.Location = new System.Drawing.Point(169, 20);
            this.rbApp.Name = "rbApp";
            this.rbApp.Size = new System.Drawing.Size(77, 17);
            this.rbApp.TabIndex = 1;
            this.rbApp.Text = "Application";
            this.rbApp.UseVisualStyleBackColor = true;
            this.rbApp.Click += new System.EventHandler(this.rbApp_Click);
            // 
            // rbLink
            // 
            this.rbLink.AutoSize = true;
            this.rbLink.Location = new System.Drawing.Point(94, 20);
            this.rbLink.Name = "rbLink";
            this.rbLink.Size = new System.Drawing.Size(45, 17);
            this.rbLink.TabIndex = 0;
            this.rbLink.Text = "Link";
            this.rbLink.UseVisualStyleBackColor = true;
            this.rbLink.Click += new System.EventHandler(this.rbLink_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.lstResourceCondition);
            this.groupBox3.Controls.Add(this.lstRoleCondition);
            this.groupBox3.Controls.Add(this.lstAlternative);
            this.groupBox3.Controls.Add(this.lstPreCondition);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.cbModel);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Enabled = false;
            this.groupBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox3.Location = new System.Drawing.Point(0, 272);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(355, 0);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Conditions";
            this.groupBox3.Visible = false;
            // 
            // lstResourceCondition
            // 
            this.lstResourceCondition.FormattingEnabled = true;
            this.lstResourceCondition.Location = new System.Drawing.Point(144, 166);
            this.lstResourceCondition.Name = "lstResourceCondition";
            this.lstResourceCondition.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lstResourceCondition.Size = new System.Drawing.Size(200, 43);
            this.lstResourceCondition.TabIndex = 11;
            // 
            // lstRoleCondition
            // 
            this.lstRoleCondition.FormattingEnabled = true;
            this.lstRoleCondition.Location = new System.Drawing.Point(145, 117);
            this.lstRoleCondition.Name = "lstRoleCondition";
            this.lstRoleCondition.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lstRoleCondition.Size = new System.Drawing.Size(200, 43);
            this.lstRoleCondition.TabIndex = 11;
            // 
            // lstAlternative
            // 
            this.lstAlternative.FormattingEnabled = true;
            this.lstAlternative.Location = new System.Drawing.Point(144, 68);
            this.lstAlternative.Name = "lstAlternative";
            this.lstAlternative.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lstAlternative.Size = new System.Drawing.Size(200, 43);
            this.lstAlternative.TabIndex = 11;
            // 
            // lstPreCondition
            // 
            this.lstPreCondition.FormattingEnabled = true;
            this.lstPreCondition.Location = new System.Drawing.Point(144, 19);
            this.lstPreCondition.Name = "lstPreCondition";
            this.lstPreCondition.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lstPreCondition.Size = new System.Drawing.Size(200, 43);
            this.lstPreCondition.TabIndex = 11;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(35, 162);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(104, 13);
            this.label12.TabIndex = 10;
            this.label12.Text = "Resource conditions";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(59, 117);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(80, 13);
            this.label11.TabIndex = 9;
            this.label11.Text = "Role conditions";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(76, 68);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 13);
            this.label10.TabIndex = 8;
            this.label10.Text = "Alternatives";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(66, 19);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 13);
            this.label9.TabIndex = 7;
            this.label9.Text = "Preconditions";
            // 
            // ofFileDialog
            // 
            this.ofFileDialog.FileName = "*.*";
            this.ofFileDialog.InitialDirectory = "W:\\";
            // 
            // frmTaskEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 312);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gbProp);
            this.Controls.Add(this.pnName);
            this.Controls.Add(this.panel2);
            this.Name = "frmTaskEdit";
            this.Text = "Edit Task";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmTaskEdit_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.frmTaskEdit_Paint);
            this.pnName.ResumeLayout(false);
            this.pnName.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.gbProp.ResumeLayout(false);
            this.gbProp.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnName;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox gbProp;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbTask;
        private System.Windows.Forms.ComboBox cbProject;
        private System.Windows.Forms.DateTimePicker dtpDeadline;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.ComboBox cbLocation;
        private System.Windows.Forms.ComboBox cbModel;
        private System.Windows.Forms.ComboBox cbTaskType;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RadioButton rbFile;
        private System.Windows.Forms.RadioButton rbApp;
        private System.Windows.Forms.RadioButton rbLink;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.TextBox txtTaskName;
        private System.Windows.Forms.ListBox lstResourceCondition;
        private System.Windows.Forms.ListBox lstRoleCondition;
        private System.Windows.Forms.ListBox lstAlternative;
        private System.Windows.Forms.ListBox lstPreCondition;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtDetail;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.RadioButton rbNone;
        private System.Windows.Forms.OpenFileDialog ofFileDialog;
    }
}