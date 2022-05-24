using DataAccess;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class StudentManager
    {
        ApplicationDbContext context = new();

        public Student AddStudent(Student student)
        {
            context.Students.Add(student);
            context.SaveChanges();

            return student;
        }

        public IQueryable<Student> GetAllStudents()
            => context.Students;

    }
}
