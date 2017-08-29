using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InformatorioStudents
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insert student Name:");
            var studentName = Console.ReadLine();
            Console.WriteLine("Insert student age: ");
            var studentAge = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Insert student Address:");
            var studentAddress = Console.ReadLine();

            Student student = new Student(studentAddress, studentAge, studentName);

            student.printInformation();
            Console.ReadKey();
        }
    }
}
