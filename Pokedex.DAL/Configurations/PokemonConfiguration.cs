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
                },
                new Pokemon
                {
                    Numero = 3,
                    Name = "Florizarre",
                    TypeId = 4,
                },
                new Pokemon
                {
                    Numero = 4,
                    Name = "Salameche",
                    TypeId = 4,
                },
                new Pokemon
                {
                    Numero = 5,
                    Name = "Reptincel",
                    TypeId = 4,
                }
                ,
                new Pokemon
                {
                    Numero = 6,
                    Name = "Dracaufeu",
                    TypeId = 4,
                }
                ,
                new Pokemon
                {
                    Numero = 7,
                    Name = "Carapuce",
                    TypeId = 2,
                }
                ,
                new Pokemon
                {
                    Numero = 8,
                    Name = "Carabaffe",
                    TypeId = 2,
                },
                new Pokemon
                {
                    Numero = 9,
                    Name = "Tortank",
                    TypeId = 2,
                },
                new Pokemon
                {
                    Numero = 10,
                    Name = "Chenipan",
                    TypeId = 13,
                }
                ,
                new Pokemon
                {
                    Numero = 11,
                    Name = "Chrysacier",
                    TypeId = 13,
                },
                new Pokemon
                {
                    Numero = 12,
                    Name = "Papilusion",
                    TypeId = 13,
                },
                new Pokemon
                {
                    Numero = 13,
                    Name = "Aspicot",
                    TypeId = 13,
                },
                new Pokemon
                {
                    Numero = 14,
                    Name = "Coconfort",
                    TypeId = 13,
                },
                new Pokemon
                {
                    Numero = 15,
                    Name = "Dardargnan",
                    TypeId = 13,
                },
                new Pokemon
                {
                    Numero = 16,
                    Name = "Roucool",
                    TypeId = 18,
                },
                new Pokemon
                {
                    Numero = 17,
                    Name = "Roucoups",
                    TypeId = 18,
                },
                new Pokemon
                {
                    Numero = 18,
                    Name = "Roucarnage",
                    TypeId = 18,
                },
                new Pokemon
                {
                    Numero = 19,
                    Name = "Rattata",
                    TypeId = 7,
                },
                new Pokemon
                {
                    Numero = 20,
                    Name = "Rattatac",
                    TypeId = 7,
                },
                new Pokemon
                {
                    Numero = 21,
                    Name = "Piafabec",
                    TypeId = 18,
                },
                new Pokemon
                {
                    Numero = 22,
                    Name = "Rapasdepic",
                    TypeId = 18,
                },
                new Pokemon
                {
                    Numero = 23,
                    Name = "Abo",
                    TypeId = 14,
                },
                new Pokemon
                {
                    Numero = 24,
                    Name = "Arbok",
                    TypeId = 14,
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
