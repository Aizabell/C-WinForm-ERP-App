using DevExpress.XtraBars;
using DevExpress.XtraBars.Docking2010.Views.Tabbed;
using DevExpress.XtraPrinting.Native;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Menu;

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
            /*foreach (var item in this.ribbon.Items)
            {
                if (item is DevExpress.XtraBars.BarCheckItem barItem)
                {
                    barItem.Checked = false;
                }
            }*/
            foreach (var item in this.ribbon.Items)
            {
                if (item is DevExpress.XtraBars.BarCheckItem barItem)
                {
                    
                    if (e.Document != null && e.Document.Tag.ToString()  == barItem.Name.ToString())
                    {
                        barItem.Checked= true;
                        /*DevExpress.XtraBars.BarAndDockingControllerLookAndFeel.Use
                        DevExpress.LookAndFeel.DefaultLookAndFeel*/
                        /*e.Document.Caption.ToString();
                        e.Document.Tag.ToString()*/
                    }
                    else
                    {
                        barItem.Checked = false;
                    }
                }
            }
            /* this is code to disable the ribbon bar items
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
            */
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
                case "LoginForm":
                    var loginForm = new LoginForm();
                    e.Control = loginForm;
                    loginForm.OnActivated += LoginForm_OnActivated;

                    break;
            }
        }
        private void LoginForm_OnActivated(object sender, bool e)
        {
            foreach (var item in this.ribbon.Items)
            {
                if (item is DevExpress.XtraBars.BarItem barItem)
                {
                    barItem.Enabled = true;
                    if (barItem == LoginForm)
                    {
                        barItem.Enabled = false;
                    }
                }
            }
            //this.tabbedView1.DocumentClosed(); 
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
            foreach (var item in this.ribbon.Items)
            {
                if (item is DevExpress.XtraBars.BarItem barItem)
                {
                    barItem.Enabled = false;
                    if (barItem == LoginForm)
                    {
                        barItem.Enabled = true;
                    }
                }
            }
            foreach(var doc in documentManager.View.Documents.Where(a => a.Caption != "LoginForm").ToList())
            {
                documentManager.View.Controller.Close(doc);
            }
        }

        private void LoginBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            ActivateForm(typeof(LoginForm));
        }

        private void HRDocMgr_Load(object sender, EventArgs e)
        {
            foreach (var item in this.ribbon.Items)
            {
                if (item is DevExpress.XtraBars.BarItem barItem)
                {
                    barItem.Enabled = false;
                    if (barItem == LoginForm)
                    {
                        barItem.Enabled = true;
                    }
                }
            }
            ActivateForm(typeof(LoginForm));




        }
    }
}