using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LGSTrackingSystem.Repositories.Migrations
{
    /// <inheritdoc />
    public partial class totalnetTypeFix : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "EnglishEmpty",
                table: "Exams",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "HistoryEmpty",
                table: "Exams",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "MathEmpty",
                table: "Exams",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ReligionEmpty",
                table: "Exams",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ScienceEmpty",
                table: "Exams",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<decimal>(
                name: "TotalNet",
                table: "Exams",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<int>(
                name: "TurkishEmpty",
                table: "Exams",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EnglishEmpty",
                table: "Exams");

            migrationBuilder.DropColumn(
                name: "HistoryEmpty",
                table: "Exams");

            migrationBuilder.DropColumn(
                name: "MathEmpty",
                table: "Exams");

            migrationBuilder.DropColumn(
                name: "ReligionEmpty",
                table: "Exams");

            migrationBuilder.DropColumn(
                name: "ScienceEmpty",
                table: "Exams");

            migrationBuilder.DropColumn(
                name: "TotalNet",
                table: "Exams");

            migrationBuilder.DropColumn(
                name: "TurkishEmpty",
                table: "Exams");
        }
    }
}
