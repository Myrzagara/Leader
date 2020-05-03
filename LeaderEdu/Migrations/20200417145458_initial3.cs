using Microsoft.EntityFrameworkCore.Migrations;

namespace LeaderEdu.Migrations
{
    public partial class initial3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CoachId",
                table: "EduTime");

            migrationBuilder.DropColumn(
                name: "LeaderId",
                table: "EduTime");

            migrationBuilder.AddColumn<string>(
                name: "guid",
                table: "User",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CoachGuid",
                table: "EduTime",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LeaderGuid",
                table: "EduTime",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "guid",
                table: "User");

            migrationBuilder.DropColumn(
                name: "CoachGuid",
                table: "EduTime");

            migrationBuilder.DropColumn(
                name: "LeaderGuid",
                table: "EduTime");

            migrationBuilder.AddColumn<int>(
                name: "CoachId",
                table: "EduTime",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "LeaderId",
                table: "EduTime",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
