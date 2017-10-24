using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreEFEXample.Models
{
    public static class DbInitializer
    {
        public static void Initialize(StudentContext context)
        {
            context.Database.EnsureCreated();

            // Look for any students.
            if (context.Students.Any())
            {
                return;   // DB has been seeded
            }

            var students = new Student[]
            {
            new Student{FirstName="Carson",LastName="Alexander",BirthDate=DateTime.Parse("2005-09-01")},
            new Student{FirstName="Meredith",LastName="Alonso",BirthDate=DateTime.Parse("2002-09-01")},
            new Student{FirstName="Arturo",LastName="Anand",BirthDate=DateTime.Parse("2003-09-01")},
            new Student{FirstName="Gytis",LastName="Barzdukas",BirthDate=DateTime.Parse("2002-09-01")},
            new Student{FirstName="Yan",LastName="Li",BirthDate=DateTime.Parse("2002-09-01")},
            new Student{FirstName="Peggy",LastName="Justice",BirthDate=DateTime.Parse("2001-09-01")},
            new Student{FirstName="Laura",LastName="Norman",BirthDate=DateTime.Parse("2003-09-01")},
            new Student{FirstName="Nino",LastName="Olivetto",BirthDate=DateTime.Parse("2005-09-01")}
            };
            foreach (Student s in students)
            {
                context.Students.Add(s);
            }
            context.SaveChanges();

           
        }
    }
}
