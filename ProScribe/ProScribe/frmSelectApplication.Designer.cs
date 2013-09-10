namespace Mockup2
{
    partial class frmSelectApplication
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
            this.pnControl = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.pnBody = new System.Windows.Forms.Panel();
            this.lvAppList = new System.Windows.Forms.ListView();
            this.name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pnControl.SuspendLayout();
            this.pnBody.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnControl
            // 
            this.pnControl.Controls.Add(this.btnCancel);
            this.pnControl.Controls.Add(this.btnOK);
            this.pnControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnControl.Location = new System.Drawing.Point(0, 263);
            this.pnControl.Name = "pnControl";
            this.pnControl.Size = new System.Drawing.Size(564, 39);
            this.pnControl.TabIndex = 5;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Image = global::Mockup2.Properties.Resources.ball_red;
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(477, 6);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Image = global::Mockup2.Properties.Resources.shop_cart;
            this.btnOK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOK.Location = new System.Drawing.Point(396, 6);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 0;
            this.btnOK.Text = "Select";
            this.btnOK.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // pnBody
            // 
            this.pnBody.Controls.Add(this.lvAppList);
            this.pnBody.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnBody.Location = new System.Drawing.Point(0, 0);
            this.pnBody.Name = "pnBody";
            this.pnBody.Size = new System.Drawing.Size(564, 263);
            this.pnBody.TabIndex = 4;
            // 
            // lvAppList
            // 
            this.lvAppList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvAppList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.name});
            this.lvAppList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvAppList.FullRowSelect = true;
            this.lvAppList.GridLines = true;
            this.lvAppList.Location = new System.Drawing.Point(0, 0);
            this.lvAppList.Name = "lvAppList";
            this.lvAppList.Size = new System.Drawing.Size(564, 263);
            this.lvAppList.TabIndex = 0;
            this.lvAppList.UseCompatibleStateImageBehavior = false;
            this.lvAppList.View = System.Windows.Forms.View.Details;
            // 
            // name
            // 
            this.name.Text = "Name";
            this.name.Width = 500;
            // 
            // frmSelectApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 302);
            this.Controls.Add(this.pnControl);
            this.Controls.Add(this.pnBody);
            this.Name = "frmSelectApplication";
            this.Text = "Application";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmSelectApplication_Load);
            this.pnControl.ResumeLayout(false);
            this.pnBody.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnControl;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Panel pnBody;
        private System.Windows.Forms.ListView lvAppList;
        private System.Windows.Forms.ColumnHeader name;
    }
}