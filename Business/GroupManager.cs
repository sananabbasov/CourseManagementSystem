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
    public class GroupManager
    {
        ApplicationDbContext context = new();


        public void AddGroup(Group group)
        {
            context.Groups.Add(group);
            context.SaveChanges();
        }

        public IQueryable<Group> GetAllGroups()
        {
            return context.Groups.Include(x => x.User).Include(x=>x.ShiftTime);
        }

    }
}
