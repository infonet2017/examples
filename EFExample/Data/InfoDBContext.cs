using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class InfoDBContext: System.Data.Entity.DbContext
    {
        public DbSet<Module> Modules { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }

        public InfoDBContext():base("InfoDbContext")
        {

        }

        
    }
}
