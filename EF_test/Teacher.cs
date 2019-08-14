using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_test
{
    class Teacher
    {
        public int Id { get; set; }
        public string TeacherName { get; set; }

        public virtual ICollection<Course> Courses { get; set; }
    }
}
