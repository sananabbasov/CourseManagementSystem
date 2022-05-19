using DataAccess;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class ShiftManager
    {
        ApplicationDbContext context = new();


        public List<ShiftTime> GetShiftTimes()
        {
            return context.ShiftTimes.ToList();
        }

        public ShiftTime GetShiftByName(string name) 
            => context.ShiftTimes.FirstOrDefault(x => x.Name == name);

    }
}
