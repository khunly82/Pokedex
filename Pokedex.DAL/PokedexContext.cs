using Microsoft.EntityFrameworkCore;
using Pokedex.DAL.Configurations;
using Pokedex.DAL.Entities;

namespace Pokedex.DAL
{
    public class PokedexContext: DbContext
    {
        public DbSet<Pokemon> Pokemons { get; set; }
        public DbSet<PokemonType> Types { get; set; }
        public DbSet<Attack> Attacks { get; set; }
        public DbSet<Image> Images { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"server=(localdb)\MSSQLLocalDB;database=pokedex;integrated security=true;trustserver certificate=true");

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new PokemonConfiguration());
            modelBuilder.ApplyConfiguration(new ImageConfiguration());
            modelBuilder.ApplyConfiguration(new TypeConfiguration());
            modelBuilder.ApplyConfiguration(new AttackConfiguration());
        }
    }
}
