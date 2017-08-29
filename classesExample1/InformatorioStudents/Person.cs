using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InformatorioStudents
{
    public abstract class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public void whatsMyAgeAgain()
        {
            Console.WriteLine("my age is:{0} ", Age);
        }
    }
}
