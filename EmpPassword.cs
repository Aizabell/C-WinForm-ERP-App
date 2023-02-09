using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRDatabaseTEST
{
    [Table("EmpPassword")]
    public class EmpPassword
    {
        [Key]

        public int PassID { get; set; }
        public int EmployeeID { get; set; }
        public string FirstName { get; set; }
        public string Password { get; set; }
        public string RecoveryEmail { get; set; }
       
    }
}
