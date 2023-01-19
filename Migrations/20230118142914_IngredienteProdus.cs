using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Site_Baras_Andrei.Migrations
{
    public partial class IngredienteProdus : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Ingrediente",
                table: "Produs");

            migrationBuilder.AddColumn<int>(
                name: "IngredientID",
                table: "Produs",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Ingredient",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NumeIngredient = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ingredient", x => x.ID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Produs_IngredientID",
                table: "Produs",
                column: "IngredientID");

            migrationBuilder.AddForeignKey(
                name: "FK_Produs_Ingredient_IngredientID",
                table: "Produs",
                column: "IngredientID",
                principalTable: "Ingredient",
                principalColumn: "ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Produs_Ingredient_IngredientID",
                table: "Produs");

            migrationBuilder.DropTable(
                name: "Ingredient");

            migrationBuilder.DropIndex(
                name: "IX_Produs_IngredientID",
                table: "Produs");

            migrationBuilder.DropColumn(
                name: "IngredientID",
                table: "Produs");

            migrationBuilder.AddColumn<string>(
                name: "Ingrediente",
                table: "Produs",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
