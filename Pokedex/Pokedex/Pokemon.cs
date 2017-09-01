using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokedex
{
    public class Pokemon
    {
        public string Name { get; set; }
        public int Height { get; set; }


        public Pokemon(int height, string name)
        {
            this.Name = name;
            this.Height = height;
        }

        public void Assault()
        {
            Console.WriteLine("the pokemon used Asault");
        }

        public void Growl()
        {
            Console.WriteLine("the pokemon used Growl");
        }

    }
}
