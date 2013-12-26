namespace ProcScribeOutlook
{
    partial class RibbonMenu : Microsoft.Office.Tools.Ribbon.RibbonBase
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public RibbonMenu()
            : base(Globals.Factory.GetRibbonFactory())
        {
            InitializeComponent();
        }

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
            this.tab1 = this.Factory.CreateRibbonTab();
            this.group1 = this.Factory.CreateRibbonGroup();
            this.rbtnDiscover = this.Factory.CreateRibbonButton();
            this.rbtnOption = this.Factory.CreateRibbonButton();
            this.tab1.SuspendLayout();
            this.group1.SuspendLayout();
            // 
            // tab1
            // 
            this.tab1.ControlId.ControlIdType = Microsoft.Office.Tools.Ribbon.RibbonControlIdType.Office;
            this.tab1.Groups.Add(this.group1);
            this.tab1.Label = "Proscribe";
            this.tab1.Name = "tab1";
            // 
            // group1
            // 
            this.group1.Items.Add(this.rbtnDiscover);
            this.group1.Items.Add(this.rbtnOption);
            this.group1.Label = "Proscribe";
            this.group1.Name = "group1";
            // 
            // rbtnDiscover
            // 
            this.rbtnDiscover.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.rbtnDiscover.Image = global::ProcScribeOutlook.Properties.Resources.file_find;
            this.rbtnDiscover.Label = "Discover";
            this.rbtnDiscover.Name = "rbtnDiscover";
            this.rbtnDiscover.ShowImage = true;
            this.rbtnDiscover.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.rbtnDiscover_Click);
            // 
            // rbtnOption
            // 
            this.rbtnOption.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.rbtnOption.Image = global::ProcScribeOutlook.Properties.Resources.applications;
            this.rbtnOption.Label = "Options";
            this.rbtnOption.Name = "rbtnOption";
            this.rbtnOption.ShowImage = true;
            this.rbtnOption.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.rbtnOption_Click);
            // 
            // RibbonMenu
            // 
            this.Name = "RibbonMenu";
            this.RibbonType = "Microsoft.Outlook.Explorer, Microsoft.Outlook.Mail.Read";
            this.Tabs.Add(this.tab1);
            this.Load += new Microsoft.Office.Tools.Ribbon.RibbonUIEventHandler(this.RibbonMenu_Load);
            this.tab1.ResumeLayout(false);
            this.tab1.PerformLayout();
            this.group1.ResumeLayout(false);
            this.group1.PerformLayout();

        }

        #endregion

        internal Microsoft.Office.Tools.Ribbon.RibbonTab tab1;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup group1;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton rbtnDiscover;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton rbtnOption;
    }

    partial class ThisRibbonCollection
    {
        internal RibbonMenu RibbonMenu
        {
            get { return this.GetRibbon<RibbonMenu>(); }
        }
    }
}
