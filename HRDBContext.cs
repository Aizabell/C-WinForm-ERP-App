using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRDatabaseTEST
{
    public class HRDBContext : DbContext
    {
        public HRDBContext()
        {
            Database.SetInitializer<HRDBContext>(null);
            this.Database.Connection.ConnectionString = "Data Source=HARRY-PHOEBUS;Initial Catalog=OFDB;Integrated Security=false;User id=getCon;password=a";
            this.Database.CommandTimeout = 120;
        }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<EmpXCourse> EmpXCourses { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            
        }
    }
}
