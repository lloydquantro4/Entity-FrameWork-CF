using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_test
{
    class Grade
    {
        public int GradeId { get; set; }

        public string GradeName { get; set; }

        public virtual ICollection<Student> Students { get; set; }
    }
}
