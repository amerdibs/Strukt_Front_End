namespace Mockup2
{
    partial class UCSubTask
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
            this.lbTitle = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.btnProp = new System.Windows.Forms.Button();
            this.btnLink = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Location = new System.Drawing.Point(49, 4);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(90, 13);
            this.lbTitle.TabIndex = 6;
            this.lbTitle.Text = "[Sub Task Name]";
            this.lbTitle.Click += new System.EventHandler(this.lbTitle_Click_1);
            this.lbTitle.DoubleClick += new System.EventHandler(this.lbTitle_DoubleClick);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(28, 3);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(15, 14);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // btnProp
            // 
            this.btnProp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnProp.Image = global::Mockup2.Properties.Resources.edit;
            this.btnProp.Location = new System.Drawing.Point(261, 1);
            this.btnProp.Name = "btnProp";
            this.btnProp.Size = new System.Drawing.Size(28, 23);
            this.btnProp.TabIndex = 7;
            this.btnProp.UseVisualStyleBackColor = true;
            this.btnProp.Click += new System.EventHandler(this.btnProp_Click);
            // 
            // btnLink
            // 
            this.btnLink.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLink.Image = global::Mockup2.Properties.Resources.web;
            this.btnLink.Location = new System.Drawing.Point(288, 1);
            this.btnLink.Name = "btnLink";
            this.btnLink.Size = new System.Drawing.Size(28, 23);
            this.btnLink.TabIndex = 8;
            this.btnLink.UseVisualStyleBackColor = true;
            this.btnLink.Click += new System.EventHandler(this.btnLink_Click);
            // 
            // UCSubTask
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.btnLink);
            this.Controls.Add(this.btnProp);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.checkBox1);
            this.Name = "UCSubTask";
            this.Size = new System.Drawing.Size(316, 25);
            this.Load += new System.EventHandler(this.UCSubTask_Load);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.UCSubTask_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.UCSubTask_DragEnter);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.UCSubTask_MouseDown);
            this.MouseEnter += new System.EventHandler(this.UCSubTask_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.UCSubTask_MouseLeave);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnProp;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button btnLink;
    }
}
