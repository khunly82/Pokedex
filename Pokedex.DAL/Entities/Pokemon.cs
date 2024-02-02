using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokedex.DAL.Entities
{
    public class Pokemon
    {
        [Key]
        // retirer l'autoincrémentation de la colonne
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero { get; set; }
        public string Name { get; set; } = null!;
        public bool IsLegendary { get; set; }
        public string? Description { get; set; }
        public int TypeId { get; set; }
        public Image Image { get; set; } = null!;
        public PokemonType Type { get; set; } = null!;
        public ICollection<Attack> Attacks { get; set; } = null!;
    }
}
