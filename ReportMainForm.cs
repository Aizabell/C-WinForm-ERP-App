using DevExpress.XtraEditors;
using HRDatabaseTEST.Model;
using HRDatabaseTEST.Report;
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
    public partial class ReportMainForm : DevExpress.XtraEditors.XtraForm
    {
        HRDBContext dbContext;
        BindingSource dbs;
        public ReportMainForm()
        {
            InitializeComponent();
            dbContext = new HRDBContext();
            dbs = new BindingSource();
        }

        private void simpleButton7_Click(object sender, EventArgs e)
        {
            using (var frm = new ReportViewer())
            {
                var rp = new EmpListRp();
                //add parameter form with linq perdicate
                rp.DataSource = dbContext.Employees.AsNoTracking().ToList();
                rp.CreateDocument();
                frm.LoadReport(rp);
                frm.ShowDialog();
            }
        }

        
        private void showReport(DateTime fromDate, DateTime toDate)
        {

            using (var frm = new ReportViewer())
            {
                var rp = new XRpAttendence();
                //add parameter form with linq perdicate
                rp.DataSource = dbContext.Attendances.AsNoTracking().Where(a => a.ClockIn > fromDate && a.ClockIn < toDate).ToList();
                rp.CreateDocument();
                frm.LoadReport(rp);
                frm.ShowDialog();
            }
        }

        private void AttJulRepOpnBtn_Click(object sender, EventArgs e)
        {
            showReport(DateTime.Parse("2022/07/01"), DateTime.Parse("2022/08/01"));
        }

        private void AttAugRepOpnBtn_Click(object sender, EventArgs e)
        {
            showReport(DateTime.Parse("2022/08/01"), DateTime.Parse("2022/09/01"));
        }

        private void AttSepRepOpnBtn_Click(object sender, EventArgs e)
        {
            
        }

        private void AttOctRepOpnBtn_Click(object sender, EventArgs e)
        {
            showReport(DateTime.Parse("2022/10/01"), DateTime.Parse("2022/11/01"));
        }

        private void InfoButtonItem_Click(object sender, EventArgs e)
        {
            var employeeWithAttendences = dbContext.Employees.AsNoTracking()
                .Select(a => new EmployeeWithAttendences 
                { 
                    Emp = a, 
                    Attendances = dbContext.Attendances.Where(b => b.EmployeeID == a.ID).ToList(),
                    EmpXCourses = dbContext.EmpXCourses.Where(c=> c.EmployeeID ==a.ID).ToList(),
                }).ToList();
            using (var frm = new ReportViewer())
            {
                var rp = new XRpEmployeeAttendence();
                //add parameter form with linq perdicate
                rp.DataSource = employeeWithAttendences;
                rp.CreateDocument();
                frm.LoadReport(rp);
                frm.ShowDialog();
            }
        }
    }
}