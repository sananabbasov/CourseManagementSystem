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
    public class TeacherManager
    {
        ApplicationDbContext context = new();
        UserManager userManager = new();
        public List<User> GetAllTeacher()
        {
            var teachers = context.Users.Where(x => x.RoleId == 2 && x.IsDeleted == false).ToList();


            return teachers;
        }

        public User GetTeacherById(int Id)
        {
            return context.Users.FirstOrDefault(x => x.Id == Id);
        }

        public void UpdateUser(User user)
        {
            context.Users.Update(user);
            context.SaveChanges();
        }

        public void AddTeacher(User user)
        {
            user.Password = userManager.PasswordHash(user.Password);
            user.RoleId = 2;
            context.Users.Add(user);
            context.SaveChanges();
        }

        public void DeleteTeacher(User user)
        {
            user.IsDeleted = true;
            context.Users.Update(user);
            context.SaveChanges();
        }

        public User GetTeacherByName(string name)
        {
            return context.Users.FirstOrDefault(x=>x.Fullname == name && x.IsDeleted == false);
        }

        public User GetTeacherByEmail(string email)
        {
            return context.Users.FirstOrDefault(x => x.Email == email);
        }
    }
}
