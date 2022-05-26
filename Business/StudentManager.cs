using DataAccess;
using Entities;
using Microsoft.EntityFrameworkCore;
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

        public void UpdateStudent(Student student)
        {
            context.Students.Update(student);
            context.SaveChanges();
        }

        public Student GetStudentById(int id)
        {
            return context.Students.Include(x=>x.Group).FirstOrDefault(x=>x.Id == id);
        }

  

        public IQueryable<Student> GetAllStudents()
            => context.Students;

    }
}
