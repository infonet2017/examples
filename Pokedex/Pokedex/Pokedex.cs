using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokedex
{
    public class Pokedex
    {
        private List<Pokemon> Pokemons { get; set; }

        public Pokedex()
        {
            Pokemons = new List<Pokemon>();
        }

        

        public void StorePokemon(int height, string name)
        {
            var pkm = new Pokemon(height, name);
            var isStored = false;
            foreach (var storedPokemon in this.Pokemons)
            {
                if(storedPokemon.Name == pkm.Name)
                {
                    Console.WriteLine("the pokemon has been already registered");
                    isStored = true;
                    break;
                }
            }

            if (!isStored)//si no esta almacenado
            {
                this.Pokemons.Add(pkm);
                Console.WriteLine("Pokemon successfully stored");
            }
            
        }

        public void ShowStoredPokemons()
        {
            foreach (Pokemon pkmn in this.Pokemons)
            {
                Console.WriteLine(pkmn.Name);
            }
        }
    }
}
