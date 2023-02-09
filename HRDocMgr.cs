using DevExpress.XtraBars;
using DevExpress.XtraBars.Docking2010.Views.Tabbed;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRDatabaseTEST
{
    public partial class HRDocMgr : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public HRDocMgr()
        {
            InitializeComponent();
            tabbedView1.QueryControl += TabbedView1_QueryControl;
            documentManager.DocumentActivate += DocumentManager_DocumentActivate;
        }

        private void DocumentManager_DocumentActivate(object sender, DevExpress.XtraBars.Docking2010.Views.DocumentEventArgs e)
        {

            foreach (var item in this.ribbon.Items)
            {
                if (item is DevExpress.XtraBars.BarItem barItem)
                {
                    barItem.Enabled = true;
                }
            }
            foreach (var item in this.ribbon.Items)
            {
                if (item is DevExpress.XtraBars.BarItem barItem)
                {
                    if (e.Document != null)
                    {
                        barItem.Enabled = barItem.Caption == e.Document.Tag.ToString();
                    }
                    

                }
            }
        }

        private void TabbedView1_QueryControl(object sender, DevExpress.XtraBars.Docking2010.Views.QueryControlEventArgs e)
        {
            switch (e.Document.Tag.ToString())
            {
                case "HRForm":
                    e.Control = new HRForm();
                    break;
                case "AttendanceForm":
                    e.Control = new AttendanceForm();
                    break;
                case "ReportMainForm":
                    e.Control = new ReportMainForm();
                    break;
            }
        }

        private void ActivateForm(Type someType, object[] parameters = null)
        {
            foreach (Document doc in documentManager.View.Documents)
            {
                if (doc.Control.GetType() == someType)
                {
                    documentManager.View.ActivateDocument(doc.Control);
                    return;
                }
            }
            Document document = new Document() { Tag = someType.GetType().GetProperty("Name").GetValue(someType, null) };
            documentManager.View.Documents.Add(document);
            documentManager.View.Controller.Activate(document);
        }
        private void HRForm_ItemClick(object sender, ItemClickEventArgs e)
        {
            ActivateForm(typeof(HRForm));
        }

        private void AttendenceForm_ItemClick(object sender, ItemClickEventArgs e)
        {
            ActivateForm(typeof(AttendanceForm));
        }

        private void ReportMainForm_ItemClick(object sender, ItemClickEventArgs e)
        {
            ActivateForm(typeof(ReportMainForm));
        }

        private void LogoutBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            
            var loginfrm = new LoginForm();
            loginfrm.ShowDialog();
        }
    }
}