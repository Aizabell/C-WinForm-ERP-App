using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;
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
    public partial class EmpListRepView : DevExpress.XtraEditors.XtraForm
    {
        public EmpListRepView()
        {
            InitializeComponent();
        }

        public void LoadReport(XtraReport rp)
        {
            documentViewer.PrintingSystem = rp.PrintingSystem;
        }
    }
}