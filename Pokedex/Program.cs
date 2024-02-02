using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query.SqlExpressions;
using Pokedex.DAL;
using Pokedex.DAL.Entities;


// créer le context
PokedexContext pokedexContext = new PokedexContext();

// chercher toutes les attaques
// SELECT * FROM Attacks
// List<Attack> attacks = pokedexContext.Attacks.ToList();

// checher toutes les attaques du typeId 7
// SELECT * FROM Attack WHERE typeId = 7 
//List<Attack> attacks = pokedexContext.Attacks
//    .Where(a => a.TypeId == 7).ToList();

// SELECT a.*
// FROM Attack a
// JOIN Type t ON t.Id = a.TypeId
// WHERE t.Name = 'NORMAL' 
//List<Attack> attacks = pokedexContext.Attacks
//    .Where(a => a.Type.Name == "NORMAL").ToList();


// SELECT a.*, t.*
// FROM Attack a
// JOIN Type t ON t.Id = a.TypeId
// WHERE t.Name = 'NORMAL' 
//List<Attack> attacks = pokedexContext.Attacks
//    .Include(a => a.Type)
//    .Where(a => a.Type.Name == "NORMAL")
//    .ToList();


// SELECT * FROM Attacks
// ORDER BY TypeId ASC, Name DESC
//List<Attack> attacks = pokedexContext.Attacks
//    .OrderBy(a => a.TypeId)
//    .ThenByDescending(a => a.Name)
//    .ToList();

//Attack? attack = pokedexContext.Attacks.SingleOrDefault(a => a.Name.Contains("Foudre"));

Attack? attack = pokedexContext.Attacks.Find(1);
// <=> pokedexContext.Attacks.SingleOrDefault(a => a.Id == 1)

Console.WriteLine(attack?.Name ?? "Attaque introuvable");

//foreach (Attack attack in attacks)
//{
//    Console.WriteLine(attack.Name);
//}