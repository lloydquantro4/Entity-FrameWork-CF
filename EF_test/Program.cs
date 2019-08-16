using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_test
{
    class Program
    {
        static void Main(string[] args)
        {
            var db = new SchoolDB();
            
           //test data
            var grade = new Grade {GradeId =1, GradeName = "grade1" };
            DateTime dt = new DateTime(2008, 3, 9, 16, 5, 7, 123);
            var stud = db.Students.Add(new Student { StudentFName="Lloyd", StudentLName = "Sherewa",
                StudentId =db.Students.Count() + 1, DateOfBirth = dt, Genger = "male", Grade=grade });

            db.Students.Add(stud);
            db.SaveChanges();

            var studname = stud.StudentName;
            Console.WriteLine("Stud added to db " + studname);
            Console.ReadKey();

        }
    }
}
