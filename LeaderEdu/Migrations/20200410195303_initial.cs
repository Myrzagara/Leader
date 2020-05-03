using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LeaderEdu.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    email = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true),
                    Iin = table.Column<string>(nullable: true),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    MiddleName = table.Column<string>(nullable: true),
                    BirthDate = table.Column<DateTime>(nullable: false),
                    Sex = table.Column<int>(nullable: false),
                    Phone = table.Column<string>(nullable: true),
                    Skype = table.Column<string>(nullable: true),
                    Branch = table.Column<int>(nullable: false),
                    Type = table.Column<int>(nullable: false),
                    LeaderType = table.Column<int>(nullable: false),
                    CoachType = table.Column<int>(nullable: false),
                    CoachICF = table.Column<bool>(nullable: false),
                    CoachEducation = table.Column<int>(nullable: false),
                    CoachBranch = table.Column<int>(nullable: false),
                    CoachStatus = table.Column<int>(nullable: false),
                    City = table.Column<int>(nullable: false),
                    Job = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "User");
        }
    }
}
