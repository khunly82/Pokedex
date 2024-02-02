﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Pokedex.DAL;

#nullable disable

namespace Pokedex.DAL.Migrations
{
    [DbContext(typeof(PokedexContext))]
    [Migration("20240202104449_InitTables")]
    partial class InitTables
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("AttackPokemon", b =>
                {
                    b.Property<int>("AttacksId")
                        .HasColumnType("int");

                    b.Property<int>("PokemonsNumero")
                        .HasColumnType("int");

                    b.HasKey("AttacksId", "PokemonsNumero");

                    b.HasIndex("PokemonsNumero");

                    b.ToTable("AttackPokemon");

                    b.HasData(
                        new
                        {
                            AttacksId = 1,
                            PokemonsNumero = 25
                        },
                        new
                        {
                            AttacksId = 2,
                            PokemonsNumero = 25
                        },
                        new
                        {
                            AttacksId = 1,
                            PokemonsNumero = 1
                        },
                        new
                        {
                            AttacksId = 1,
                            PokemonsNumero = 2
                        },
                        new
                        {
                            AttacksId = 3,
                            PokemonsNumero = 2
                        });
                });

            modelBuilder.Entity("Pokedex.DAL.Entities.Attack", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TypeId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TypeId");

                    b.ToTable("Attacks");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Charge",
                            TypeId = 7
                        },
                        new
                        {
                            Id = 2,
                            Name = "Fatal Foudre",
                            TypeId = 1
                        },
                        new
                        {
                            Id = 3,
                            Name = "Tranche Herbe",
                            TypeId = 4
                        });
                });

            modelBuilder.Entity("Pokedex.DAL.Entities.Image", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("PokemonNumero")
                        .HasColumnType("int");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("PokemonNumero")
                        .IsUnique();

                    b.ToTable("Images");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            PokemonNumero = 25,
                            Url = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/other/official-artwork/25.png"
                        },
                        new
                        {
                            Id = 2,
                            PokemonNumero = 1,
                            Url = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/other/official-artwork/1.png"
                        },
                        new
                        {
                            Id = 3,
                            PokemonNumero = 2,
                            Url = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/other/official-artwork/2.png"
                        });
                });

            modelBuilder.Entity("Pokedex.DAL.Entities.Pokemon", b =>
                {
                    b.Property<int>("Numero")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsLegendary")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(false);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("TypeId")
                        .HasColumnType("int");

                    b.HasKey("Numero");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.HasIndex("TypeId");

                    b.ToTable("Pokemons");

                    b.HasData(
                        new
                        {
                            Numero = 25,
                            IsLegendary = false,
                            Name = "Pikachu",
                            TypeId = 1
                        },
                        new
                        {
                            Numero = 1,
                            IsLegendary = false,
                            Name = "Bulbizarre",
                            TypeId = 4
                        },
                        new
                        {
                            Numero = 2,
                            IsLegendary = false,
                            Name = "Herbizarre",
                            TypeId = 4
                        });
                });

            modelBuilder.Entity("Pokedex.DAL.Entities.PokemonType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Types");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "ELECTRIK"
                        },
                        new
                        {
                            Id = 2,
                            Name = "EAU"
                        },
                        new
                        {
                            Id = 3,
                            Name = "FEU"
                        },
                        new
                        {
                            Id = 4,
                            Name = "PLANTE"
                        },
                        new
                        {
                            Id = 5,
                            Name = "PSY"
                        },
                        new
                        {
                            Id = 6,
                            Name = "ROCHE"
                        },
                        new
                        {
                            Id = 7,
                            Name = "NORMAL"
                        });
                });

            modelBuilder.Entity("AttackPokemon", b =>
                {
                    b.HasOne("Pokedex.DAL.Entities.Attack", null)
                        .WithMany()
                        .HasForeignKey("AttacksId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Pokedex.DAL.Entities.Pokemon", null)
                        .WithMany()
                        .HasForeignKey("PokemonsNumero")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Pokedex.DAL.Entities.Attack", b =>
                {
                    b.HasOne("Pokedex.DAL.Entities.PokemonType", "Type")
                        .WithMany("Attacks")
                        .HasForeignKey("TypeId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Type");
                });

            modelBuilder.Entity("Pokedex.DAL.Entities.Image", b =>
                {
                    b.HasOne("Pokedex.DAL.Entities.Pokemon", "Pokemon")
                        .WithOne("Image")
                        .HasForeignKey("Pokedex.DAL.Entities.Image", "PokemonNumero")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Pokemon");
                });

            modelBuilder.Entity("Pokedex.DAL.Entities.Pokemon", b =>
                {
                    b.HasOne("Pokedex.DAL.Entities.PokemonType", "Type")
                        .WithMany("Pokemons")
                        .HasForeignKey("TypeId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Type");
                });

            modelBuilder.Entity("Pokedex.DAL.Entities.Pokemon", b =>
                {
                    b.Navigation("Image")
                        .IsRequired();
                });

            modelBuilder.Entity("Pokedex.DAL.Entities.PokemonType", b =>
                {
                    b.Navigation("Attacks");

                    b.Navigation("Pokemons");
                });
#pragma warning restore 612, 618
        }
    }
}