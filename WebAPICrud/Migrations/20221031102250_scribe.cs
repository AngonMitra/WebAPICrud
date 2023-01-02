using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebAPICrud.Migrations
{
    public partial class scribe : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(maxLength: 50, nullable: true),
                    LastName = table.Column<string>(maxLength: 50, nullable: true),
                    Email = table.Column<string>(maxLength: 100, nullable: true),
                    Age = table.Column<int>(nullable: false),
                    Doj = table.Column<DateTime>(nullable: false),
                    Gender = table.Column<string>(maxLength: 20, nullable: true),
                    IsMarried = table.Column<int>(nullable: false),
                    IsActive = table.Column<int>(nullable: false),
                    DesignationID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employees");
        }
    }
}
