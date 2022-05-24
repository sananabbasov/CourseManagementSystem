using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class PaymentList : Base
    {
        public double Price { get; set; }
        public int StudentId { get; set; }
        public Student Student { get; set; }
        public DateTime PayDate { get; set; }
    }
}
