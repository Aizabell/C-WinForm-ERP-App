using DevExpress.XtraEditors;
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
    public partial class EmployeeCourseList : DevExpress.XtraEditors.XtraForm
    {
        HRDBContext dbContext;
        BindingSource dbs;
        Employee _employee;//declare ID to grab the retrieved ID
        EmpXCourse _current;//declare current ID
        public EmployeeCourseList(Employee employee)//opening the form with the retrieved ID
        {
            _employee = employee;//ID grabbed
            InitializeComponent();
            dbContext = new HRDBContext();
            dbs = new BindingSource();
        }

        private void EmployeeCourseList_Load(object sender, EventArgs e)
        {

            dbs.DataSource = dbContext.EmpXCourses.Where(a => a.EmployeeID == _employee.ID).ToList();//Query selecting the data with grabbed ID
            gridControl2.DataSource = dbs;
            dbs.CurrentChanged += Dbs_CurrentChanged;
            RCourseIDLookUpEdit.DataSource = dbContext.Courses.ToList();
            RCourseIDLookUpEdit.EditValueChanged += RCourseIDLookUpEdit_EditValueChanged;
            RDeleteButtonEdit.ButtonClick += RDeleteButtonEdit_ButtonClick;//delete event declared
           

        }

        private void RCourseIDLookUpEdit_EditValueChanged(object sender, EventArgs e)
        {

            var editor = sender as LookUpEdit;//lookupedit
            if (editor.EditValue != null)
            {
                var obj = editor.GetSelectedDataRow() as Course;
                _current.CourseName = obj.CourseName;
            }
        }

        private void RDeleteButtonEdit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if ("delete".Equals(e.Button.Tag))//only use when there are two buttons a single colum and use tags to differentiate
            {
                dbContext.EmpXCourses.Remove(_current);//deleting the data with selected current ID 
                if (dbContext.SaveChanges() > 0)
                {
                    dbs.RemoveCurrent();
                }
            }
        }

        private void Dbs_CurrentChanged(object sender, EventArgs e)//updating/saving the existing row 
        {
            _current = dbs.Current as EmpXCourse;
        }

        private void gridView1_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {   //saving new data row

            _current.FirstName = _employee.FirstName;
            _current.LastName = _employee.LastName;
            if(_current.EMPXCID == default(int))//when new item add there is no value thus adding default value
            {
                _current.EmployeeID = _employee.ID;//assigning the new current row to assign the grabbed ID
                dbContext.EmpXCourses.Add(_current);//saving syntax
            }

            dbContext.SaveChanges();
        }
    }
}