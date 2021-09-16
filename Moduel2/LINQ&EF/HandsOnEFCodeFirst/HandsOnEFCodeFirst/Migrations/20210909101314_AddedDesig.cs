using Microsoft.EntityFrameworkCore.Migrations;

namespace HandsOnEFCodeFirst.Migrations
{
    public partial class AddedDesig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Designation",
                table: "Employee",
                type: "Varchar(20)",
                maxLength: 20,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Designation",
                table: "Employee");
        }
    }
}
