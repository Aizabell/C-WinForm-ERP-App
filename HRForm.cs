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
    public partial class HRForm : DevExpress.XtraEditors.XtraForm
    {
        HRDBContext dbContext;
        BindingSource dbs;
        Employee _current;
        public HRForm()
        {
            InitializeComponent();
            dbContext = new HRDBContext();
            dbs = new BindingSource();
            var currentEID = dbs.Current as Employee;
        }

        private void HRForm_Load(object sender, EventArgs e)
        {
            //this.employeeTableAdapter.Fill(this.oFDBDataSet.Employee);
            dbs.DataSource = dbContext.Employees.ToList();//Show all data in the grid
            dbs.CurrentChanged += Dbs_CurrentChanged;//Operates the Dbs_current changed to load image
            //The below list is Data Layer View of Datadbindings
            EmployeeIDTextEdit.DataBindings.Add("EditValue", dbs, "ID", true, DataSourceUpdateMode.OnPropertyChanged);
            FirstNameTextEdit.DataBindings.Add("EditValue", dbs, "FirstName", true, DataSourceUpdateMode.OnPropertyChanged);
            LastNameTextEdit.DataBindings.Add("EditValue", dbs, "LastName", true, DataSourceUpdateMode.OnPropertyChanged);
            SexTextEdit.DataBindings.Add("EditValue", dbs, "Sex", true, DataSourceUpdateMode.OnPropertyChanged);
            DOBDateEdit.DataBindings.Add("EditValue", dbs, "DOB", true, DataSourceUpdateMode.OnPropertyChanged);
            StreetTextEdit.DataBindings.Add("EditValue", dbs, "Street", true, DataSourceUpdateMode.OnPropertyChanged);
            AgeTextEdit.DataBindings.Add("EditValue", dbs, "Age", true, DataSourceUpdateMode.OnPropertyChanged);
            CityTextEdit.DataBindings.Add("EditValue", dbs, "City", true, DataSourceUpdateMode.OnPropertyChanged);
            CountryTextEdit.DataBindings.Add("EditValue", dbs, "Country", true, DataSourceUpdateMode.OnPropertyChanged);
            GmailTextEdit.DataBindings.Add("EditValue", dbs, "Gmail", true, DataSourceUpdateMode.OnPropertyChanged);
            PositionTextEdit.DataBindings.Add("EditValue", dbs, "Position", true, DataSourceUpdateMode.OnPropertyChanged);
            DepartmentTextEdit.DataBindings.Add("EditValue", dbs, "Department", true, DataSourceUpdateMode.OnPropertyChanged);
            

            gridControl1.DataSource = dbs;
            Dbs_CurrentChanged(this, null);
        }
        
        private void Dbs_CurrentChanged(object sender, EventArgs e)//Image with CurrentID Load
        {
            _current = dbs.Current as Employee;
            if (_current != null)
            {
                if (_current.ID != 0)

                {
                    PPEdit.Image = Image.FromFile(_current.Picture);
                }
            }
        }
        
        public void BackBtn_Click(object sender, EventArgs e)
        {
            dbs.MovePrevious();
        }
        private void NextBtn_Click(object sender, EventArgs e)
        {
            dbs.MoveNext();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            var obj = dbs.Current as Employee;
            if (obj.ID == default(int))
            {
                dbContext.Employees.Add(obj);
            }
            obj.AccessTime = DateTime.Now;


            dbContext.SaveChanges();
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            dbContext.Employees.Remove(dbs.Current as Employee);
            if (dbContext.SaveChanges() > 0)
            {
                dbs.RemoveCurrent();
            }
        }
        private void NewBtn_Click(object sender, EventArgs e)
        {
            dbs.AddNew();
        }
        private void UploadBtn_Click(object sender, EventArgs e)//Uploading Image 
        {

            var obj = dbs.Current as Employee;
            OpenFileDialog open = new OpenFileDialog();
            string myPictures = System.Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            open.Filter = "Jpg,Jpeg,Images|*.jpe;*.jpeg|PNG Images|*.png|BMP Images|*.bmp|" + "All files(*.*)|*.*";//Image Filter types
            open.FileName = "Image file name";
            open.Title = "Choose an image...";//File open message
            open.AddExtension = true;
            open.FilterIndex = 0;
            open.Multiselect = false;
            open.InitialDirectory = myPictures;
            open.RestoreDirectory = true;
            if (open.ShowDialog() == DialogResult.OK)//Open image
            {
                if (obj.ID != default(int))
                {
                    PPEdit.Image = new Bitmap(open.FileName);//ImageBitmap
                    obj.Picture = open.FileName;

                    ///copy to specific location e.g. D:\Images with employeeID filename
                }
                else
                {
                    /// insert new employee first
                    /// get id after inserting new employee
                    /// copy to specific location e.g. D:\Images with employeeID filename
                    
                    if (obj.ID == default(int))//Matching image with EployeeID
                    {
                        dbContext.Employees.Add(obj);
                    }
                    dbContext.SaveChanges();
                    if (obj.ID != default(int))
                    {
                        PPEdit.Image = new Bitmap(open.FileName);
                        obj.Picture = open.FileName;


                    }
                }
                //provide absolute link by concatinating with filename
                this.PPEdit.Image = Image.FromFile($"{open.FileName}");
            }
            else
            {
                return;
            }
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            int id;
            Employee emp;
            if (int.TryParse(SearchTextEdit.Text, out id))//try changing int and will not result error if failed
            {
                emp = (from a in dbContext.Employees//search query
                           where (a.ID == id || a.FirstName == SearchTextEdit.Text || a.Country == SearchTextEdit.Text || a.LastName == SearchTextEdit.Text)
                           select a).FirstOrDefault();
            }
            else
            {
                emp = (from a in dbContext.Employees
                           where (a.FirstName == SearchTextEdit.Text || a.Country == SearchTextEdit.Text || a.LastName == SearchTextEdit.Text)
                           select a).FirstOrDefault();
            }

            if (emp == null) return; //will ignore if the search name was failed and can't find ID
            var eSearch = dbs.IndexOf(dbs.List.OfType<Employee>().FirstOrDefault(a => a.ID == emp.ID));
            dbs.Position = eSearch; //query checking the employeeetableID with the emp 
         

            
            /*var emp = (from a in dbContext.Employees
                       where a.EmployeeID == id
                       //where a.FirstName.StartsWith(SearchTextEdit.Text)
                       select a).FirstOrDefault();
            if (emp == null) return;
            var index = dbs.IndexOf(dbs.List.OfType<Employee>().FirstOrDefault(a => a.EmployeeID == emp.EmployeeID));
            dbs.Position = index;*/


            /* ID Search Method (can't use function in the SQL Lines)
                int id = Convert.ToInt32(SearchTextEdit.Text);
                var emp = (from a in dbContext.Employees
                           where a.EmployeeID == id
                           //where a.FirstName.StartsWith(SearchTextEdit.Text)
                           select a).FirstOrDefault();
                if (emp == null) return;
                var index = dbs.IndexOf(dbs.List.OfType<Employee>().FirstOrDefault(a => a.EmployeeID == emp.EmployeeID));
                dbs.Position = index;*/
        }

        private void EmpxCourseLoad_Click(object sender, EventArgs e)
        {
            using (var ExCopen = new EmployeeCourseList(_current))//opening next form with carrying the object value
            {
                ExCopen.ShowDialog();
            }
            
            
        }


    }
}