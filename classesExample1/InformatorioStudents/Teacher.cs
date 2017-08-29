using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InformatorioStudents
{
    public class Teacher: Person
    {
        public string Technology { get; set; }

        public Teacher(string name, string technology, int age)
        {
            this.Technology = technology;
            base.Name = name;
            base.Age = age;

        }

        public Teacher()
        {
           
        }
    }
}
