using Microsoft.EntityFrameworkCore.Migrations;

namespace AuditBenchmarkModule.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AuditBenchmarkList",
                columns: table => new
                {
                    auditType = table.Column<string>(nullable: false),
                    benchmarkNoAnswers = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AuditBenchmarkList", x => x.auditType);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AuditBenchmarkList");
        }
    }
}
