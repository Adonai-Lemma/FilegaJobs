using Microsoft.EntityFrameworkCore.Migrations;

namespace FilegaJobs.Migrations
{
    public partial class NewSeedJobsTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    resume = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.ID);
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "ID", "Name", "email", "resume" },
                values: new object[] { 1, "Abebe", "ab@gmail.com", "xxxxxxxxx" });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "ID", "Name", "email", "resume" },
                values: new object[] { 2, "Shimelis", "sh@gmail.com", "xxxxxxxxx" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "User");
        }
    }
}
