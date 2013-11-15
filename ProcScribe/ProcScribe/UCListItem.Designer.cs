namespace ProcScribe
{
    partial class UCListItem
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
            this.lbTaskName = new System.Windows.Forms.Label();
            this.lbTaskKey = new System.Windows.Forms.Label();
            this.lbkeyword = new System.Windows.Forms.Label();
            this.lbTaskDesc = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbTaskName
            // 
            this.lbTaskName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbTaskName.AutoEllipsis = true;
            this.lbTaskName.BackColor = System.Drawing.Color.Transparent;
            this.lbTaskName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lbTaskName.ForeColor = System.Drawing.Color.Black;
            this.lbTaskName.Location = new System.Drawing.Point(3, 0);
            this.lbTaskName.Name = "lbTaskName";
            this.lbTaskName.Size = new System.Drawing.Size(299, 14);
            this.lbTaskName.TabIndex = 2;
            this.lbTaskName.Text = "[Task Name]";
            this.lbTaskName.MouseEnter += new System.EventHandler(this.lbTaskName_MouseEnter);
            this.lbTaskName.MouseLeave += new System.EventHandler(this.lbTaskName_MouseLeave);
            // 
            // lbTaskKey
            // 
            this.lbTaskKey.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbTaskKey.AutoEllipsis = true;
            this.lbTaskKey.BackColor = System.Drawing.Color.Transparent;
            this.lbTaskKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lbTaskKey.ForeColor = System.Drawing.Color.DimGray;
            this.lbTaskKey.Location = new System.Drawing.Point(49, 45);
            this.lbTaskKey.Name = "lbTaskKey";
            this.lbTaskKey.Size = new System.Drawing.Size(253, 13);
            this.lbTaskKey.TabIndex = 4;
            this.lbTaskKey.Text = "[Task Keyword]";
            // 
            // lbkeyword
            // 
            this.lbkeyword.AutoSize = true;
            this.lbkeyword.BackColor = System.Drawing.Color.Transparent;
            this.lbkeyword.ForeColor = System.Drawing.Color.DimGray;
            this.lbkeyword.Location = new System.Drawing.Point(6, 45);
            this.lbkeyword.Name = "lbkeyword";
            this.lbkeyword.Size = new System.Drawing.Size(47, 13);
            this.lbkeyword.TabIndex = 5;
            this.lbkeyword.Text = "keyword";
            // 
            // lbTaskDesc
            // 
            this.lbTaskDesc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbTaskDesc.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lbTaskDesc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbTaskDesc.Location = new System.Drawing.Point(5, 15);
            this.lbTaskDesc.Multiline = true;
            this.lbTaskDesc.Name = "lbTaskDesc";
            this.lbTaskDesc.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.lbTaskDesc.Size = new System.Drawing.Size(299, 27);
            this.lbTaskDesc.TabIndex = 6;
            // 
            // UCListItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.lbTaskDesc);
            this.Controls.Add(this.lbkeyword);
            this.Controls.Add(this.lbTaskKey);
            this.Controls.Add(this.lbTaskName);
            this.Name = "UCListItem";
            this.Size = new System.Drawing.Size(320, 66);
            this.MouseEnter += new System.EventHandler(this.UCListItem_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.UCListItem_MouseLeave);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTaskName;
        private System.Windows.Forms.Label lbTaskKey;
        private System.Windows.Forms.Label lbkeyword;
        private System.Windows.Forms.TextBox lbTaskDesc;
    }
}
