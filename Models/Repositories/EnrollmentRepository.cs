using System;
using System.Collections.Generic;
using ConsoleApplication.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace ConsoleApplication.Models.Repositories
{
    public class EnrollmentRepository : IEnrollmentRepository
    {
        private MyDbContext _db;
        private DbSet<Enrollment> _enrollment;
        // private DbSet<Enrollment> _enrollment;
        public EnrollmentRepository(MyDbContext db)
        {
            _db = db;
            _enrollment = db.Enrollments;

        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Course Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Enrollment> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Save(Enrollment course)
        {
            _enrollment.Add(course);
            _db.SaveChanges();
        }

        public void Update(Enrollment course)
        {
            throw new NotImplementedException();
        }
    }
}