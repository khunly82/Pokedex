using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Pokedex.DAL.Entities;

namespace Pokedex.DAL.Configurations
{
    internal class TypeConfiguration : IEntityTypeConfiguration<PokemonType>
    {
        public void Configure(EntityTypeBuilder<PokemonType> builder)
        {
            builder.HasData(
                new PokemonType { Id = 8, Name = "ACIER" },
                new PokemonType { Id = 9, Name = "COMBAT" },
                new PokemonType { Id = 10, Name = "DRAGON" },
                new PokemonType { Id = 2, Name = "EAU" },
                new PokemonType { Id = 1, Name = "ELECTRIK" },
                new PokemonType { Id = 11, Name = "FEE" },
                new PokemonType { Id = 3, Name = "FEU" },
                new PokemonType { Id = 12, Name = "GLACE" },
                new PokemonType { Id = 13, Name = "INSECTE" },
                new PokemonType { Id = 7, Name = "NORMAL" },
                new PokemonType { Id = 4, Name = "PLANTE" },
                new PokemonType { Id = 14, Name = "POISON" },
                new PokemonType { Id = 5, Name = "PSY" },
                new PokemonType { Id = 6, Name = "ROCHE" },
                new PokemonType { Id = 15, Name = "SOL" },
                new PokemonType { Id = 16, Name = "SPECTRE" },
                new PokemonType { Id = 17, Name = "TENEBRE" },
                new PokemonType { Id = 18, Name = "VOL" }
            );
        }
    }
}
