using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_test
{
    class SchoolDB: DbContext
    {
        public SchoolDB(): base() //db without an initialzier
        {
            Database.SetInitializer<SchoolDB>(null);
        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Grade> Grades { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        
    }
}
