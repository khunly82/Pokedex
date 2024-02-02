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
                new PokemonType { Id = 1, Name = "ELECTRIK" },   
                new PokemonType { Id = 2, Name = "EAU" },
                new PokemonType { Id = 3, Name = "FEU" },
                new PokemonType { Id = 4, Name = "PLANTE" },
                new PokemonType { Id = 5, Name = "PSY" },
                new PokemonType { Id = 6, Name = "ROCHE" },
                new PokemonType { Id = 7, Name = "NORMAL" }
            );
        }
    }
}
