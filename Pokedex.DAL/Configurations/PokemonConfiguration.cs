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
    internal class PokemonConfiguration : IEntityTypeConfiguration<Pokemon>
    {
        public void Configure(EntityTypeBuilder<Pokemon> builder)
        {
            // retirer l'auo incrémentation
            builder.Property(p => p.Numero).ValueGeneratedNever();

            // definir une valeur par defaut
            builder.Property(p => p.IsLegendary).HasDefaultValue(false);
            //builder
            //    // CHAR(100)
            //    .Property(p => p.Description)
            //    .IsUnicode(false)
            //    .IsFixedLength()
            //    .HasMaxLength(100);

            // ajouter un index unique sur la colonne Name
            builder.HasIndex(p => p.Name).IsUnique();

            builder.HasData(
                new Pokemon {
                    Numero = 25,
                    Name = "Pikachu",
                    TypeId = 1,
                },
                new Pokemon {
                    Numero = 1,
                    Name = "Bulbizarre",
                    TypeId = 4,
                },
                new Pokemon
                {
                    Numero = 2,
                    Name = "Herbizarre",
                    TypeId = 4,
                }
            );

            builder.HasOne(p => p.Type)
                .WithMany(p => p.Pokemons)
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasMany(p => p.Attacks)
                .WithMany(a => a.Pokemons)
                .UsingEntity("AttackPokemon", j =>
                {
                    j.HasData(
                        new { PokemonsNumero = 25, AttacksId = 1 },
                        new { PokemonsNumero = 25, AttacksId = 2 },
                        new { PokemonsNumero = 1, AttacksId = 1 },
                        new { PokemonsNumero = 2, AttacksId = 1 },
                        new { PokemonsNumero = 2, AttacksId = 3 }
                    );
                });
        }
    }
}
