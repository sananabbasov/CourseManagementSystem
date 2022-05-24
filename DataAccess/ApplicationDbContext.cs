using Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class ApplicationDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=ManagementSystemDb;");
        }

        public DbSet<User> Users { get; set; }
        public DbSet<EducationPlan> EducationPlans { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<Information> Informations { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<ShiftTime> ShiftTimes { get; set; }
        public DbSet<PaymentList> PaymentLists { get; set; }
    }
}
