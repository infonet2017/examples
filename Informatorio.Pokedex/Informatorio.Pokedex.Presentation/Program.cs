using Informatorio.pokedex.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Informatorio.Pokedex.Presentation
{
    class Program
    {
        static void Main(string[] args)
        {
            var pokemngr = new PokemonManager();
            pokemngr.RegisterPokemon("pikachu", 123);
            pokemngr.RegisterPokemon("pikachu", 1234);
            pokemngr.RegisterPokemon("charizard", 1234);

            var textToshow = pokemngr.GetAllPokemons();
            Console.WriteLine(textToshow);

            Console.ReadKey();

        }
    }
}
