using Microsoft.EntityFrameworkCore.Migrations;

namespace Henhouse.Logic.Migrations
{
    public partial class AddedEggs : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Eggs",
                columns: table => new
                {
                    EggModelId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ChickenName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WeightInGrams = table.Column<int>(type: "int", nullable: true),
                    IsWhite = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Eggs", x => x.EggModelId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Eggs");
        }
    }
}
