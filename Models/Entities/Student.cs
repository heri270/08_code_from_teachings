using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ConsoleApplication.Models.Entities
{
    public class Student
    {
        // POCO Classes
        // Plain Old CLR Object
        public int StudentID { get; set; }
        [Required]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        [DataTypeAttribute(DataType.Date)]
        [Display(Name = "Enrollment Date")]
        public DateTime EnrollmenDate { get; set; }
        public int Age { get; set; }

        // Navigation prop
        public IEnumerable<Enrollment> Enrollments { get; set; }

    }
}