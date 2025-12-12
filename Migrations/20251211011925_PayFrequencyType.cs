using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SkyMoney_Admin_System.Migrations
{
    /// <inheritdoc />
    public partial class PayFrequencyType : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PayFrequencyDays",
                table: "UserAccounts");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PayFrequencyDays",
                table: "UserAccounts",
                type: "INTEGER",
                nullable: true);
        }
    }
}
