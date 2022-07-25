using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRDatabaseTEST
{
    [Table("Course")]
    public class Course
    {
        [Key]

        public int CourseID { get; set; }
        public string CourseName { get; set; }
        public int Period { get; set; }
        public string CourseDifficulty { get; set; }
       
    }

}
