using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SkyMoney_Admin_System.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "UserAccounts",
                columns: table => new
                {
                    UserAccountId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    EmailAddress = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    FirstName = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "TEXT", nullable: false),
                    IncomeType = table.Column<int>(type: "INTEGER", nullable: false),
                    NextScheduledPayDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    PayFrequencyDays = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserAccounts", x => x.UserAccountId);
                });

            migrationBuilder.CreateTable(
                name: "BudgetPlans",
                columns: table => new
                {
                    BudgetPlanId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UserAccountId = table.Column<int>(type: "INTEGER", nullable: false),
                    PlanName = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    TotalBudget = table.Column<decimal>(type: "TEXT", nullable: false),
                    FundedExpenses = table.Column<decimal>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BudgetPlans", x => x.BudgetPlanId);
                    table.ForeignKey(
                        name: "FK_BudgetPlans_UserAccounts_UserAccountId",
                        column: x => x.UserAccountId,
                        principalTable: "UserAccounts",
                        principalColumn: "UserAccountId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "IncomeRecords",
                columns: table => new
                {
                    IncomeRecordId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UserAccountId = table.Column<int>(type: "INTEGER", nullable: false),
                    Amount = table.Column<decimal>(type: "TEXT", nullable: false),
                    DateReceived = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Notes = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IncomeRecords", x => x.IncomeRecordId);
                    table.ForeignKey(
                        name: "FK_IncomeRecords_UserAccounts_UserAccountId",
                        column: x => x.UserAccountId,
                        principalTable: "UserAccounts",
                        principalColumn: "UserAccountId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TransactionRecords",
                columns: table => new
                {
                    TransactionRecordId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UserAccountId = table.Column<int>(type: "INTEGER", nullable: false),
                    TransactionDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Amount = table.Column<decimal>(type: "TEXT", nullable: false),
                    Category = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "TEXT", maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TransactionRecords", x => x.TransactionRecordId);
                    table.ForeignKey(
                        name: "FK_TransactionRecords_UserAccounts_UserAccountId",
                        column: x => x.UserAccountId,
                        principalTable: "UserAccounts",
                        principalColumn: "UserAccountId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FixedExpenses",
                columns: table => new
                {
                    FixedExpenseId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    BudgetPlanId = table.Column<int>(type: "INTEGER", nullable: false),
                    Name = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    Amount = table.Column<decimal>(type: "TEXT", nullable: false),
                    FundedAmount = table.Column<decimal>(type: "TEXT", nullable: false),
                    DueDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    IsFinanced = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FixedExpenses", x => x.FixedExpenseId);
                    table.ForeignKey(
                        name: "FK_FixedExpenses_BudgetPlans_BudgetPlanId",
                        column: x => x.BudgetPlanId,
                        principalTable: "BudgetPlans",
                        principalColumn: "BudgetPlanId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "VariableExpenses",
                columns: table => new
                {
                    VariableExpenseId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    BudgetPlanId = table.Column<int>(type: "INTEGER", nullable: false),
                    CategoryName = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    PercentOfAvailableBudget = table.Column<decimal>(type: "TEXT", nullable: false),
                    CategoryBalance = table.Column<decimal>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VariableExpenses", x => x.VariableExpenseId);
                    table.ForeignKey(
                        name: "FK_VariableExpenses_BudgetPlans_BudgetPlanId",
                        column: x => x.BudgetPlanId,
                        principalTable: "BudgetPlans",
                        principalColumn: "BudgetPlanId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BudgetPlans_UserAccountId",
                table: "BudgetPlans",
                column: "UserAccountId");

            migrationBuilder.CreateIndex(
                name: "IX_FixedExpenses_BudgetPlanId",
                table: "FixedExpenses",
                column: "BudgetPlanId");

            migrationBuilder.CreateIndex(
                name: "IX_IncomeRecords_UserAccountId",
                table: "IncomeRecords",
                column: "UserAccountId");

            migrationBuilder.CreateIndex(
                name: "IX_TransactionRecords_UserAccountId",
                table: "TransactionRecords",
                column: "UserAccountId");

            migrationBuilder.CreateIndex(
                name: "IX_VariableExpenses_BudgetPlanId",
                table: "VariableExpenses",
                column: "BudgetPlanId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FixedExpenses");

            migrationBuilder.DropTable(
                name: "IncomeRecords");

            migrationBuilder.DropTable(
                name: "TransactionRecords");

            migrationBuilder.DropTable(
                name: "VariableExpenses");

            migrationBuilder.DropTable(
                name: "BudgetPlans");

            migrationBuilder.DropTable(
                name: "UserAccounts");
        }
    }
}
