using System.Collections.Generic;
using ConsoleApplication.Models.Entities;

namespace ConsoleApplication.Models.Repositories
{
    public interface IStudentRepository
    {
        // Basic Crud opreation
       IEnumerable<Student> GetAll();
       Student Get(int id);
       void Delete(Student st);
       void Update(Student student);
       void Save(Student student);

    }
}
