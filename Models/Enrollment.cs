using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContosoUniversity.Models
{
    public class Enrollment
    {
        public int EnrollmentID { get; set; }
        public int StudentID { get; set; }
        public int CourseID { get; set; }

        public Grade? Grade { get; set; }

        //Navigation properties Student has one Enrollment with One or Many Courses
        public Student Student { get; set; }
        public ICollection<Course> Courses { get; set;}

    }
}
