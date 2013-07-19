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
            this.lAssign = new System.Windows.Forms.Label();
            this.lReceive = new System.Windows.Forms.Label();
            this.lbAssigned = new System.Windows.Forms.ListBox();
            this.pnAssigned = new System.Windows.Forms.Panel();
            this.btnSendtoReceiver = new System.Windows.Forms.Button();
            this.txtReceive = new System.Windows.Forms.TextBox();
            this.pnReceived = new System.Windows.Forms.Panel();
            this.btnSendtoAssigner = new System.Windows.Forms.Button();
            this.pbCollape = new System.Windows.Forms.PictureBox();
            this.btnLink = new System.Windows.Forms.Button();
            this.btnProp = new System.Windows.Forms.Button();
            this.pnAssigned.SuspendLayout();
            this.pnReceived.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCollape)).BeginInit();
            this.SuspendLayout();
            // 
            // cbCheck
            // 
            this.cbCheck.AutoSize = true;
            this.cbCheck.Location = new System.Drawing.Point(18, 4);
            this.cbCheck.Name = "cbCheck";
            this.cbCheck.Size = new System.Drawing.Size(15, 14);
            this.cbCheck.TabIndex = 0;
            this.cbCheck.UseVisualStyleBackColor = true;
            this.cbCheck.CheckStateChanged += new System.EventHandler(this.cbCheck_CheckStateChanged);
            this.cbCheck.Click += new System.EventHandler(this.cbCheck_Click);
            // 
            // lbTitle
            // 
            this.lbTitle.AllowDrop = true;
            this.lbTitle.AutoSize = true;
            this.lbTitle.BackColor = System.Drawing.Color.Transparent;
            this.lbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lbTitle.ForeColor = System.Drawing.Color.Black;
            this.lbTitle.Location = new System.Drawing.Point(39, 5);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(62, 13);
            this.lbTitle.TabIndex = 1;
            this.lbTitle.Text = "[New Task]";
            this.lbTitle.Click += new System.EventHandler(this.lbTitle_Click_1);
            this.lbTitle.DragDrop += new System.Windows.Forms.DragEventHandler(this.lbTitle_DragDrop);
            this.lbTitle.DragEnter += new System.Windows.Forms.DragEventHandler(this.lbTitle_DragEnter);
            // 
            // lAssign
            // 
            this.lAssign.AutoSize = true;
            this.lAssign.ForeColor = System.Drawing.Color.Crimson;
            this.lAssign.Location = new System.Drawing.Point(18, 3);
            this.lAssign.Name = "lAssign";
            this.lAssign.Size = new System.Drawing.Size(62, 13);
            this.lAssign.TabIndex = 4;
            this.lAssign.Text = "Assigned to";
            // 
            // lReceive
            // 
            this.lReceive.AutoSize = true;
            this.lReceive.ForeColor = System.Drawing.Color.Purple;
            this.lReceive.Location = new System.Drawing.Point(18, 2);
            this.lReceive.Name = "lReceive";
            this.lReceive.Size = new System.Drawing.Size(76, 13);
            this.lReceive.TabIndex = 5;
            this.lReceive.Text = "Received from";
            // 
            // lbAssigned
            // 
            this.lbAssigned.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lbAssigned.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbAssigned.FormattingEnabled = true;
            this.lbAssigned.Location = new System.Drawing.Point(18, 20);
            this.lbAssigned.Name = "lbAssigned";
            this.lbAssigned.ScrollAlwaysVisible = true;
            this.lbAssigned.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lbAssigned.Size = new System.Drawing.Size(144, 26);
            this.lbAssigned.TabIndex = 6;
            // 
            // pnAssigned
            // 
            this.pnAssigned.AllowDrop = true;
            this.pnAssigned.BackColor = System.Drawing.Color.Transparent;
            this.pnAssigned.Controls.Add(this.btnSendtoReceiver);
            this.pnAssigned.Controls.Add(this.lbAssigned);
            this.pnAssigned.Controls.Add(this.lAssign);
            this.pnAssigned.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnAssigned.Location = new System.Drawing.Point(0, 68);
            this.pnAssigned.Name = "pnAssigned";
            this.pnAssigned.Size = new System.Drawing.Size(320, 47);
            this.pnAssigned.TabIndex = 7;
            this.pnAssigned.Visible = false;
            this.pnAssigned.DragDrop += new System.Windows.Forms.DragEventHandler(this.pnAssigned_DragDrop);
            this.pnAssigned.DragEnter += new System.Windows.Forms.DragEventHandler(this.pnAssigned_DragEnter);
            // 
            // btnSendtoReceiver
            // 
            this.btnSendtoReceiver.Image = global::Mockup2.Properties.Resources.mail;
            this.btnSendtoReceiver.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSendtoReceiver.Location = new System.Drawing.Point(161, 20);
            this.btnSendtoReceiver.Name = "btnSendtoReceiver";
            this.btnSendtoReceiver.Size = new System.Drawing.Size(25, 23);
            this.btnSendtoReceiver.TabIndex = 9;
            this.btnSendtoReceiver.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSendtoReceiver.UseVisualStyleBackColor = true;
            this.btnSendtoReceiver.Click += new System.EventHandler(this.btnSendtoReceiver_Click);
            // 
            // txtReceive
            // 
            this.txtReceive.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtReceive.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtReceive.Enabled = false;
            this.txtReceive.Location = new System.Drawing.Point(18, 18);
            this.txtReceive.Name = "txtReceive";
            this.txtReceive.Size = new System.Drawing.Size(144, 13);
            this.txtReceive.TabIndex = 7;
            // 
            // pnReceived
            // 
            this.pnReceived.AllowDrop = true;
            this.pnReceived.BackColor = System.Drawing.Color.Transparent;
            this.pnReceived.Controls.Add(this.btnSendtoAssigner);
            this.pnReceived.Controls.Add(this.txtReceive);
            this.pnReceived.Controls.Add(this.lReceive);
            this.pnReceived.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnReceived.Location = new System.Drawing.Point(0, 29);
            this.pnReceived.Name = "pnReceived";
            this.pnReceived.Size = new System.Drawing.Size(320, 39);
            this.pnReceived.TabIndex = 8;
            this.pnReceived.Visible = false;
            this.pnReceived.DragDrop += new System.Windows.Forms.DragEventHandler(this.pnReceived_DragDrop);
            this.pnReceived.DragEnter += new System.Windows.Forms.DragEventHandler(this.pnReceived_DragEnter);
            // 
            // btnSendtoAssigner
            // 
            this.btnSendtoAssigner.Image = global::Mockup2.Properties.Resources.mail;
            this.btnSendtoAssigner.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSendtoAssigner.Location = new System.Drawing.Point(161, 13);
            this.btnSendtoAssigner.Name = "btnSendtoAssigner";
            this.btnSendtoAssigner.Size = new System.Drawing.Size(25, 23);
            this.btnSendtoAssigner.TabIndex = 8;
            this.btnSendtoAssigner.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSendtoAssigner.UseVisualStyleBackColor = true;
            this.btnSendtoAssigner.Click += new System.EventHandler(this.btnSendtoAssigner_Click);
            // 
            // pbCollape
            // 
            this.pbCollape.Image = global::Mockup2.Properties.Resources.collapes;
            this.pbCollape.Location = new System.Drawing.Point(2, 3);
            this.pbCollape.Margin = new System.Windows.Forms.Padding(0);
            this.pbCollape.Name = "pbCollape";
            this.pbCollape.Size = new System.Drawing.Size(15, 15);
            this.pbCollape.TabIndex = 9;
            this.pbCollape.TabStop = false;
            // 
            // btnLink
            // 
            this.btnLink.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLink.Enabled = false;
            this.btnLink.Image = global::Mockup2.Properties.Resources.web;
            this.btnLink.Location = new System.Drawing.Point(291, 0);
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
            this.btnProp.Location = new System.Drawing.Point(264, 0);
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
            this.Controls.Add(this.pbCollape);
            this.Controls.Add(this.btnLink);
            this.Controls.Add(this.btnProp);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.cbCheck);
            this.Controls.Add(this.pnReceived);
            this.Controls.Add(this.pnAssigned);
            this.Name = "UCMainTask";
            this.Size = new System.Drawing.Size(320, 115);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.UCMainTask_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.UCMainTask_DragEnter);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.UCMainTask_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.UCMainTask_MouseDown);
            this.MouseEnter += new System.EventHandler(this.UCMainTask_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.UCMainTask_MouseLeave);
            this.pnAssigned.ResumeLayout(false);
            this.pnAssigned.PerformLayout();
            this.pnReceived.ResumeLayout(false);
            this.pnReceived.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCollape)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cbCheck;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Button btnProp;
        private System.Windows.Forms.Button btnLink;
        private System.Windows.Forms.Label lAssign;
        private System.Windows.Forms.Label lReceive;
        private System.Windows.Forms.ListBox lbAssigned;
        private System.Windows.Forms.Panel pnAssigned;
        private System.Windows.Forms.TextBox txtReceive;
        private System.Windows.Forms.Panel pnReceived;
        private System.Windows.Forms.Button btnSendtoAssigner;
        private System.Windows.Forms.Button btnSendtoReceiver;
        private System.Windows.Forms.PictureBox pbCollape;
    }
}
