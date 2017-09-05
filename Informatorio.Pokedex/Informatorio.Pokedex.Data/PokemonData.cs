using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Informatorio.Pokedex.Data
{
    public class PokemonData
    {
        public string Name { get; set; }
        public int Height { get; set; }


        public PokemonData(int height, string name)
        {
            this.Name = name;
            this.Height = height;
        }


    }
}
