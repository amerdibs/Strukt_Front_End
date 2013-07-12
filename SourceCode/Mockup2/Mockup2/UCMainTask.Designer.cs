namespace Mockup2
{
    partial class UCMainTask
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cbCheck = new System.Windows.Forms.CheckBox();
            this.lbTitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbAssigned = new System.Windows.Forms.ListBox();
            this.pnAssign = new System.Windows.Forms.Panel();
            this.btnSendtoReceiver = new System.Windows.Forms.Button();
            this.txtReceive = new System.Windows.Forms.TextBox();
            this.pnReceive = new System.Windows.Forms.Panel();
            this.btnSendtoAssigner = new System.Windows.Forms.Button();
            this.btnLink = new System.Windows.Forms.Button();
            this.btnProp = new System.Windows.Forms.Button();
            this.pnAssign.SuspendLayout();
            this.pnReceive.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbCheck
            // 
            this.cbCheck.AutoSize = true;
            this.cbCheck.Location = new System.Drawing.Point(3, 3);
            this.cbCheck.Name = "cbCheck";
            this.cbCheck.Size = new System.Drawing.Size(15, 14);
            this.cbCheck.TabIndex = 0;
            this.cbCheck.UseVisualStyleBackColor = true;
            this.cbCheck.CheckedChanged += new System.EventHandler(this.cbCheck_CheckedChanged);
            this.cbCheck.Click += new System.EventHandler(this.cbCheck_Click);
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lbTitle.ForeColor = System.Drawing.Color.Black;
            this.lbTitle.Location = new System.Drawing.Point(24, 4);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(62, 13);
            this.lbTitle.TabIndex = 1;
            this.lbTitle.Text = "[New Task]";
            this.lbTitle.Click += new System.EventHandler(this.lbTitle_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Purple;
            this.label1.Location = new System.Drawing.Point(3, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Assigned to";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Purple;
            this.label2.Location = new System.Drawing.Point(3, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Received from";
            // 
            // lbAssigned
            // 
            this.lbAssigned.FormattingEnabled = true;
            this.lbAssigned.Location = new System.Drawing.Point(6, 24);
            this.lbAssigned.Name = "lbAssigned";
            this.lbAssigned.Size = new System.Drawing.Size(191, 43);
            this.lbAssigned.TabIndex = 6;
            // 
            // pnAssign
            // 
            this.pnAssign.Controls.Add(this.btnSendtoReceiver);
            this.pnAssign.Controls.Add(this.lbAssigned);
            this.pnAssign.Controls.Add(this.label1);
            this.pnAssign.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnAssign.Location = new System.Drawing.Point(0, 80);
            this.pnAssign.Name = "pnAssign";
            this.pnAssign.Size = new System.Drawing.Size(318, 80);
            this.pnAssign.TabIndex = 7;
            this.pnAssign.Visible = false;
            // 
            // btnSendtoReceiver
            // 
            this.btnSendtoReceiver.Image = global::Mockup2.Properties.Resources.mail;
            this.btnSendtoReceiver.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSendtoReceiver.Location = new System.Drawing.Point(227, 24);
            this.btnSendtoReceiver.Name = "btnSendtoReceiver";
            this.btnSendtoReceiver.Size = new System.Drawing.Size(77, 23);
            this.btnSendtoReceiver.TabIndex = 9;
            this.btnSendtoReceiver.Text = "Message";
            this.btnSendtoReceiver.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSendtoReceiver.UseVisualStyleBackColor = true;
            this.btnSendtoReceiver.Click += new System.EventHandler(this.btnSendtoReceiver_Click);
            // 
            // txtReceive
            // 
            this.txtReceive.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtReceive.Enabled = false;
            this.txtReceive.Location = new System.Drawing.Point(6, 22);
            this.txtReceive.Name = "txtReceive";
            this.txtReceive.Size = new System.Drawing.Size(191, 20);
            this.txtReceive.TabIndex = 7;
            this.txtReceive.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pnReceive
            // 
            this.pnReceive.Controls.Add(this.btnSendtoAssigner);
            this.pnReceive.Controls.Add(this.txtReceive);
            this.pnReceive.Controls.Add(this.label2);
            this.pnReceive.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnReceive.Location = new System.Drawing.Point(0, 30);
            this.pnReceive.Name = "pnReceive";
            this.pnReceive.Size = new System.Drawing.Size(318, 50);
            this.pnReceive.TabIndex = 8;
            this.pnReceive.Visible = false;
            // 
            // btnSendtoAssigner
            // 
            this.btnSendtoAssigner.Image = global::Mockup2.Properties.Resources.mail;
            this.btnSendtoAssigner.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSendtoAssigner.Location = new System.Drawing.Point(227, 22);
            this.btnSendtoAssigner.Name = "btnSendtoAssigner";
            this.btnSendtoAssigner.Size = new System.Drawing.Size(77, 23);
            this.btnSendtoAssigner.TabIndex = 8;
            this.btnSendtoAssigner.Text = "Message";
            this.btnSendtoAssigner.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSendtoAssigner.UseVisualStyleBackColor = true;
            this.btnSendtoAssigner.Click += new System.EventHandler(this.btnSendtoAssigner_Click);
            // 
            // btnLink
            // 
            this.btnLink.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLink.Enabled = false;
            this.btnLink.Image = global::Mockup2.Properties.Resources.web;
            this.btnLink.Location = new System.Drawing.Point(260, 1);
            this.btnLink.Name = "btnLink";
            this.btnLink.Size = new System.Drawing.Size(28, 23);
            this.btnLink.TabIndex = 3;
            this.btnLink.UseVisualStyleBackColor = true;
            this.btnLink.Click += new System.EventHandler(this.btnLink_Click);
            // 
            // btnProp
            // 
            this.btnProp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnProp.Image = global::Mockup2.Properties.Resources.edit;
            this.btnProp.Location = new System.Drawing.Point(287, 1);
            this.btnProp.Name = "btnProp";
            this.btnProp.Size = new System.Drawing.Size(28, 23);
            this.btnProp.TabIndex = 2;
            this.btnProp.UseVisualStyleBackColor = true;
            this.btnProp.Click += new System.EventHandler(this.btnProp_Click);
            // 
            // UCMainTask
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.btnLink);
            this.Controls.Add(this.btnProp);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.cbCheck);
            this.Controls.Add(this.pnReceive);
            this.Controls.Add(this.pnAssign);
            this.Name = "UCMainTask";
            this.Size = new System.Drawing.Size(318, 160);
            this.Load += new System.EventHandler(this.UCMainTask_Load);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.UCMainTask_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.UCMainTask_DragEnter);
            this.QueryContinueDrag += new System.Windows.Forms.QueryContinueDragEventHandler(this.UCMainTask_QueryContinueDrag);
            this.Leave += new System.EventHandler(this.UCMainTask_Leave);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.UCMainTask_MouseDown);
            this.MouseEnter += new System.EventHandler(this.UCMainTask_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.UCMainTask_MouseLeave);
            this.pnAssign.ResumeLayout(false);
            this.pnAssign.PerformLayout();
            this.pnReceive.ResumeLayout(false);
            this.pnReceive.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cbCheck;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Button btnProp;
        private System.Windows.Forms.Button btnLink;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lbAssigned;
        private System.Windows.Forms.Panel pnAssign;
        private System.Windows.Forms.TextBox txtReceive;
        private System.Windows.Forms.Panel pnReceive;
        private System.Windows.Forms.Button btnSendtoAssigner;
        private System.Windows.Forms.Button btnSendtoReceiver;
    }
}
