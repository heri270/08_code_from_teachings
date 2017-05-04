using System;
using System.Collections.Generic;
using ConsoleApplication.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace ConsoleApplication.Models.Repositories
{
    public class CourseRepository : ICourseRepository
    {
        private MyDbContext _db;
        private DbSet<Course> _courses;
        public CourseRepository(MyDbContext db)
        {
            _db = db;
            _courses = db.Courses;

        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Course Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Course> GetAll()
        {
            return _courses;
        }

        public void Save(Course course)
        {
            throw new NotImplementedException();
        }

        public void Update(Course course)
        {
            throw new NotImplementedException();
        }
    }
}