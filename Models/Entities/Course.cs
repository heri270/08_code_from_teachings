using System.Collections.Generic;

namespace ConsoleApplication.Models.Entities
{
    public class Course
    {
         public int CourseID { get; set; }
        public string Title { get; set; }
        public int Credits { get; set; }

        public virtual IEnumerable<Enrollment> Enrollments { get; set; }
    }
}