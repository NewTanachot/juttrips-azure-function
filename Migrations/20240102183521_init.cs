using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace juttrips_azure_function.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    UserName = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: true, collation: "utf8mb3_general_ci"),
                    Password = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: true, collation: "utf8mb3_general_ci"),
                    IvKey = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: true, collation: "utf8mb3_general_ci"),
                    ThemeStyle = table.Column<int>(type: "int", nullable: false),
                    ThemeColor = table.Column<int>(type: "int", nullable: false),
                    MapStyle = table.Column<int>(type: "int", nullable: false),
                    CreateAt = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                })
                .Annotation("Relational:Collation", "utf8mb3_general_ci");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
