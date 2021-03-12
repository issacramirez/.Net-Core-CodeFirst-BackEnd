using Microsoft.EntityFrameworkCore.Migrations;

namespace CodeFirst_BackEnd.Migrations
{
    public partial class FirstMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Carreers",
                columns: table => new
                {
                    CarreerID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Duration = table.Column<int>(nullable: false),
                    Type = table.Column<int>(nullable: false),
                    Plan = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Carreers", x => x.CarreerID);
                });

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    LastName1 = table.Column<string>(nullable: true),
                    LastName2 = table.Column<string>(nullable: true),
                    StudentNumber = table.Column<string>(nullable: true),
                    CarreerID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Students_Carreers_CarreerID",
                        column: x => x.CarreerID,
                        principalTable: "Carreers",
                        principalColumn: "CarreerID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Students_CarreerID",
                table: "Students",
                column: "CarreerID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropTable(
                name: "Carreers");
        }
    }
}
