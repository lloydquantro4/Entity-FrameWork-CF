using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_test
{
    class Student
    {
        [Required]
        public int StudentId { get; set; }

        public string StudentFName { get; set; }

        [Required]
        public string StudentLName { get; set; }

        public string StudentName
        {
            get
            {
                return string.Format("{0} {1}", StudentFName, StudentLName);
            }
        }

       
        public DateTime DateOfBirth { get; set; }

        public string Genger { get; set; }
        
        //relationship
        public int? GradeId { get; set; }
        //lazy load
        public virtual Grade Grade { get; set; }

        //public virtual StudentAddress Address { get; set; }
        public virtual ICollection<Course> Courses { get; set; }
    }

}
