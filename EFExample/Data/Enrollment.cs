using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class Enrollment
    {
        public int ID { get; set; }
        public DateTime DateOfEnrollment { get; set; }
        public virtual Student Student { get; set; }
        public virtual Module Module { get; set; }

    }
}
