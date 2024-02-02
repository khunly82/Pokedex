using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokedex.DAL.Entities
{
    public class Attack
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public int TypeId { get; set; }
        public PokemonType Type { get; set; } = null!;
        public ICollection<Pokemon> Pokemons { get; set; } = null!;
    }
}
