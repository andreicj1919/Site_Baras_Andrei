using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Site_Baras_Andrei.Migrations
{
    public partial class KcalProdus : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ValoriNutritionale",
                table: "Produs");

            migrationBuilder.AddColumn<int>(
                name: "ValoareNutritionalaID",
                table: "Produs",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "ValoareNutritionala",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Kcal = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ValoareNutritionala", x => x.ID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Produs_ValoareNutritionalaID",
                table: "Produs",
                column: "ValoareNutritionalaID");

            migrationBuilder.AddForeignKey(
                name: "FK_Produs_ValoareNutritionala_ValoareNutritionalaID",
                table: "Produs",
                column: "ValoareNutritionalaID",
                principalTable: "ValoareNutritionala",
                principalColumn: "ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Produs_ValoareNutritionala_ValoareNutritionalaID",
                table: "Produs");

            migrationBuilder.DropTable(
                name: "ValoareNutritionala");

            migrationBuilder.DropIndex(
                name: "IX_Produs_ValoareNutritionalaID",
                table: "Produs");

            migrationBuilder.DropColumn(
                name: "ValoareNutritionalaID",
                table: "Produs");

            migrationBuilder.AddColumn<decimal>(
                name: "ValoriNutritionale",
                table: "Produs",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);
        }
    }
}
