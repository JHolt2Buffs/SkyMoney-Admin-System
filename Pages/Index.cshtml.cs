using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SkyMoney_Admin_System.Models;

namespace SkyMoney_Admin_System.Pages
{
    public class IndexModel : PageModel
    {
        private readonly AppDbContext _context;

        public IndexModel(AppDbContext context)
        {
            _context = context;
        }

        public int TotalUsers { get; set; }
        public int RegularUsers { get; set; }
        public int IrregularUsers { get; set; }

        public decimal TotalBudget { get; set; }
        public decimal TotalAvailableBudget { get; set; }

        public UserAccount[] RecentUsers { get; set; } = Array.Empty<UserAccount>();

        public async Task OnGetAsync()
        {
            TotalUsers = await _context.UserAccounts.CountAsync();
            RegularUsers = await _context.UserAccounts
                .CountAsync(u => u.IncomeType == IncomeType.Regular);
            IrregularUsers = await _context.UserAccounts
                .CountAsync(u => u.IncomeType == IncomeType.Irregular);

            TotalBudget = await _context.BudgetPlans
                .SumAsync(bp => bp.TotalBudget);

            TotalAvailableBudget = await _context.BudgetPlans
                .SumAsync(bp => bp.TotalBudget - bp.FundedExpenses);

            RecentUsers = await _context.UserAccounts
                .OrderByDescending(u => u.CreatedAt)
                .Take(5)
                .ToArrayAsync();
        }
    }
}
