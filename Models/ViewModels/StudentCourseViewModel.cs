using System.Collections.Generic;

namespace ConsoleApplication.Models.Entities
{
    public class StudentCourseViewModel
    {
        public Student Student {get; set;}

        public IEnumerable<Course> Courses {get; set;}
    }
}