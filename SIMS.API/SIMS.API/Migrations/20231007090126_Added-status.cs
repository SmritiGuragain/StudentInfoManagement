using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SIMS.API.Migrations
{
    /// <inheritdoc />
    public partial class Addedstatus : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Status",
                table: "Faculties",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Status",
                table: "Departments",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Status",
                table: "Faculties");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "Departments");
        }
    }
}
