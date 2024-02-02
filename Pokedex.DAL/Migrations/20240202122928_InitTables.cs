using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Pokedex.DAL.Migrations
{
    /// <inheritdoc />
    public partial class InitTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Types",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Types", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Attacks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TypeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Attacks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Attacks_Types_TypeId",
                        column: x => x.TypeId,
                        principalTable: "Types",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Pokemons",
                columns: table => new
                {
                    Numero = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    IsLegendary = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TypeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pokemons", x => x.Numero);
                    table.ForeignKey(
                        name: "FK_Pokemons_Types_TypeId",
                        column: x => x.TypeId,
                        principalTable: "Types",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "AttackPokemon",
                columns: table => new
                {
                    AttacksId = table.Column<int>(type: "int", nullable: false),
                    PokemonsNumero = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AttackPokemon", x => new { x.AttacksId, x.PokemonsNumero });
                    table.ForeignKey(
                        name: "FK_AttackPokemon_Attacks_AttacksId",
                        column: x => x.AttacksId,
                        principalTable: "Attacks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AttackPokemon_Pokemons_PokemonsNumero",
                        column: x => x.PokemonsNumero,
                        principalTable: "Pokemons",
                        principalColumn: "Numero",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Images",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PokemonNumero = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Images", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Images_Pokemons_PokemonNumero",
                        column: x => x.PokemonNumero,
                        principalTable: "Pokemons",
                        principalColumn: "Numero",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Types",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "ELECTRIK" },
                    { 2, "EAU" },
                    { 3, "FEU" },
                    { 4, "PLANTE" },
                    { 5, "PSY" },
                    { 6, "ROCHE" },
                    { 7, "NORMAL" },
                    { 8, "ACIER" },
                    { 9, "COMBAT" },
                    { 10, "DRAGON" },
                    { 11, "FEE" },
                    { 12, "GLACE" },
                    { 13, "INSECTE" },
                    { 14, "POISON" },
                    { 15, "SOL" },
                    { 16, "SPECTRE" },
                    { 17, "TENEBRE" },
                    { 18, "VOL" }
                });

            migrationBuilder.InsertData(
                table: "Attacks",
                columns: new[] { "Id", "Name", "TypeId" },
                values: new object[,]
                {
                    { 1, "Charge", 7 },
                    { 2, "Fatal Foudre", 1 },
                    { 3, "Tranche Herbe", 4 }
                });

            migrationBuilder.InsertData(
                table: "Pokemons",
                columns: new[] { "Numero", "Description", "Name", "TypeId" },
                values: new object[,]
                {
                    { 1, null, "Bulbizarre", 4 },
                    { 2, null, "Herbizarre", 4 },
                    { 3, null, "Florizarre", 4 },
                    { 4, null, "Salameche", 4 },
                    { 5, null, "Reptincel", 4 },
                    { 6, null, "Dracaufeu", 4 },
                    { 7, null, "Carapuce", 2 },
                    { 8, null, "Carabaffe", 2 },
                    { 9, null, "Tortank", 2 },
                    { 10, null, "Chenipan", 13 },
                    { 11, null, "Chrysacier", 13 },
                    { 12, null, "Papilusion", 13 },
                    { 13, null, "Aspicot", 13 },
                    { 14, null, "Coconfort", 13 },
                    { 15, null, "Dardargnan", 13 },
                    { 16, null, "Roucool", 18 },
                    { 17, null, "Roucoups", 18 },
                    { 18, null, "Roucarnage", 18 },
                    { 19, null, "Rattata", 7 },
                    { 20, null, "Rattatac", 7 },
                    { 21, null, "Piafabec", 18 },
                    { 22, null, "Rapasdepic", 18 },
                    { 23, null, "Abo", 14 },
                    { 24, null, "Arbok", 14 },
                    { 25, null, "Pikachu", 1 }
                });

            migrationBuilder.InsertData(
                table: "AttackPokemon",
                columns: new[] { "AttacksId", "PokemonsNumero" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 1, 2 },
                    { 1, 25 },
                    { 2, 25 },
                    { 3, 2 }
                });

            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "Id", "PokemonNumero", "Url" },
                values: new object[,]
                {
                    { 1, 25, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/other/official-artwork/25.png" },
                    { 2, 1, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/other/official-artwork/1.png" },
                    { 3, 2, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/other/official-artwork/2.png" },
                    { 4, 3, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/other/official-artwork/3.png" },
                    { 5, 4, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/other/official-artwork/4.png" },
                    { 6, 5, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/other/official-artwork/5.png" },
                    { 7, 6, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/other/official-artwork/6.png" },
                    { 8, 7, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/other/official-artwork/7.png" },
                    { 9, 8, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/other/official-artwork/8.png" },
                    { 10, 9, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/other/official-artwork/9.png" },
                    { 11, 10, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/other/official-artwork/10.png" },
                    { 12, 11, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/other/official-artwork/11.png" },
                    { 13, 12, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/other/official-artwork/12.png" },
                    { 14, 13, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/other/official-artwork/13.png" },
                    { 15, 14, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/other/official-artwork/14.png" },
                    { 16, 15, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/other/official-artwork/15.png" },
                    { 17, 16, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/other/official-artwork/16.png" },
                    { 18, 17, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/other/official-artwork/17.png" },
                    { 19, 18, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/other/official-artwork/18.png" },
                    { 20, 19, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/other/official-artwork/19.png" },
                    { 21, 20, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/other/official-artwork/20.png" },
                    { 22, 21, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/other/official-artwork/21.png" },
                    { 23, 22, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/other/official-artwork/22.png" },
                    { 24, 23, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/other/official-artwork/23.png" },
                    { 25, 24, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/other/official-artwork/24.png" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AttackPokemon_PokemonsNumero",
                table: "AttackPokemon",
                column: "PokemonsNumero");

            migrationBuilder.CreateIndex(
                name: "IX_Attacks_TypeId",
                table: "Attacks",
                column: "TypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Images_PokemonNumero",
                table: "Images",
                column: "PokemonNumero",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Pokemons_Name",
                table: "Pokemons",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Pokemons_TypeId",
                table: "Pokemons",
                column: "TypeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AttackPokemon");

            migrationBuilder.DropTable(
                name: "Images");

            migrationBuilder.DropTable(
                name: "Attacks");

            migrationBuilder.DropTable(
                name: "Pokemons");

            migrationBuilder.DropTable(
                name: "Types");
        }
    }
}
