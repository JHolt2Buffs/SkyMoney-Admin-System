using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SkyMoney_Admin_System.Migrations
{
    /// <inheritdoc />
    public partial class PayFrequencyDays : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PayFrequencyDays",
                table: "UserAccounts",
                type: "INTEGER",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PayFrequencyDays",
                table: "UserAccounts");
        }
    }
}
