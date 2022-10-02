using Microsoft.EntityFrameworkCore.Migrations;

namespace FilegaJobs.Migrations
{
    public partial class AlterSeedJobsTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Job",
                columns: new[] { "ID", "Description", "Name", "salary" },
                values: new object[] { 2, "xxxxxxx", "Sectretary", 100 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Job",
                keyColumn: "ID",
                keyValue: 2);
        }
    }
}
