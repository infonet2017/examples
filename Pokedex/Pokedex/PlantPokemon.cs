using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokedex
{
    public class PlantPokemon : Pokemon
    {
        public int PhotosistesisLevel { get; set; }

        public PlantPokemon(int height, string name, int levelPhotos) : base(height, name)
        {
            this.PhotosistesisLevel = levelPhotos;
        }


        public void VineWhip()
        {
            Console.WriteLine("the pokemon used vinewhip");
        }
    }
}
