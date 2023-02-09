
namespace HRDatabaseTEST
{
    partial class HRDocMgr
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
            this.components = new System.ComponentModel.Container();
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.HRForm = new DevExpress.XtraBars.BarButtonItem();
            this.AttendenceForm = new DevExpress.XtraBars.BarButtonItem();
            this.ReportMainForm = new DevExpress.XtraBars.BarButtonItem();
            this.LogoutBtn = new DevExpress.XtraBars.BarButtonItem();
            this.GeneralRibbon = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.EmpInfoGrp = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ReportGrp = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.OptionRibbon = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.documentManager = new DevExpress.XtraBars.Docking2010.DocumentManager(this.components);
            this.tabbedView1 = new DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.EmptyAreaImageOptions.ImagePadding = new System.Windows.Forms.Padding(35, 37, 35, 37);
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.ribbon.SearchEditItem,
            this.HRForm,
            this.AttendenceForm,
            this.ReportMainForm,
            this.LogoutBtn});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ribbon.MaxItemId = 6;
            this.ribbon.Name = "ribbon";
            this.ribbon.OptionsMenuMinWidth = 385;
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.GeneralRibbon,
            this.OptionRibbon});
            this.ribbon.Size = new System.Drawing.Size(905, 193);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            // 
            // HRForm
            // 
            this.HRForm.Caption = "Employee";
            this.HRForm.Id = 1;
            this.HRForm.ImageOptions.SvgImage = global::HRDatabaseTEST.Properties.Resources.bo_lead;
            this.HRForm.Name = "HRForm";
            this.HRForm.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.HRForm_ItemClick);
            // 
            // AttendenceForm
            // 
            this.AttendenceForm.Caption = "Attendence List";
            this.AttendenceForm.Id = 2;
            this.AttendenceForm.ImageOptions.SvgImage = global::HRDatabaseTEST.Properties.Resources.singlepageview;
            this.AttendenceForm.Name = "AttendenceForm";
            this.AttendenceForm.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.AttendenceForm_ItemClick);
            // 
            // ReportMainForm
            // 
            this.ReportMainForm.Caption = "Report";
            this.ReportMainForm.Id = 4;
            this.ReportMainForm.ImageOptions.SvgImage = global::HRDatabaseTEST.Properties.Resources.employeesummary;
            this.ReportMainForm.Name = "ReportMainForm";
            this.ReportMainForm.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.ReportMainForm_ItemClick);
            // 
            // LogoutBtn
            // 
            this.LogoutBtn.Caption = "Log Out";
            this.LogoutBtn.Id = 5;
            this.LogoutBtn.ImageOptions.SvgImage = global::HRDatabaseTEST.Properties.Resources.close;
            this.LogoutBtn.Name = "LogoutBtn";
            this.LogoutBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.LogoutBtn_ItemClick);
            // 
            // GeneralRibbon
            // 
            this.GeneralRibbon.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.EmpInfoGrp,
            this.ReportGrp,
            this.ribbonPageGroup2});
            this.GeneralRibbon.Name = "GeneralRibbon";
            this.GeneralRibbon.Text = "General";
            // 
            // EmpInfoGrp
            // 
            this.EmpInfoGrp.AllowTextClipping = false;
            this.EmpInfoGrp.ItemLinks.Add(this.HRForm);
            this.EmpInfoGrp.ItemLinks.Add(this.AttendenceForm);
            this.EmpInfoGrp.Name = "EmpInfoGrp";
            this.EmpInfoGrp.Text = "Employee Information";
            // 
            // ReportGrp
            // 
            this.ReportGrp.AllowTextClipping = false;
            this.ReportGrp.ItemLinks.Add(this.ReportMainForm);
            this.ReportGrp.Name = "ReportGrp";
            this.ReportGrp.Text = "Report Information";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.AllowTextClipping = false;
            this.ribbonPageGroup2.ItemLinks.Add(this.LogoutBtn);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            // 
            // OptionRibbon
            // 
            this.OptionRibbon.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.OptionRibbon.Name = "OptionRibbon";
            this.OptionRibbon.Text = "Option";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "ribbonPageGroup1";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 685);
            this.ribbonStatusBar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(905, 30);
            // 
            // documentManager
            // 
            this.documentManager.MdiParent = this;
            this.documentManager.MenuManager = this.ribbon;
            this.documentManager.View = this.tabbedView1;
            this.documentManager.ViewCollection.AddRange(new DevExpress.XtraBars.Docking2010.Views.BaseView[] {
            this.tabbedView1});
            // 
            // HRDocMgr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 715);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "HRDocMgr";
            this.Ribbon = this.ribbon;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "HRDocMgr";
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage GeneralRibbon;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup EmpInfoGrp;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.Docking2010.DocumentManager documentManager;
        private DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView tabbedView1;
        private DevExpress.XtraBars.BarButtonItem HRForm;
        private DevExpress.XtraBars.BarButtonItem AttendenceForm;
        private DevExpress.XtraBars.BarButtonItem ReportMainForm;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ReportGrp;
        private DevExpress.XtraBars.BarButtonItem LogoutBtn;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPage OptionRibbon;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
    }
}