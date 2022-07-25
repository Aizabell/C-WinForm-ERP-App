using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRDatabaseTEST
{
    [Table("Employee")]
    public class Employee
    {
        [Key]

        public int EmployeeID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Sex { get; set; }
        public DateTime? DOB { get; set; }
        public int Age { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string Gmail { get; set; }
        public string Department { get; set; }
        public string Position { get; set; }
        public DateTime? AccessTime { get; set; }
        public string Picture { get; set; }
    }
}
