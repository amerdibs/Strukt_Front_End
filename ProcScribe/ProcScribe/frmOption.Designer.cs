namespace ProcScribe
{
    partial class frmOption
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
            this.btnOK = new System.Windows.Forms.Button();
            this.cbTop = new System.Windows.Forms.CheckBox();
            this.cdDialog = new System.Windows.Forms.ColorDialog();
            this.gbColor = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTaskHoverColor = new System.Windows.Forms.Button();
            this.txtTaskHoverColor = new System.Windows.Forms.TextBox();
            this.btnDefault = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.btnTaskSelectColor = new System.Windows.Forms.Button();
            this.txtTaskSelectColor = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnColorTask = new System.Windows.Forms.Button();
            this.txtColorTask = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAdvance = new System.Windows.Forms.Button();
            this.gbUserRole = new System.Windows.Forms.GroupBox();
            this.rdbtnExecutor = new System.Windows.Forms.RadioButton();
            this.rdbtnDesigner = new System.Windows.Forms.RadioButton();
            this.gbColor.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gbUserRole.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(203, 36);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(89, 23);
            this.btnOK.TabIndex = 11;
            this.btnOK.Text = "Close";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // cbTop
            // 
            this.cbTop.AutoSize = true;
            this.cbTop.Location = new System.Drawing.Point(12, 12);
            this.cbTop.Name = "cbTop";
            this.cbTop.Size = new System.Drawing.Size(96, 17);
            this.cbTop.TabIndex = 1;
            this.cbTop.Text = "Always on Top";
            this.cbTop.UseVisualStyleBackColor = true;
            // 
            // cdDialog
            // 
            this.cdDialog.AnyColor = true;
            this.cdDialog.FullOpen = true;
            // 
            // gbColor
            // 
            this.gbColor.Controls.Add(this.label1);
            this.gbColor.Controls.Add(this.btnTaskHoverColor);
            this.gbColor.Controls.Add(this.txtTaskHoverColor);
            this.gbColor.Controls.Add(this.btnDefault);
            this.gbColor.Controls.Add(this.label8);
            this.gbColor.Controls.Add(this.btnTaskSelectColor);
            this.gbColor.Controls.Add(this.txtTaskSelectColor);
            this.gbColor.Controls.Add(this.label7);
            this.gbColor.Controls.Add(this.btnColorTask);
            this.gbColor.Controls.Add(this.txtColorTask);
            this.gbColor.Controls.Add(this.label2);
            this.gbColor.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbColor.Location = new System.Drawing.Point(0, 64);
            this.gbColor.Name = "gbColor";
            this.gbColor.Size = new System.Drawing.Size(298, 134);
            this.gbColor.TabIndex = 3;
            this.gbColor.TabStop = false;
            this.gbColor.Text = "Color";
            this.gbColor.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 13);
            this.label1.TabIndex = 34;
            this.label1.Text = "* Color will be effect on new starting.";
            // 
            // btnTaskHoverColor
            // 
            this.btnTaskHoverColor.Location = new System.Drawing.Point(203, 75);
            this.btnTaskHoverColor.Name = "btnTaskHoverColor";
            this.btnTaskHoverColor.Size = new System.Drawing.Size(89, 23);
            this.btnTaskHoverColor.TabIndex = 9;
            this.btnTaskHoverColor.Text = "Choose color";
            this.btnTaskHoverColor.UseVisualStyleBackColor = true;
            this.btnTaskHoverColor.Click += new System.EventHandler(this.btnTaskHoverColor_Click);
            // 
            // txtTaskHoverColor
            // 
            this.txtTaskHoverColor.Location = new System.Drawing.Point(136, 75);
            this.txtTaskHoverColor.Name = "txtTaskHoverColor";
            this.txtTaskHoverColor.ReadOnly = true;
            this.txtTaskHoverColor.Size = new System.Drawing.Size(53, 20);
            this.txtTaskHoverColor.TabIndex = 8;
            // 
            // btnDefault
            // 
            this.btnDefault.Location = new System.Drawing.Point(203, 105);
            this.btnDefault.Name = "btnDefault";
            this.btnDefault.Size = new System.Drawing.Size(89, 23);
            this.btnDefault.TabIndex = 10;
            this.btnDefault.Text = "Back to default";
            this.btnDefault.UseVisualStyleBackColor = true;
            this.btnDefault.Click += new System.EventHandler(this.btnDefault_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(40, 78);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 13);
            this.label8.TabIndex = 31;
            this.label8.Text = "Task Hover Color";
            // 
            // btnTaskSelectColor
            // 
            this.btnTaskSelectColor.Location = new System.Drawing.Point(203, 45);
            this.btnTaskSelectColor.Name = "btnTaskSelectColor";
            this.btnTaskSelectColor.Size = new System.Drawing.Size(89, 23);
            this.btnTaskSelectColor.TabIndex = 7;
            this.btnTaskSelectColor.Text = "Choose color";
            this.btnTaskSelectColor.UseVisualStyleBackColor = true;
            this.btnTaskSelectColor.Click += new System.EventHandler(this.btnTaskSelectColor_Click);
            // 
            // txtTaskSelectColor
            // 
            this.txtTaskSelectColor.Location = new System.Drawing.Point(136, 45);
            this.txtTaskSelectColor.Name = "txtTaskSelectColor";
            this.txtTaskSelectColor.ReadOnly = true;
            this.txtTaskSelectColor.Size = new System.Drawing.Size(53, 20);
            this.txtTaskSelectColor.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(40, 50);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 13);
            this.label7.TabIndex = 28;
            this.label7.Text = "Task Select Color";
            // 
            // btnColorTask
            // 
            this.btnColorTask.Location = new System.Drawing.Point(203, 17);
            this.btnColorTask.Name = "btnColorTask";
            this.btnColorTask.Size = new System.Drawing.Size(89, 23);
            this.btnColorTask.TabIndex = 5;
            this.btnColorTask.Text = "Choose color";
            this.btnColorTask.UseVisualStyleBackColor = true;
            this.btnColorTask.Click += new System.EventHandler(this.btnColorTask_Click);
            // 
            // txtColorTask
            // 
            this.txtColorTask.Location = new System.Drawing.Point(136, 17);
            this.txtColorTask.Name = "txtColorTask";
            this.txtColorTask.ReadOnly = true;
            this.txtColorTask.Size = new System.Drawing.Size(53, 20);
            this.txtColorTask.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(72, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Task Color";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAdvance);
            this.groupBox1.Controls.Add(this.btnOK);
            this.groupBox1.Controls.Add(this.cbTop);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(298, 64);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // btnAdvance
            // 
            this.btnAdvance.Location = new System.Drawing.Point(108, 36);
            this.btnAdvance.Name = "btnAdvance";
            this.btnAdvance.Size = new System.Drawing.Size(89, 23);
            this.btnAdvance.TabIndex = 2;
            this.btnAdvance.Text = "Advance";
            this.btnAdvance.UseVisualStyleBackColor = true;
            this.btnAdvance.Visible = false;
            this.btnAdvance.Click += new System.EventHandler(this.btnAdvance_Click);
            // 
            // gbUserRole
            // 
            this.gbUserRole.Controls.Add(this.rdbtnExecutor);
            this.gbUserRole.Controls.Add(this.rdbtnDesigner);
            this.gbUserRole.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbUserRole.Location = new System.Drawing.Point(0, 198);
            this.gbUserRole.Name = "gbUserRole";
            this.gbUserRole.Size = new System.Drawing.Size(298, 48);
            this.gbUserRole.TabIndex = 4;
            this.gbUserRole.TabStop = false;
            this.gbUserRole.Text = "User Role";
            // 
            // rdbtnExecutor
            // 
            this.rdbtnExecutor.AutoSize = true;
            this.rdbtnExecutor.Checked = true;
            this.rdbtnExecutor.Location = new System.Drawing.Point(155, 19);
            this.rdbtnExecutor.Name = "rdbtnExecutor";
            this.rdbtnExecutor.Size = new System.Drawing.Size(67, 17);
            this.rdbtnExecutor.TabIndex = 1;
            this.rdbtnExecutor.TabStop = true;
            this.rdbtnExecutor.Text = "Executor";
            this.rdbtnExecutor.UseVisualStyleBackColor = true;
            this.rdbtnExecutor.CheckedChanged += new System.EventHandler(this.rdbtnExecutor_CheckedChanged);
            // 
            // rdbtnDesigner
            // 
            this.rdbtnDesigner.AutoSize = true;
            this.rdbtnDesigner.Location = new System.Drawing.Point(46, 19);
            this.rdbtnDesigner.Name = "rdbtnDesigner";
            this.rdbtnDesigner.Size = new System.Drawing.Size(67, 17);
            this.rdbtnDesigner.TabIndex = 0;
            this.rdbtnDesigner.Text = "Designer";
            this.rdbtnDesigner.UseVisualStyleBackColor = true;
            this.rdbtnDesigner.CheckedChanged += new System.EventHandler(this.rdbtnDesigner_CheckedChanged);
            // 
            // frmOption
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 258);
            this.ControlBox = false;
            this.Controls.Add(this.gbUserRole);
            this.Controls.Add(this.gbColor);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmOption";
            this.Text = "Settings Form";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmOption_Load);
            this.gbColor.ResumeLayout(false);
            this.gbColor.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbUserRole.ResumeLayout(false);
            this.gbUserRole.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.CheckBox cbTop;
        private System.Windows.Forms.ColorDialog cdDialog;
        private System.Windows.Forms.GroupBox gbColor;
        private System.Windows.Forms.Button btnColorTask;
        private System.Windows.Forms.TextBox txtColorTask;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDefault;
        private System.Windows.Forms.Button btnTaskHoverColor;
        private System.Windows.Forms.TextBox txtTaskHoverColor;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnTaskSelectColor;
        private System.Windows.Forms.TextBox txtTaskSelectColor;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAdvance;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbUserRole;
        private System.Windows.Forms.RadioButton rdbtnExecutor;
        private System.Windows.Forms.RadioButton rdbtnDesigner;
    }
}