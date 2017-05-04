using ConsoleApplication.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace ConsoleApplication.Models 
{ 
    public class MyDbContext : DbContext 
    {
        public DbSet<Course> Courses { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<Student> Students { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder)
        {
            optionBuilder.UseSqlite("Filename=./mydb.db");
        } 

    }
}