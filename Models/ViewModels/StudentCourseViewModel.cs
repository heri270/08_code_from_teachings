using System.Collections.Generic;
using ConsoleApplication.Models.Entities;

namespace ConsoleApplication.Models.ViewModels
{
    public class StudentCourseViewModel
    {
        public Student Student {get; set;}

        public IEnumerable<Course> Courses {get; set;}
    }
}