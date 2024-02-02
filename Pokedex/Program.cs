using Microsoft.EntityFrameworkCore;
using Pokedex.DAL;
using Pokedex.DAL.Entities;

PokedexContext context = new PokedexContext();

// Afficher le nom et numero de tous les Pokemons

// List<Pokemon> pokemonList = context.Pokemons.ToList();


// pour ne prendre que les propriétés qui nous intéressent
//var pokemonList = context.Pokemons
//    .Select(p => new { p.Numero, p.Name })
//    .ToList();

// Afficher le nom, le numero de tous les Pokemons du type 18
//List<Pokemon> pokemonList = context.Pokemons.Where(p => p.TypeId == 18).ToList();


// Afficher le nom, le numero de tous les Pokemons dont le nom du type est poison
//List<Pokemon> pokemonList = context.Pokemons
//    .Where(p => p.Type.Name == "POISON").ToList();


// Afficher le nom, le numero de tous les Pokemons du type 7 ou du type 4
// List<Pokemon> pokemonList = context.Pokemons.Where(p => p.TypeId == 7 || p.TypeId == 4).ToList();

// Afficher le nom, le numero de tous les Pokemons dont le nom commence par 'R'
// List<Pokemon> pokemonList = context.Pokemons.Where(p => p.Name.StartsWith("R")).ToList();

// Afficher le nom, le nom du type de tous les pokemons triés par nom du type ASC
// List<Pokemon> pokemonList = context.Pokemons.OrderBy(p => p.Type.Name).ToList();

//foreach (Pokemon item in pokemonList)
//{
//    Console.WriteLine($"numero: {item.Numero} nom: {item.Name} type: {item.TypeId}");
//}

// Afficher le nom, le nom du type du pokemon dont l'id est 16
//Pokemon? pokemon = context.Pokemons
//    .Include(p => p.Type)
//    .FirstOrDefault(p => p.Numero == 16);

//Console.WriteLine($"{pokemon?.Name} {pokemon?.Numero} {pokemon?.Type.Name}");
