using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SkyMoney_Admin_System.Migrations
{
    /// <inheritdoc />
    public partial class PayFrequencyEnum : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PayFrequencyDays",
                table: "UserAccounts",
                newName: "PayFrequency");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PayFrequency",
                table: "UserAccounts",
                newName: "PayFrequencyDays");
        }
    }
}
