using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LGSTrackingSystem.Repositories.Migrations
{
    /// <inheritdoc />
    public partial class examNameAndScore : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ExamName",
                table: "Exams",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<decimal>(
                name: "Score",
                table: "Exams",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ExamName",
                table: "Exams");

            migrationBuilder.DropColumn(
                name: "Score",
                table: "Exams");
        }
    }
}
