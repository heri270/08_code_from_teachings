using System;
using System.Linq;
using ConsoleApplication.Models.Entities;
using Microsoft.Extensions.DependencyInjection;

// 1. remove unnessary usings

// 2. our application is called ConsoleApplication and we do not have a data folder, 
//i put it in Models instead

namespace ConsoleApplication.Models 
{
    public static class DbInitializer
    {
        public static void Initialize(MyDbContext context) //3. we do not have a SchoolContext, but a MyDbContext
        {
            context.Database.EnsureCreated();

            // Look for any students.
            if (context.Students.Any())
            {
                return;   // DB has been seeded
            }

            var students = new Student[]
            {
                // 4. change properties so they fit with what we have i Student.cs
            new Student{FirstName="Carson",LastName="Alexander",EnrollmenDate=DateTime.Parse("2005-09-01"), Age=23},
            new Student{FirstName="Meredith",LastName="Alonso",EnrollmenDate=DateTime.Parse("2002-09-01"), Age=33},
            new Student{FirstName="Arturo",LastName="Anand",EnrollmenDate=DateTime.Parse("2003-09-01"), Age=43},
            new Student{FirstName="Gytis",LastName="Barzdukas",EnrollmenDate=DateTime.Parse("2002-09-01"), Age=53},
            new Student{FirstName="Yan",LastName="Li",EnrollmenDate=DateTime.Parse("2002-09-01"), Age=63},
            new Student{FirstName="Peggy",LastName="Justice",EnrollmenDate=DateTime.Parse("2001-09-01"), Age=22},
            new Student{FirstName="Laura",LastName="Norman",EnrollmenDate=DateTime.Parse("2003-09-01"), Age=24},
            new Student{FirstName="Nino",LastName="Olivetto",EnrollmenDate=DateTime.Parse("2005-09-01"), Age=26}
            };
            foreach (Student s in students)
            {
                context.Students.Add(s);
            }
            context.SaveChanges();

            // 5. Comment out the rest since we dont have these classes yet
            var courses = new Course[]
            {
            new Course{CourseID=1050,Title="Chemistry",Credits=3,},
            new Course{CourseID=4022,Title="Microeconomics",Credits=3,},
            new Course{CourseID=4041,Title="Macroeconomics",Credits=3,},
            new Course{CourseID=1045,Title="Calculus",Credits=4,},
            new Course{CourseID=3141,Title="Trigonometry",Credits=4,},
            new Course{CourseID=2021,Title="Composition",Credits=3,},
            new Course{CourseID=2042,Title="Literature",Credits=4,}
            };
            foreach (Course c in courses)
            {
                context.Courses.Add(c);
            }
            context.SaveChanges();

            var enrollments = new Enrollment[]
            {
            new Enrollment{StudentID=1,CourseID=1050,Grade=12},
            new Enrollment{StudentID=1,CourseID=4022,Grade=10},
            new Enrollment{StudentID=1,CourseID=4041,Grade=4},
            new Enrollment{StudentID=2,CourseID=1045,Grade=4},
            new Enrollment{StudentID=2,CourseID=3141,Grade=02},
            new Enrollment{StudentID=2,CourseID=2021,Grade=7},
            new Enrollment{StudentID=3,CourseID=1050},
            new Enrollment{StudentID=4,CourseID=1050,},
            new Enrollment{StudentID=4,CourseID=4022,Grade=4},
            new Enrollment{StudentID=5,CourseID=4041,Grade=00},
            new Enrollment{StudentID=6,CourseID=1045},
            new Enrollment{StudentID=7,CourseID=3141,Grade=02},
            };
            foreach (Enrollment e in enrollments)
            {
                context.Enrollments.Add(e);
            }
            context.SaveChanges();
        }
    }
}
