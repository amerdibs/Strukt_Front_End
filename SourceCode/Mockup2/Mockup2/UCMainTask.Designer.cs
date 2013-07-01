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
            this.btnLink = new System.Windows.Forms.Button();
            this.btnProp = new System.Windows.Forms.Button();
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
            this.lbTitle.DoubleClick += new System.EventHandler(this.lbTitle_DoubleClick);
            // 
            // btnLink
            // 
            this.btnLink.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
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
            this.BackColor = System.Drawing.Color.Azure;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.btnLink);
            this.Controls.Add(this.btnProp);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.cbCheck);
            this.Name = "UCMainTask";
            this.Size = new System.Drawing.Size(318, 27);
            this.Load += new System.EventHandler(this.UCMainTask_Load);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.UCMainTask_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.UCMainTask_DragEnter);
            this.QueryContinueDrag += new System.Windows.Forms.QueryContinueDragEventHandler(this.UCMainTask_QueryContinueDrag);
            this.Leave += new System.EventHandler(this.UCMainTask_Leave);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.UCMainTask_MouseDown);
            this.MouseEnter += new System.EventHandler(this.UCMainTask_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.UCMainTask_MouseLeave);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cbCheck;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Button btnProp;
        private System.Windows.Forms.Button btnLink;
    }
}
