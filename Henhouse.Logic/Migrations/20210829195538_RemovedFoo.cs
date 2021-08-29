using Microsoft.EntityFrameworkCore.Migrations;

namespace Henhouse.Logic.Migrations
{
    public partial class RemovedFoo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Foo",
                table: "Eggs");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Foo",
                table: "Eggs",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
