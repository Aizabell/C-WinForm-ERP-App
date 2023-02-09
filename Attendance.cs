using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace HRDatabaseTEST
{
    [Table("Attendance")]
    public class Attendance
    {
        [Key]
        public int AttendanceID { get; set; }
        public int EmployeeID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime? Date { get; set; }
        public bool? IsClockedIn { get; set; }
        public bool? IsClockedOut { get; set; }
        public DateTime? ClockIn { get; set; }
        public DateTime? ClockOut { get; set; }
        public int? CourseID { get; set; }
        public string CourseName { get; set; }


    }
}
