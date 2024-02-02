using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Pokedex.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokedex.DAL.Configurations
{
    internal class ImageConfiguration : IEntityTypeConfiguration<Image>
    {
        public void Configure(EntityTypeBuilder<Image> builder)
        {
            builder.HasData(
                new Image { Id = 1, PokemonNumero = 25, Url = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/other/official-artwork/25.png" },
                new Image { Id = 2, PokemonNumero = 1, Url = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/other/official-artwork/1.png" },
                new Image { Id = 3, PokemonNumero = 2, Url = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/other/official-artwork/2.png" },
                new Image { Id = 4, PokemonNumero = 3, Url = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/other/official-artwork/3.png" },
                new Image { Id = 5, PokemonNumero = 4, Url = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/other/official-artwork/4.png" },
                new Image { Id = 6, PokemonNumero = 5, Url = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/other/official-artwork/5.png" },
                new Image { Id = 7, PokemonNumero = 6, Url = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/other/official-artwork/6.png" },
                new Image { Id = 8, PokemonNumero = 7, Url = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/other/official-artwork/7.png" },
                new Image { Id = 9, PokemonNumero = 8, Url = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/other/official-artwork/8.png" },
                new Image { Id = 10, PokemonNumero = 9, Url = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/other/official-artwork/9.png" },
                new Image { Id = 11, PokemonNumero = 10, Url = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/other/official-artwork/10.png" },
                new Image { Id = 12, PokemonNumero = 11, Url = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/other/official-artwork/11.png" },
                new Image { Id = 13, PokemonNumero = 12, Url = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/other/official-artwork/12.png" },
                new Image { Id = 14, PokemonNumero = 13, Url = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/other/official-artwork/13.png" },
                new Image { Id = 15, PokemonNumero = 14, Url = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/other/official-artwork/14.png" },
                new Image { Id = 16, PokemonNumero = 15, Url = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/other/official-artwork/15.png" },
                new Image { Id = 17, PokemonNumero = 16, Url = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/other/official-artwork/16.png" },
                new Image { Id = 18, PokemonNumero = 17, Url = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/other/official-artwork/17.png" },
                new Image { Id = 19, PokemonNumero = 18, Url = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/other/official-artwork/18.png" },
                new Image { Id = 20, PokemonNumero = 19, Url = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/other/official-artwork/19.png" },
                new Image { Id = 21, PokemonNumero = 20, Url = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/other/official-artwork/20.png" },
                new Image { Id = 22, PokemonNumero = 21, Url = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/other/official-artwork/21.png" },
                new Image { Id = 23, PokemonNumero = 22, Url = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/other/official-artwork/22.png" },
                new Image { Id = 24, PokemonNumero = 23, Url = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/other/official-artwork/23.png" },
                new Image { Id = 25, PokemonNumero = 24, Url = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/other/official-artwork/24.png" }
            );
        }
    }
}
