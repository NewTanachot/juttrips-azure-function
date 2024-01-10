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
                name: "Group",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    IsPublic = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    OwnerUserId = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false, collation: "utf8mb3_general_ci"),
                    Name = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false, collation: "utf8mb3_general_ci"),
                    CreateDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    DeleteDate = table.Column<DateTime>(type: "datetime(6)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Group", x => x.Id);
                })
                .Annotation("Relational:Collation", "utf8mb3_general_ci");

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    Password = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false, collation: "utf8mb3_general_ci"),
                    IvKey = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false, collation: "utf8mb3_general_ci"),
                    ThemeStyle = table.Column<int>(type: "int", nullable: false),
                    ThemeColor = table.Column<int>(type: "int", nullable: false),
                    MapStyle = table.Column<int>(type: "int", nullable: false),
                    SubscriptionTier = table.Column<int>(type: "int", nullable: false),
                    SubscriptionExpireDate = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    Name = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false, collation: "utf8mb3_general_ci"),
                    CreateDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    DeleteDate = table.Column<DateTime>(type: "datetime(6)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                })
                .Annotation("Relational:Collation", "utf8mb3_general_ci");

            migrationBuilder.CreateTable(
                name: "GroupPlace",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    GroupId = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci"),
                    Name = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false, collation: "utf8mb3_general_ci"),
                    CreateDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    DeleteDate = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    Latitude = table.Column<double>(type: "double", nullable: true),
                    Longitude = table.Column<double>(type: "double", nullable: true),
                    Description = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true, collation: "utf8mb3_general_ci"),
                    AppointedDate = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    IsDisplay = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GroupPlace", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GroupPlace_Group_GroupId",
                        column: x => x.GroupId,
                        principalTable: "Group",
                        principalColumn: "Id");
                })
                .Annotation("Relational:Collation", "utf8mb3_general_ci");

            migrationBuilder.CreateTable(
                name: "GroupUser",
                columns: table => new
                {
                    GroupsId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    UsersId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GroupUser", x => new { x.GroupsId, x.UsersId });
                    table.ForeignKey(
                        name: "FK_GroupUser_Group_GroupsId",
                        column: x => x.GroupsId,
                        principalTable: "Group",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GroupUser_User_UsersId",
                        column: x => x.UsersId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("Relational:Collation", "utf8mb3_general_ci");

            migrationBuilder.CreateTable(
                name: "UserPlace",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    UserId = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci"),
                    Name = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false, collation: "utf8mb3_general_ci"),
                    CreateDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    DeleteDate = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    Latitude = table.Column<double>(type: "double", nullable: true),
                    Longitude = table.Column<double>(type: "double", nullable: true),
                    Description = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true, collation: "utf8mb3_general_ci"),
                    AppointedDate = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    IsDisplay = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserPlace", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserPlace_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id");
                })
                .Annotation("Relational:Collation", "utf8mb3_general_ci");

            migrationBuilder.CreateIndex(
                name: "IX_GroupPlace_GroupId",
                table: "GroupPlace",
                column: "GroupId");

            migrationBuilder.CreateIndex(
                name: "IX_GroupUser_UsersId",
                table: "GroupUser",
                column: "UsersId");

            migrationBuilder.CreateIndex(
                name: "IX_UserPlace_UserId",
                table: "UserPlace",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GroupPlace");

            migrationBuilder.DropTable(
                name: "GroupUser");

            migrationBuilder.DropTable(
                name: "UserPlace");

            migrationBuilder.DropTable(
                name: "Group");

            migrationBuilder.DropTable(
                name: "User");
        }
    }
}
