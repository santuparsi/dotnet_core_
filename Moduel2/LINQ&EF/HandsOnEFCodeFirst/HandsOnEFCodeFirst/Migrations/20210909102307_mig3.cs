using Microsoft.EntityFrameworkCore.Migrations;

namespace HandsOnEFCodeFirst.Migrations
{
    public partial class mig3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ProjectCode",
                table: "Employee",
                type: "Char(5)",
                maxLength: 5,
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Project",
                columns: table => new
                {
                    ProjectCode = table.Column<string>(type: "Char(5)", maxLength: 5, nullable: false),
                    ProjectName = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Project", x => x.ProjectCode);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Employee_ProjectCode",
                table: "Employee",
                column: "ProjectCode");

            migrationBuilder.AddForeignKey(
                name: "FK_Employee_Project_ProjectCode",
                table: "Employee",
                column: "ProjectCode",
                principalTable: "Project",
                principalColumn: "ProjectCode",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employee_Project_ProjectCode",
                table: "Employee");

            migrationBuilder.DropTable(
                name: "Project");

            migrationBuilder.DropIndex(
                name: "IX_Employee_ProjectCode",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "ProjectCode",
                table: "Employee");
        }
    }
}
