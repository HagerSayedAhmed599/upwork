using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApiProject.Migrations
{
    /// <inheritdoc />
    public partial class init23 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Client",
                table: "profile");

            migrationBuilder.DropColumn(
                name: "Freelancer",
                table: "profile");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Client",
                table: "profile",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Freelancer",
                table: "profile",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }
    }
}
