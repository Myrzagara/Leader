using Microsoft.EntityFrameworkCore.Migrations;

namespace LeaderEdu.Migrations
{
    public partial class initial5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "guid",
                table: "QuestionnaireLeader",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "guid",
                table: "QuestionnaireLeader");
        }
    }
}
