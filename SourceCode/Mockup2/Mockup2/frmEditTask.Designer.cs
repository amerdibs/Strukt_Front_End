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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.ccbTask = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CBX_Project = new System.Windows.Forms.ComboBox();
            this.dateTimePicker_Deadline = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_Date = new System.Windows.Forms.DateTimePicker();
            this.CBX_Location = new System.Windows.Forms.ComboBox();
            this.CBX_Model = new System.Windows.Forms.ComboBox();
            this.CBX_Task_Type = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.comboBox8 = new System.Windows.Forms.ComboBox();
            this.comboBox7 = new System.Windows.Forms.ComboBox();
            this.comboBox6 = new System.Windows.Forms.ComboBox();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.CBX_Status = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.ccbTask);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(355, 41);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Task/ SubTask";
            // 
            // ccbTask
            // 
            this.ccbTask.FormattingEnabled = true;
            this.ccbTask.Items.AddRange(new object[] {
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
            this.ccbTask.Location = new System.Drawing.Point(100, 10);
            this.ccbTask.Name = "ccbTask";
            this.ccbTask.Size = new System.Drawing.Size(233, 21);
            this.ccbTask.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnOK);
            this.panel2.Controls.Add(this.btnCancel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 398);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(355, 40);
            this.panel2.TabIndex = 1;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(188, 6);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(269, 6);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CBX_Status);
            this.groupBox1.Controls.Add(this.CBX_Project);
            this.groupBox1.Controls.Add(this.dateTimePicker_Deadline);
            this.groupBox1.Controls.Add(this.dateTimePicker_Date);
            this.groupBox1.Controls.Add(this.CBX_Location);
            this.groupBox1.Controls.Add(this.CBX_Model);
            this.groupBox1.Controls.Add(this.CBX_Task_Type);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(355, 182);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Properties";
            // 
            // CBX_Project
            // 
            this.CBX_Project.FormattingEnabled = true;
            this.CBX_Project.Items.AddRange(new object[] {
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
            this.CBX_Project.Location = new System.Drawing.Point(124, 149);
            this.CBX_Project.Name = "CBX_Project";
            this.CBX_Project.Size = new System.Drawing.Size(145, 21);
            this.CBX_Project.TabIndex = 14;
            // 
            // dateTimePicker_Deadline
            // 
            this.dateTimePicker_Deadline.Location = new System.Drawing.Point(124, 125);
            this.dateTimePicker_Deadline.Name = "dateTimePicker_Deadline";
            this.dateTimePicker_Deadline.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker_Deadline.TabIndex = 13;
            // 
            // dateTimePicker_Date
            // 
            this.dateTimePicker_Date.Location = new System.Drawing.Point(124, 104);
            this.dateTimePicker_Date.Name = "dateTimePicker_Date";
            this.dateTimePicker_Date.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker_Date.TabIndex = 12;
            // 
            // CBX_Location
            // 
            this.CBX_Location.FormattingEnabled = true;
            this.CBX_Location.Items.AddRange(new object[] {
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
            this.CBX_Location.Location = new System.Drawing.Point(124, 82);
            this.CBX_Location.Name = "CBX_Location";
            this.CBX_Location.Size = new System.Drawing.Size(145, 21);
            this.CBX_Location.TabIndex = 10;
            // 
            // CBX_Model
            // 
            this.CBX_Model.FormattingEnabled = true;
            this.CBX_Model.Items.AddRange(new object[] {
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
            this.CBX_Model.Location = new System.Drawing.Point(124, 60);
            this.CBX_Model.Name = "CBX_Model";
            this.CBX_Model.Size = new System.Drawing.Size(145, 21);
            this.CBX_Model.TabIndex = 9;
            // 
            // CBX_Task_Type
            // 
            this.CBX_Task_Type.FormattingEnabled = true;
            this.CBX_Task_Type.Items.AddRange(new object[] {
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
            this.CBX_Task_Type.Location = new System.Drawing.Point(124, 38);
            this.CBX_Task_Type.Name = "CBX_Task_Type";
            this.CBX_Task_Type.Size = new System.Drawing.Size(145, 21);
            this.CBX_Task_Type.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(78, 152);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Project";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(70, 131);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Deadline";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(88, 108);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(70, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Location";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(82, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Model";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Task Type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(84, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Staus";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButton3);
            this.groupBox2.Controls.Add(this.radioButton2);
            this.groupBox2.Controls.Add(this.radioButton1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 223);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(355, 53);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tools";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(223, 20);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(79, 17);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.Text = "Attachment";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(115, 20);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(77, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.Text = "Application";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(28, 20);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(45, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Link";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.comboBox8);
            this.groupBox3.Controls.Add(this.comboBox7);
            this.groupBox3.Controls.Add(this.comboBox6);
            this.groupBox3.Controls.Add(this.comboBox5);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(0, 276);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(355, 122);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Conditions";
            // 
            // comboBox8
            // 
            this.comboBox8.FormattingEnabled = true;
            this.comboBox8.Items.AddRange(new object[] {
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
            this.comboBox8.Location = new System.Drawing.Point(124, 91);
            this.comboBox8.Name = "comboBox8";
            this.comboBox8.Size = new System.Drawing.Size(145, 21);
            this.comboBox8.TabIndex = 18;
            // 
            // comboBox7
            // 
            this.comboBox7.FormattingEnabled = true;
            this.comboBox7.Items.AddRange(new object[] {
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
            this.comboBox7.Location = new System.Drawing.Point(124, 69);
            this.comboBox7.Name = "comboBox7";
            this.comboBox7.Size = new System.Drawing.Size(145, 21);
            this.comboBox7.TabIndex = 17;
            // 
            // comboBox6
            // 
            this.comboBox6.FormattingEnabled = true;
            this.comboBox6.Items.AddRange(new object[] {
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
            this.comboBox6.Location = new System.Drawing.Point(124, 47);
            this.comboBox6.Name = "comboBox6";
            this.comboBox6.Size = new System.Drawing.Size(145, 21);
            this.comboBox6.TabIndex = 16;
            // 
            // comboBox5
            // 
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Items.AddRange(new object[] {
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
            this.comboBox5.Location = new System.Drawing.Point(124, 24);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(145, 21);
            this.comboBox5.TabIndex = 15;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(14, 94);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(104, 13);
            this.label12.TabIndex = 10;
            this.label12.Text = "Resource conditions";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(38, 72);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(80, 13);
            this.label11.TabIndex = 9;
            this.label11.Text = "Role conditions";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(56, 50);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 13);
            this.label10.TabIndex = 8;
            this.label10.Text = "Alternatives";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(47, 30);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 13);
            this.label9.TabIndex = 7;
            this.label9.Text = "Preconditions";
            // 
            // CBX_Status
            // 
            this.CBX_Status.FormattingEnabled = true;
            this.CBX_Status.Items.AddRange(new object[] {
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
            this.CBX_Status.Location = new System.Drawing.Point(124, 11);
            this.CBX_Status.Name = "CBX_Status";
            this.CBX_Status.Size = new System.Drawing.Size(145, 21);
            this.CBX_Status.TabIndex = 15;
            // 
            // frmTaskEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 438);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "frmTaskEdit";
            this.Text = "Edit Task/ Sub Task";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmTaskEdit_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ccbTask;
        private System.Windows.Forms.ComboBox CBX_Project;
        private System.Windows.Forms.DateTimePicker dateTimePicker_Deadline;
        private System.Windows.Forms.DateTimePicker dateTimePicker_Date;
        private System.Windows.Forms.ComboBox CBX_Location;
        private System.Windows.Forms.ComboBox CBX_Model;
        private System.Windows.Forms.ComboBox CBX_Task_Type;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox8;
        private System.Windows.Forms.ComboBox comboBox7;
        private System.Windows.Forms.ComboBox comboBox6;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.ComboBox CBX_Status;
    }
}