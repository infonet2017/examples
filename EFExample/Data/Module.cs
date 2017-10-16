using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class Module
    {
        public int ID { get; set; }
        public string  Name { get; set; }
        public String Description { get; set; }
        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}
