using Microsoft.EntityFrameworkCore;

namespace SkyMoney_Admin_System.Models;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
     : base(options)
    {

    }

    public DbSet<UserAccount> UserAccounts { get; set; } = default!;
    public DbSet<BudgetPlan> BudgetPlans { get; set; } = default!;
    public DbSet<FixedExpense> FixedExpenses  { get; set; } = default!;
    public DbSet<VariableExpense> VariableExpenses  { get; set; } = default!;
    public DbSet<IncomeRecord> IncomeRecords   { get; set; } = default!;
    public DbSet<TransactionRecord> TransactionRecords  { get; set; } = default!;

 }