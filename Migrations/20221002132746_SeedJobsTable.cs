using Microsoft.EntityFrameworkCore.Migrations;

namespace FilegaJobs.Migrations
{
    public partial class SeedJobsTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Job",
                columns: new[] { "ID", "Description", "Name", "salary" },
                values: new object[] { 1, "xxxxxxx", "Accountant", 1000 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Job",
                keyColumn: "ID",
                keyValue: 1);
        }
    }
}
