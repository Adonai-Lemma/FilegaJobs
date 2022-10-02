using Microsoft.EntityFrameworkCore.Migrations;

namespace FilegaJobs.Migrations
{
    public partial class AlteredNewSeedTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "applicant",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    profileID = table.Column<int>(type: "int", nullable: false),
                    jobID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_applicant", x => x.ID);
                });

            migrationBuilder.InsertData(
                table: "Job",
                columns: new[] { "ID", "Description", "Name", "salary" },
                values: new object[] { 3, "xxxxxxx", "Manager", 10000 });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "ID", "Name", "email", "resume" },
                values: new object[,]
                {
                    { 3, "Abigia", "abg@gmail.com", "xxxxxxxxx" },
                    { 4, "Abel", "abe@gmail.com", "xxxxxxxxx" },
                    { 5, "Adonai", "ad@gmail.com", "xxxxxxxxx" }
                });

            migrationBuilder.InsertData(
                table: "applicant",
                columns: new[] { "ID", "jobID", "name", "profileID" },
                values: new object[,]
                {
                    { 101, 1, "Abigia", 3 },
                    { 102, 2, "Abel", 4 },
                    { 103, 3, "Adonai", 5 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "applicant");

            migrationBuilder.DeleteData(
                table: "Job",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "ID",
                keyValue: 5);
        }
    }
}
