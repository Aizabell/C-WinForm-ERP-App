using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRDatabaseTEST.Model
{
    public class EmployeeWithAttendences
    {
        public Employee Emp { get; set; }
        public List<Attendance> Attendances { get; set; }
        public List<EmpXCourse> EmpXCourses { get; set; }
    }
}
