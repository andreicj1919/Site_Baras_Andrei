using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Site_Baras_Andrei.Migrations
{
    public partial class PretMeniu : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PretID",
                table: "Produs",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Pret",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PretProdus = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pret", x => x.ID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Produs_PretID",
                table: "Produs",
                column: "PretID");

            migrationBuilder.AddForeignKey(
                name: "FK_Produs_Pret_PretID",
                table: "Produs",
                column: "PretID",
                principalTable: "Pret",
                principalColumn: "ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Produs_Pret_PretID",
                table: "Produs");

            migrationBuilder.DropTable(
                name: "Pret");

            migrationBuilder.DropIndex(
                name: "IX_Produs_PretID",
                table: "Produs");

            migrationBuilder.DropColumn(
                name: "PretID",
                table: "Produs");
        }
    }
}
