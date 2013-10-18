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
            this.btnColorText4 = new System.Windows.Forms.Button();
            this.btnColorText3 = new System.Windows.Forms.Button();
            this.btnColorText2 = new System.Windows.Forms.Button();
            this.btnColorText1 = new System.Windows.Forms.Button();
            this.txtColorText4 = new System.Windows.Forms.TextBox();
            this.txtColorText3 = new System.Windows.Forms.TextBox();
            this.txtColorText2 = new System.Windows.Forms.TextBox();
            this.txtColorText1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnColorBack = new System.Windows.Forms.Button();
            this.btnColorTask = new System.Windows.Forms.Button();
            this.txtColorTask = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtColorBack = new System.Windows.Forms.TextBox();
            this.btnDefault = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnTaskSelectColor = new System.Windows.Forms.Button();
            this.txtTaskSelectColor = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnTaskHoverColor = new System.Windows.Forms.Button();
            this.txtTaskHoverColor = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnAdvance = new System.Windows.Forms.Button();
            this.gbColor.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(195, 35);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(89, 23);
            this.btnOK.TabIndex = 0;
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
            this.gbColor.Controls.Add(this.btnTaskHoverColor);
            this.gbColor.Controls.Add(this.txtTaskHoverColor);
            this.gbColor.Controls.Add(this.btnDefault);
            this.gbColor.Controls.Add(this.label8);
            this.gbColor.Controls.Add(this.btnTaskSelectColor);
            this.gbColor.Controls.Add(this.txtTaskSelectColor);
            this.gbColor.Controls.Add(this.label7);
            this.gbColor.Controls.Add(this.btnColorText4);
            this.gbColor.Controls.Add(this.btnColorText3);
            this.gbColor.Controls.Add(this.btnColorText2);
            this.gbColor.Controls.Add(this.btnColorText1);
            this.gbColor.Controls.Add(this.txtColorText4);
            this.gbColor.Controls.Add(this.txtColorText3);
            this.gbColor.Controls.Add(this.txtColorText2);
            this.gbColor.Controls.Add(this.txtColorText1);
            this.gbColor.Controls.Add(this.label6);
            this.gbColor.Controls.Add(this.label5);
            this.gbColor.Controls.Add(this.label4);
            this.gbColor.Controls.Add(this.label3);
            this.gbColor.Controls.Add(this.btnColorBack);
            this.gbColor.Controls.Add(this.btnColorTask);
            this.gbColor.Controls.Add(this.txtColorTask);
            this.gbColor.Controls.Add(this.label2);
            this.gbColor.Controls.Add(this.label1);
            this.gbColor.Controls.Add(this.txtColorBack);
            this.gbColor.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbColor.Location = new System.Drawing.Point(0, 64);
            this.gbColor.Name = "gbColor";
            this.gbColor.Size = new System.Drawing.Size(284, 260);
            this.gbColor.TabIndex = 9;
            this.gbColor.TabStop = false;
            this.gbColor.Text = "Color";
            this.gbColor.Visible = false;
            // 
            // btnColorText4
            // 
            this.btnColorText4.Location = new System.Drawing.Point(171, 198);
            this.btnColorText4.Name = "btnColorText4";
            this.btnColorText4.Size = new System.Drawing.Size(83, 23);
            this.btnColorText4.TabIndex = 27;
            this.btnColorText4.Text = "Choose color";
            this.btnColorText4.UseVisualStyleBackColor = true;
            this.btnColorText4.Click += new System.EventHandler(this.btnColorText4_Click);
            // 
            // btnColorText3
            // 
            this.btnColorText3.Location = new System.Drawing.Point(171, 174);
            this.btnColorText3.Name = "btnColorText3";
            this.btnColorText3.Size = new System.Drawing.Size(83, 23);
            this.btnColorText3.TabIndex = 26;
            this.btnColorText3.Text = "Choose color";
            this.btnColorText3.UseVisualStyleBackColor = true;
            this.btnColorText3.Click += new System.EventHandler(this.btnColorText3_Click);
            // 
            // btnColorText2
            // 
            this.btnColorText2.Location = new System.Drawing.Point(171, 151);
            this.btnColorText2.Name = "btnColorText2";
            this.btnColorText2.Size = new System.Drawing.Size(83, 23);
            this.btnColorText2.TabIndex = 25;
            this.btnColorText2.Text = "Choose color";
            this.btnColorText2.UseVisualStyleBackColor = true;
            this.btnColorText2.Click += new System.EventHandler(this.btnColorText2_Click);
            // 
            // btnColorText1
            // 
            this.btnColorText1.Location = new System.Drawing.Point(171, 127);
            this.btnColorText1.Name = "btnColorText1";
            this.btnColorText1.Size = new System.Drawing.Size(83, 23);
            this.btnColorText1.TabIndex = 24;
            this.btnColorText1.Text = "Choose color";
            this.btnColorText1.UseVisualStyleBackColor = true;
            this.btnColorText1.Click += new System.EventHandler(this.btnColorText1_Click);
            // 
            // txtColorText4
            // 
            this.txtColorText4.Location = new System.Drawing.Point(104, 200);
            this.txtColorText4.Name = "txtColorText4";
            this.txtColorText4.ReadOnly = true;
            this.txtColorText4.Size = new System.Drawing.Size(53, 20);
            this.txtColorText4.TabIndex = 23;
            // 
            // txtColorText3
            // 
            this.txtColorText3.Location = new System.Drawing.Point(104, 176);
            this.txtColorText3.Name = "txtColorText3";
            this.txtColorText3.ReadOnly = true;
            this.txtColorText3.Size = new System.Drawing.Size(53, 20);
            this.txtColorText3.TabIndex = 22;
            // 
            // txtColorText2
            // 
            this.txtColorText2.Location = new System.Drawing.Point(104, 153);
            this.txtColorText2.Name = "txtColorText2";
            this.txtColorText2.ReadOnly = true;
            this.txtColorText2.Size = new System.Drawing.Size(53, 20);
            this.txtColorText2.TabIndex = 21;
            // 
            // txtColorText1
            // 
            this.txtColorText1.Location = new System.Drawing.Point(104, 129);
            this.txtColorText1.Name = "txtColorText1";
            this.txtColorText1.ReadOnly = true;
            this.txtColorText1.Size = new System.Drawing.Size(53, 20);
            this.txtColorText1.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 203);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Text Color Level 4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Text Color Level 3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Text Color Level 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Text Color Level 1";
            // 
            // btnColorBack
            // 
            this.btnColorBack.Location = new System.Drawing.Point(171, 18);
            this.btnColorBack.Name = "btnColorBack";
            this.btnColorBack.Size = new System.Drawing.Size(83, 23);
            this.btnColorBack.TabIndex = 15;
            this.btnColorBack.Text = "Choose color";
            this.btnColorBack.UseVisualStyleBackColor = true;
            this.btnColorBack.Click += new System.EventHandler(this.btnColorBack_Click);
            // 
            // btnColorTask
            // 
            this.btnColorTask.Location = new System.Drawing.Point(171, 48);
            this.btnColorTask.Name = "btnColorTask";
            this.btnColorTask.Size = new System.Drawing.Size(83, 23);
            this.btnColorTask.TabIndex = 14;
            this.btnColorTask.Text = "Choose color";
            this.btnColorTask.UseVisualStyleBackColor = true;
            this.btnColorTask.Click += new System.EventHandler(this.btnColorTask_Click);
            // 
            // txtColorTask
            // 
            this.txtColorTask.Location = new System.Drawing.Point(104, 50);
            this.txtColorTask.Name = "txtColorTask";
            this.txtColorTask.ReadOnly = true;
            this.txtColorTask.Size = new System.Drawing.Size(53, 20);
            this.txtColorTask.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Task Color";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Background Color";
            // 
            // txtColorBack
            // 
            this.txtColorBack.Location = new System.Drawing.Point(104, 20);
            this.txtColorBack.Name = "txtColorBack";
            this.txtColorBack.ReadOnly = true;
            this.txtColorBack.Size = new System.Drawing.Size(53, 20);
            this.txtColorBack.TabIndex = 9;
            // 
            // btnDefault
            // 
            this.btnDefault.Location = new System.Drawing.Point(171, 227);
            this.btnDefault.Name = "btnDefault";
            this.btnDefault.Size = new System.Drawing.Size(89, 23);
            this.btnDefault.TabIndex = 13;
            this.btnDefault.Text = "Back to default";
            this.btnDefault.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAdvance);
            this.groupBox1.Controls.Add(this.btnOK);
            this.groupBox1.Controls.Add(this.cbTop);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(284, 64);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            // 
            // btnTaskSelectColor
            // 
            this.btnTaskSelectColor.Location = new System.Drawing.Point(171, 73);
            this.btnTaskSelectColor.Name = "btnTaskSelectColor";
            this.btnTaskSelectColor.Size = new System.Drawing.Size(83, 23);
            this.btnTaskSelectColor.TabIndex = 30;
            this.btnTaskSelectColor.Text = "Choose color";
            this.btnTaskSelectColor.UseVisualStyleBackColor = true;
            this.btnTaskSelectColor.Click += new System.EventHandler(this.btnTaskSelectColor_Click);
            // 
            // txtTaskSelectColor
            // 
            this.txtTaskSelectColor.Location = new System.Drawing.Point(104, 75);
            this.txtTaskSelectColor.Name = "txtTaskSelectColor";
            this.txtTaskSelectColor.ReadOnly = true;
            this.txtTaskSelectColor.Size = new System.Drawing.Size(53, 20);
            this.txtTaskSelectColor.TabIndex = 29;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 78);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 13);
            this.label7.TabIndex = 28;
            this.label7.Text = "Task Select Color";
            // 
            // btnTaskHoverColor
            // 
            this.btnTaskHoverColor.Location = new System.Drawing.Point(171, 98);
            this.btnTaskHoverColor.Name = "btnTaskHoverColor";
            this.btnTaskHoverColor.Size = new System.Drawing.Size(83, 23);
            this.btnTaskHoverColor.TabIndex = 33;
            this.btnTaskHoverColor.Text = "Choose color";
            this.btnTaskHoverColor.UseVisualStyleBackColor = true;
            // 
            // txtTaskHoverColor
            // 
            this.txtTaskHoverColor.Location = new System.Drawing.Point(104, 100);
            this.txtTaskHoverColor.Name = "txtTaskHoverColor";
            this.txtTaskHoverColor.ReadOnly = true;
            this.txtTaskHoverColor.Size = new System.Drawing.Size(53, 20);
            this.txtTaskHoverColor.TabIndex = 32;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 103);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 13);
            this.label8.TabIndex = 31;
            this.label8.Text = "Task Hover Color";
            // 
            // btnAdvance
            // 
            this.btnAdvance.Location = new System.Drawing.Point(100, 35);
            this.btnAdvance.Name = "btnAdvance";
            this.btnAdvance.Size = new System.Drawing.Size(89, 23);
            this.btnAdvance.TabIndex = 2;
            this.btnAdvance.Text = "Advance";
            this.btnAdvance.UseVisualStyleBackColor = true;
            this.btnAdvance.Click += new System.EventHandler(this.btnAdvance_Click);
            // 
            // frmOption
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 363);
            this.ControlBox = false;
            this.Controls.Add(this.gbColor);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmOption";
            this.Text = "Option";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmOption_Load);
            this.gbColor.ResumeLayout(false);
            this.gbColor.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.CheckBox cbTop;
        private System.Windows.Forms.ColorDialog cdDialog;
        private System.Windows.Forms.GroupBox gbColor;
        private System.Windows.Forms.Button btnColorText4;
        private System.Windows.Forms.Button btnColorText3;
        private System.Windows.Forms.Button btnColorText2;
        private System.Windows.Forms.Button btnColorText1;
        private System.Windows.Forms.TextBox txtColorText4;
        private System.Windows.Forms.TextBox txtColorText3;
        private System.Windows.Forms.TextBox txtColorText2;
        private System.Windows.Forms.TextBox txtColorText1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnColorBack;
        private System.Windows.Forms.Button btnColorTask;
        private System.Windows.Forms.TextBox txtColorTask;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtColorBack;
        private System.Windows.Forms.Button btnDefault;
        private System.Windows.Forms.Button btnTaskHoverColor;
        private System.Windows.Forms.TextBox txtTaskHoverColor;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnTaskSelectColor;
        private System.Windows.Forms.TextBox txtTaskSelectColor;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAdvance;
    }
}