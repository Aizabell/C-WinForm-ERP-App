using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRDatabaseTEST
{
    [Table("EmpXCourse")]
    public class EmpXCourse
    {
        [Key]
        public int EMPXCID { get; set; }
        public int EmployeeID { get; set; }
        public int CourseID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string CourseName { get; set; }

    }
}
