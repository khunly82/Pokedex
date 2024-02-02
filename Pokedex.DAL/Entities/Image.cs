using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokedex.DAL.Entities
{
    public class Image
    {
        public int Id { get; set; }
        public string Url { get; set; } = null!;
        public int PokemonNumero { get; set; }
        public Pokemon Pokemon { get; set; } = null!;
    }
}
