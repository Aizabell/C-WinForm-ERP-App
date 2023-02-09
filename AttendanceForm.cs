using DevExpress.XtraEditors;
using HRDatabaseTEST.Report;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRDatabaseTEST
{
    public partial class AttendanceForm : DevExpress.XtraEditors.XtraForm
    {
        HRDBContext dbContext;
        BindingSource dbs;
        Employee _employee;
        Attendance _attendance;
        Course _course;
        List<Course> _courses;
        public AttendanceForm()
        {
            _course = null;
            InitializeComponent();
            dbContext = new HRDBContext();
            dbs = new BindingSource();
            
        }

        private void AttendanceForm_Load(object sender, EventArgs e)
        {
            dbs.DataSource = dbContext.Attendances.ToList();
            gridControl1.DataSource = dbs;
            dbs.CurrentChanged += Dbs_CurrentChanged;
            _courses = dbContext.Courses.ToList();
            RCourseLookUpEdit.DataSource = _courses;
            CourseLookUpEdit.Properties.DataSource = _courses;
        }

        private void Dbs_CurrentChanged(object sender, EventArgs e)
        {
            _attendance = dbs.Current as Attendance;
        }

        private void CheckInButton_Click(object sender, EventArgs e)
        {
            //find employee with code => obj => check exisitng attendence 
            int IDNumb;
            int CIDNo;
            Employee emp;
            Attendance att;
            
            if (int.TryParse(IDTextEdit.Text, out IDNumb))
            {
                emp = (from a in dbContext.Employees.AsNoTracking()
                       where (a.ID == IDNumb)
                       select a).FirstOrDefault();
                if (emp == null) return;
                if (dbContext.EmpXCourses.AsNoTracking().Any(a => a.CourseID == _course.CourseID && a.EmployeeID == emp.ID))
                {
                    att = (from b in dbContext.Attendances.AsNoTracking()
                           where DbFunctions.TruncateTime(b.ClockIn) == DateTime.Today
                           && b.EmployeeID == emp.ID
                           select b).FirstOrDefault();
                    if (att != null/*||(att.IsClockedIn ?? false)*/) return;

                    //var onlydate = dbs.Function.Truncate.Time;
                    var currentdatetime = DateTime.Today;
                    var newAttendance = new Attendance
                    {
                        EmployeeID = emp.ID,
                        FirstName = emp.FirstName,
                        CourseID = _course.CourseID,
                        CourseName = _course.CourseName,
                        LastName = emp.LastName,
                        Date = DateTime.Today,
                        ClockIn = DateTime.Now,
                        IsClockedIn = true,
                    };

                    dbContext.Attendances.Add(newAttendance);

                    if (dbContext.SaveChanges() > 0)
                        Reload();//refresh method
                }
                else
                {
                    MessageBox.Show("Employee Doesn't exist in this Course");
                }
                
            }
            //CreateDate=dbs.Function.TruncateTime
            //create new attendance record with employee information     
        }
        private void Reload()//refresh method|| AsNoTracking method will refresh quick
        {
            dbs.DataSource = dbContext.Attendances.AsNoTracking().ToList();
        }
        private void CheckOutButton_Click(object sender, EventArgs e)
        {
            int IDNumb;
            int CIDNo;
            Employee emp;
            Attendance att;

            if (int.TryParse(IDTextEdit.Text, out IDNumb))
            {
                emp = (from a in dbContext.Employees.AsNoTracking()
                       where (a.ID == IDNumb)
                       select a).FirstOrDefault();
                if (emp == null) return;
                if (dbContext.EmpXCourses.AsNoTracking().Any(a => a.CourseID == _course.CourseID && a.EmployeeID == emp.ID))
                {
                    att = (from b in dbContext.Attendances
                           where DbFunctions.TruncateTime(b.ClockIn) == DateTime.Today
                           && b.EmployeeID == emp.ID && b.IsClockedIn == true
                           select b).FirstOrDefault();
                    if (att == null) return;

                    //var onlydate = dbs.Function.Truncate.Time;
                    //var updateAttendance = dbs.Current as Attendance;


                    att.ClockOut = DateTime.Now;
                    att.IsClockedOut = true;



                    if (dbContext.SaveChanges() > 0)
                    {
                        Reload();
                    }
                }
            }
            
        }
        private void AttRepItemButDeleteEdit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if ("delete".Equals(e.Button.Tag))//only use when there are two buttons a single colum and use tags to differentiate
            {
                dbContext.Attendances.Remove(_attendance);//deleting the data with selected current ID 
                if (dbContext.SaveChanges() > 0)
                {
                    dbs.RemoveCurrent();
                }
            }
        }

        private void RCourseLookUpEdit_Load(object sender, EventArgs e)
        {

        }

        private void CourseLookUpEdit_Closed(object sender, DevExpress.XtraEditors.Controls.ClosedEventArgs e)
        {
            _course = CourseLookUpEdit.GetSelectedDataRow() as Course;
        }

        private void ReportButtonItem_Click(object sender, EventArgs e)
        {
            //check view model report utube
            //initialize parameter form
            //show parameter form
            //if okay to show
            using(var frm = new ReportViewer())
            {
                var RepMFOpen = new ReportMainForm();
                RepMFOpen.ShowDialog();
                //var rp = new XRpAttendence();
                //add parameter form with linq perdicate
                //rp.DataSource = dbContext.Attendances.AsNoTracking().ToList();
                //rp.CreateDocument();
                //frm.LoadReport(rp);
                //frm.ShowDialog();
            }
        }

        private void gridView1_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {

        }
    }
}



/*
            if (_attendance.IsClockedOut == null && _attendance.IsClockedIn ==true)
            {
                int IDNumb = Convert.ToInt32(IDTextEdit.Text);
                IDNumb = _employee.EmployeeID;
                dbContext.Attendances.Add(_attendance);
                _attendance.IsClockedOut = true;
                _attendance.ClockOut = DateTime.Now;
            }
            else if (_attendance.IsClockedOut == true)
            {

            }
            */
/* Access time saving method
 var obj = EP.Current as Employee;
            if (obj.EmployeeID == default(int))
            {
                dbContext.Employees.Add(obj);
            }
            obj.AccessTime = DateTime.Now;


            dbContext.SaveChanges();
 */