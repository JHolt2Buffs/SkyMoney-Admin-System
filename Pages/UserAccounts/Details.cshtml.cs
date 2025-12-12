using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SkyMoney_Admin_System.Models;

namespace SkyMoney_Admin_System.Pages_UserAccounts
{
    public class DetailsModel : PageModel
    {
        private readonly SkyMoney_Admin_System.Models.AppDbContext _context;

        public DetailsModel(SkyMoney_Admin_System.Models.AppDbContext context)
        {
            _context = context;
        }

        public UserAccount UserAccount { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var user = await _context.UserAccounts
              .Include(u => u.BudgetPlans)
                  .ThenInclude(bp => bp.FixedExpenses)
              .Include(u => u.BudgetPlans)
                  .ThenInclude(bp => bp.VariableExpenses)
              .Include(u => u.IncomeRecords)
              .Include(u => u.TransactionRecords)
              .AsNoTracking()
              .FirstOrDefaultAsync(u => u.UserAccountId == id);

            if (user == null)
            {
                return NotFound();
            }

            UserAccount = user;
            return Page();
        }
    }
}
