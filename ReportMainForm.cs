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

        private void EmpListRepBtn_Click(object sender, EventArgs e)
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

        private void AttJanRepOpnBtn_Click(object sender, EventArgs e)
        {
            showReport(DateTime.Parse("2023/01/01"), DateTime.Parse("2023/01/31"));
        }

        private void AttFebRepOpnBtn_Click(object sender, EventArgs e)
        {
            showReport(DateTime.Parse("2023/02/01"), DateTime.Parse("2023/02/28"));
        }

        private void AttMarRepOpnBtn_Click(object sender, EventArgs e)
        {
            showReport(DateTime.Parse("2023/03/01"), DateTime.Parse("2023/03/30"));
        }

        private void AttAplRepOpnBtn_Click(object sender, EventArgs e)
        {
            showReport(DateTime.Parse("2023/04/01"), DateTime.Parse("2023/04/30"));
        }
        private void AttMayRepOpnBtn_Click(object sender, EventArgs e)
        {
            showReport(DateTime.Parse("2023/05/01"), DateTime.Parse("2023/05/30"));
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

        private void MthAttRepOpnBtn_Click(object sender, EventArgs e)
        {
            
            using (var frm = new ReportViewer())
            {
                var rp = new XRpMonthlyAttendence();
                //add parameter form with linq perdicate
                rp.DataSource = dbContext.Attendances.AsNoTracking().ToList();
                rp.CreateDocument();
                frm.LoadReport(rp);
                frm.ShowDialog();
            }
            /*var reportwithmonth =dbContext.Attendances.AsNoTracking();
            using (var frm = new ReportViewer())
            {
                var yearlyreport = new XRpMonthlyAttendence();
                yearlyreport.DataSource = reportwithmonth;
                yearlyreport.CreateDocument();
                frm.LoadReport(yearlyreport);
                frm.ShowDialog();
            }*/

            /*var yearlyreport = new XRpMonthlyAttendence();
            var frm = new ReportViewer();
            frm.LoadReport(yearlyreport);
            frm.ShowDialog();*/

           
        }

        
    }
}