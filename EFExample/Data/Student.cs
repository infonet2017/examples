using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class Student
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public virtual ICollection<Enrollment> Enrollments { get; set; }

    }
}
