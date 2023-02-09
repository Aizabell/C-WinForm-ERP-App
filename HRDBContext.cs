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
            this.Database.Connection.ConnectionString = "Data Source=HarryPhoebus;Initial Catalog=HRDB;Integrated Security=false;User id=sa;password=a";
            this.Database.CommandTimeout = 120;
        }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<EmpXCourse> EmpXCourses { get; set; }
        public DbSet<Attendance> Attendances { get; set; }
        public DbSet<EmpPassword> EmpPasswords { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            
        }
    }
}
