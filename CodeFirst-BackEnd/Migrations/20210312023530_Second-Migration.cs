using Microsoft.EntityFrameworkCore.Migrations;

namespace CodeFirst_BackEnd.Migrations
{
    public partial class SecondMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsInternationalCertification",
                table: "Carreers",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsInternationalCertification",
                table: "Carreers");
        }
    }
}
