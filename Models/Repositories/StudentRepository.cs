using System.Collections.Generic;
using System.Linq;
using ConsoleApplication.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace ConsoleApplication.Models.Repositories
{
    public class StudentRepository : IStudentRepository
    {
        private MyDbContext _db;
        private DbSet<Student> _students;

        public StudentRepository(MyDbContext db)
        {
            _db = db;
            _students = db.Students;
        }
        public void Delete(Student st)
        {
            Student student = _db.Students.Find(st.StudentID);
            _db.Students.Remove(student);
            _db.SaveChanges();
        }

        public Student Get(int id)
        {
            Student student =  _db.Students.Include(s => s.Enrollments).ThenInclude(e => e.Course).Where(r => r.StudentID == id).FirstOrDefault();
            return student;
        }

        public IEnumerable<Student> GetAll()
        {
            IEnumerable<Student> students = _db.Students;
            return students;
        }

        public void Save(Student student)
        {
            _db.Students.Add(student);
            _db.SaveChanges();
        }

        public void Update(Student student)
        {
            _db.Students.Update(student);
            _db.SaveChanges();
        }
    }
}