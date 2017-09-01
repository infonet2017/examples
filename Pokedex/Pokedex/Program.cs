using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokedex
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("What do you want to do?:" +
                " 1 = register pokemon/ 2 = See registered" +
                " pokemons ");

             var response = Convert.ToInt32(Console.ReadLine());

            var pokedex = new Pokedex();
            pokedex.StorePokemon(123, "pikachu");
            pokedex.ShowStoredPokemons();
            Console.ReadLine();



            




        }
    }
}
