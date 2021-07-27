using Microsoft.EntityFrameworkCore.Migrations;

namespace TestApplication.Migrations
{
    public partial class NewTry : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "QuizTry2s",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Question = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    option1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    option2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    option3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    option4 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Correctans = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuizTry2s", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "QuizTry2s");
        }
    }
}
