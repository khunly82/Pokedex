using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokedex.DAL.Entities
{
    public class PokemonType
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public ICollection<Pokemon> Pokemons { get; set; } = null!;
        public ICollection<Attack> Attacks { get; set; } = null!;

    }
}
