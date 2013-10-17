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
            this.btnColorBack = new System.Windows.Forms.Button();
            this.btnColorTask = new System.Windows.Forms.Button();
            this.btnDefault = new System.Windows.Forms.Button();
            this.txtColorTask = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtColorBack = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtColorText1 = new System.Windows.Forms.TextBox();
            this.txtColorText2 = new System.Windows.Forms.TextBox();
            this.txtColorText3 = new System.Windows.Forms.TextBox();
            this.txtColorText4 = new System.Windows.Forms.TextBox();
            this.btnColorText1 = new System.Windows.Forms.Button();
            this.btnColorText2 = new System.Windows.Forms.Button();
            this.btnColorText3 = new System.Windows.Forms.Button();
            this.btnColorText4 = new System.Windows.Forms.Button();
            this.gbColor.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(183, 274);
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
            this.gbColor.Location = new System.Drawing.Point(12, 35);
            this.gbColor.Name = "gbColor";
            this.gbColor.Size = new System.Drawing.Size(260, 196);
            this.gbColor.TabIndex = 9;
            this.gbColor.TabStop = false;
            this.gbColor.Text = "Color";
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
            // btnDefault
            // 
            this.btnDefault.Location = new System.Drawing.Point(183, 245);
            this.btnDefault.Name = "btnDefault";
            this.btnDefault.Size = new System.Drawing.Size(89, 23);
            this.btnDefault.TabIndex = 13;
            this.btnDefault.Text = "Back to default";
            this.btnDefault.UseVisualStyleBackColor = true;
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Text Color Level 1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Text Color Level 2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Text Color Level 3";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 161);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Text Color Level 4";
            // 
            // txtColorText1
            // 
            this.txtColorText1.Location = new System.Drawing.Point(104, 87);
            this.txtColorText1.Name = "txtColorText1";
            this.txtColorText1.ReadOnly = true;
            this.txtColorText1.Size = new System.Drawing.Size(53, 20);
            this.txtColorText1.TabIndex = 20;
            // 
            // txtColorText2
            // 
            this.txtColorText2.Location = new System.Drawing.Point(104, 111);
            this.txtColorText2.Name = "txtColorText2";
            this.txtColorText2.ReadOnly = true;
            this.txtColorText2.Size = new System.Drawing.Size(53, 20);
            this.txtColorText2.TabIndex = 21;
            // 
            // txtColorText3
            // 
            this.txtColorText3.Location = new System.Drawing.Point(104, 134);
            this.txtColorText3.Name = "txtColorText3";
            this.txtColorText3.ReadOnly = true;
            this.txtColorText3.Size = new System.Drawing.Size(53, 20);
            this.txtColorText3.TabIndex = 22;
            // 
            // txtColorText4
            // 
            this.txtColorText4.Location = new System.Drawing.Point(104, 158);
            this.txtColorText4.Name = "txtColorText4";
            this.txtColorText4.ReadOnly = true;
            this.txtColorText4.Size = new System.Drawing.Size(53, 20);
            this.txtColorText4.TabIndex = 23;
            // 
            // btnColorText1
            // 
            this.btnColorText1.Location = new System.Drawing.Point(171, 85);
            this.btnColorText1.Name = "btnColorText1";
            this.btnColorText1.Size = new System.Drawing.Size(83, 23);
            this.btnColorText1.TabIndex = 24;
            this.btnColorText1.Text = "Choose color";
            this.btnColorText1.UseVisualStyleBackColor = true;
            this.btnColorText1.Click += new System.EventHandler(this.btnColorText1_Click);
            // 
            // btnColorText2
            // 
            this.btnColorText2.Location = new System.Drawing.Point(171, 109);
            this.btnColorText2.Name = "btnColorText2";
            this.btnColorText2.Size = new System.Drawing.Size(83, 23);
            this.btnColorText2.TabIndex = 25;
            this.btnColorText2.Text = "Choose color";
            this.btnColorText2.UseVisualStyleBackColor = true;
            this.btnColorText2.Click += new System.EventHandler(this.btnColorText2_Click);
            // 
            // btnColorText3
            // 
            this.btnColorText3.Location = new System.Drawing.Point(171, 132);
            this.btnColorText3.Name = "btnColorText3";
            this.btnColorText3.Size = new System.Drawing.Size(83, 23);
            this.btnColorText3.TabIndex = 26;
            this.btnColorText3.Text = "Choose color";
            this.btnColorText3.UseVisualStyleBackColor = true;
            this.btnColorText3.Click += new System.EventHandler(this.btnColorText3_Click);
            // 
            // btnColorText4
            // 
            this.btnColorText4.Location = new System.Drawing.Point(171, 156);
            this.btnColorText4.Name = "btnColorText4";
            this.btnColorText4.Size = new System.Drawing.Size(83, 23);
            this.btnColorText4.TabIndex = 27;
            this.btnColorText4.Text = "Choose color";
            this.btnColorText4.UseVisualStyleBackColor = true;
            this.btnColorText4.Click += new System.EventHandler(this.btnColorText4_Click);
            // 
            // frmOption
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 309);
            this.ControlBox = false;
            this.Controls.Add(this.gbColor);
            this.Controls.Add(this.cbTop);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnDefault);
            this.Name = "frmOption";
            this.Text = "Option";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmOption_Load);
            this.gbColor.ResumeLayout(false);
            this.gbColor.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}