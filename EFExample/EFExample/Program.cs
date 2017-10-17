using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFExample
{
    class Program
    {
        static void Main(string[] args)
        {

            //correr la primera vez
            /**

            var dbContext = new InfoDBContext();
            
            var student = new Student();
            student.Name = "sergio";
            student.BirthDate = DateTime.Today;

            var module = new Module();
            module.Name = "net";
            module.Description = "net classes";


            var enrollment = new Enrollment();
            enrollment.Module = module;
            enrollment.Student = student;
            enrollment.DateOfEnrollment = DateTime.Today;


            dbContext.Enrollments.Add(enrollment);
            //var sergio = dbContext.Students.Where(s => s.Name == "sergio").FirstOrDefault();

            //dbContext.Students.Remove(sergio);



            dbContext.SaveChanges();
    */

            //correr la segunda vez

            /**

            var dbContext = new InfoDBContext();
            Student sergio = dbContext.Students.Where(e => e.ID == 7).FirstOrDefault();
            foreach(var mod in sergio.Enrollments)
            {
                Console.WriteLine(mod.Module.Name);
            }

     **/

            Console.WriteLine("termino!");
            Console.ReadLine();

        }
    }
}
