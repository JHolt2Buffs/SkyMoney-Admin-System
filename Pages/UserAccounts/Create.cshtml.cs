using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SkyMoney_Admin_System.Models;

namespace SkyMoney_Admin_System.Pages_UserAccounts
{
    public class CreateModel : PageModel
    {
        private readonly AppDbContext _context;

        public CreateModel(AppDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public UserAccount UserAccount { get; set; } = default!;

        [BindProperty]
        public BudgetPlan BudgetPlan { get; set; } = new BudgetPlan();

        public IActionResult OnGet()
        {

            UserAccount = new UserAccount
            {
                CreatedAt = DateTime.Today,
                IncomeType = IncomeType.Irregular
            };

            BudgetPlan = new BudgetPlan
            {
                PlanName = "Default Budget Plan",
                TotalBudget = 0m,
                FundedExpenses = 0m
            };

            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            if (UserAccount.CreatedAt == default)
            {
                UserAccount.CreatedAt = DateTime.Today;
            }
            _context.UserAccounts.Add(UserAccount);
            await _context.SaveChangesAsync(); 

            BudgetPlan.UserAccountId = UserAccount.UserAccountId;
            _context.BudgetPlans.Add(BudgetPlan);

            await _context.SaveChangesAsync();

            return RedirectToPage("./Details", new { id = UserAccount.UserAccountId });
        }
    }
}
