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
                    { 7, "NORMAL" }
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
                    { 3, 2, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/other/official-artwork/2.png" }
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
