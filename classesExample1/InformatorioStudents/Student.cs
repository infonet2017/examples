using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InformatorioStudents
{
    public class Student: Person
    {
        public String Address { get; set; }

        public Student(String address, int age, string name)
        {
            this.Address = address;
            base.Age = age;
            base.Name = name;

        }

        public void printInformation()
        {
            Console.WriteLine("My name is {0} and I'm {1} years old. I live in {2}.", Name, Age, Address);

        }
    }
}
