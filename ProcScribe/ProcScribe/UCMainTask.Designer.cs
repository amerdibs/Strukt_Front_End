namespace ProcScribe
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
            this.components = new System.ComponentModel.Container();
            this.cbCheck = new System.Windows.Forms.CheckBox();
            this.lbTitle = new System.Windows.Forms.Label();
            this.ttTaskControl = new System.Windows.Forms.ToolTip(this.components);
            this.pbDesc = new System.Windows.Forms.PictureBox();
            this.pbCollape = new System.Windows.Forms.PictureBox();
            this.btnLink = new System.Windows.Forms.Button();
            this.btnProp = new System.Windows.Forms.Button();
            this.lbDesc = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbDesc)).BeginInit();
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
            this.lbTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbTitle.AutoEllipsis = true;
            this.lbTitle.BackColor = System.Drawing.Color.Transparent;
            this.lbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lbTitle.ForeColor = System.Drawing.Color.Black;
            this.lbTitle.Location = new System.Drawing.Point(34, 3);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(213, 14);
            this.lbTitle.TabIndex = 1;
            this.lbTitle.Text = "[New Task]";
            this.lbTitle.DragDrop += new System.Windows.Forms.DragEventHandler(this.lbTitle_DragDrop);
            this.lbTitle.DragEnter += new System.Windows.Forms.DragEventHandler(this.lbTitle_DragEnter);
            this.lbTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lbTitle_MouseDown);
            // 
            // pbDesc
            // 
            this.pbDesc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbDesc.Image = global::ProcScribe.Properties.Resources.bt_play10pix;
            this.pbDesc.Location = new System.Drawing.Point(252, 11);
            this.pbDesc.Name = "pbDesc";
            this.pbDesc.Size = new System.Drawing.Size(12, 12);
            this.pbDesc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbDesc.TabIndex = 10;
            this.pbDesc.TabStop = false;
            this.pbDesc.Click += new System.EventHandler(this.pbDesc_Click);
            // 
            // pbCollape
            // 
            this.pbCollape.Image = global::ProcScribe.Properties.Resources.collapes;
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
            this.btnLink.Image = global::ProcScribe.Properties.Resources.network_find1;
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
            this.btnProp.Image = global::ProcScribe.Properties.Resources.applications;
            this.btnProp.Location = new System.Drawing.Point(264, 0);
            this.btnProp.Name = "btnProp";
            this.btnProp.Size = new System.Drawing.Size(28, 23);
            this.btnProp.TabIndex = 2;
            this.btnProp.UseVisualStyleBackColor = true;
            this.btnProp.Click += new System.EventHandler(this.btnProp_Click);
            // 
            // lbDesc
            // 
            this.lbDesc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbDesc.AutoEllipsis = true;
            this.lbDesc.ForeColor = System.Drawing.Color.MediumBlue;
            this.lbDesc.Location = new System.Drawing.Point(15, 26);
            this.lbDesc.Name = "lbDesc";
            this.lbDesc.Size = new System.Drawing.Size(292, 29);
            this.lbDesc.TabIndex = 11;
            // 
            // UCMainTask
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.lbDesc);
            this.Controls.Add(this.pbDesc);
            this.Controls.Add(this.pbCollape);
            this.Controls.Add(this.btnLink);
            this.Controls.Add(this.btnProp);
            this.Controls.Add(this.cbCheck);
            this.Name = "UCMainTask";
            this.Size = new System.Drawing.Size(320, 27);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.UCMainTask_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.UCMainTask_DragEnter);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.UCMainTask_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.UCMainTask_MouseDown);
            this.MouseEnter += new System.EventHandler(this.UCMainTask_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.UCMainTask_MouseLeave);
            ((System.ComponentModel.ISupportInitialize)(this.pbDesc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCollape)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cbCheck;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Button btnProp;
        private System.Windows.Forms.Button btnLink;
        private System.Windows.Forms.PictureBox pbCollape;
        private System.Windows.Forms.ToolTip ttTaskControl;
        private System.Windows.Forms.PictureBox pbDesc;
        private System.Windows.Forms.Label lbDesc;
    }
}
