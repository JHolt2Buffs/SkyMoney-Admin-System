using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SkyMoney_Admin_System.Models;

namespace SkyMoney_Admin_System.Pages_UserAccounts
{
    public class EditModel : PageModel
    {
        private readonly SkyMoney_Admin_System.Models.AppDbContext _context;

        public EditModel(SkyMoney_Admin_System.Models.AppDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public UserAccount UserAccount { get; set; } = default!;

        [BindProperty]
        public BudgetPlan BudgetPlan { get; set; } = default!;

        [BindProperty]
        public List<FixedExpense> FixedExpenses { get; set; } = new();

        [BindProperty]
        public List<VariableExpense> VariableExpenses { get; set; } = new();

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var useraccount = await _context.UserAccounts
                .Include(u => u.BudgetPlans)
                    .ThenInclude(bp => bp.FixedExpenses)
                .Include(u => u.BudgetPlans)
                    .ThenInclude(bp => bp.VariableExpenses)
                .FirstOrDefaultAsync(m => m.UserAccountId == id);

            if (useraccount == null)
            {
                return NotFound();
            }

            UserAccount = useraccount;
            var existingPlan = useraccount.BudgetPlans.FirstOrDefault();

            if (existingPlan != null)
            {

                BudgetPlan = existingPlan;
                FixedExpenses = existingPlan.FixedExpenses
                    .OrderBy(f => f.DueDate)
                    .ToList();
                VariableExpenses = existingPlan.VariableExpenses
                    .OrderBy(v => v.CategoryName)
                    .ToList();
            }
            else
            {

                BudgetPlan = new BudgetPlan
                {
                    UserAccountId = useraccount.UserAccountId
                };
                FixedExpenses = new List<FixedExpense>();
                VariableExpenses = new List<VariableExpense>();
            }
            return Page();
        }


        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {

            Console.WriteLine("DEBUG: Entered OnPostAsync for Edit.");

            if (!ModelState.IsValid)
            {
                Console.WriteLine("DEBUG: ModelState invalid.");
                  foreach (var kvp in ModelState)
                {
                    foreach (var error in kvp.Value.Errors)
                    {
                        Console.WriteLine($"DEBUG ModelState error on '{kvp.Key}': {error.ErrorMessage}");
                    }
                }

                var reload = await _context.UserAccounts
                    .Include(u => u.BudgetPlans)
                        .ThenInclude(bp => bp.FixedExpenses)
                    .Include(u => u.BudgetPlans)
                        .ThenInclude(bp => bp.VariableExpenses)
                    .FirstOrDefaultAsync(m => m.UserAccountId == UserAccount.UserAccountId);

                if (reload != null)
                {
                    UserAccount = reload;
                    var existingPlan = reload.BudgetPlans.FirstOrDefault();
                    if (existingPlan != null)
                    {
                        BudgetPlan = existingPlan;
                        FixedExpenses = existingPlan.FixedExpenses
                            .OrderBy(f => f.DueDate).ToList();
                        VariableExpenses = existingPlan.VariableExpenses
                            .OrderBy(v => v.CategoryName).ToList();
                    }
                }

                return Page();
            }

            var userFromDb = await _context.UserAccounts
                .Include(u => u.BudgetPlans)
                    .ThenInclude(bp => bp.FixedExpenses)
                .Include(u => u.BudgetPlans)
                    .ThenInclude(bp => bp.VariableExpenses)
                .FirstOrDefaultAsync(u => u.UserAccountId == UserAccount.UserAccountId);

            if (userFromDb == null)
            {
                return NotFound();
            }

            userFromDb.EmailAddress = UserAccount.EmailAddress;
            userFromDb.FirstName = UserAccount.FirstName;
            userFromDb.LastName = UserAccount.LastName;
            userFromDb.IncomeType = UserAccount.IncomeType;
            userFromDb.NextScheduledPayDate = UserAccount.NextScheduledPayDate;
            userFromDb.PayFrequency = UserAccount.PayFrequency;

            var planFromDb = userFromDb.BudgetPlans.FirstOrDefault();
            if (planFromDb != null)
            {
                planFromDb.PlanName = BudgetPlan.PlanName;
                planFromDb.TotalBudget = BudgetPlan.TotalBudget;
                planFromDb.FundedExpenses = BudgetPlan.FundedExpenses;

                if (FixedExpenses != null && FixedExpenses.Count > 0)
                {
                    foreach (var fxModel in FixedExpenses)
                    {
                        var fxDb = planFromDb.FixedExpenses
                            .FirstOrDefault(f => f.FixedExpenseId == fxModel.FixedExpenseId);

                        if (fxDb != null)
                        {
                            fxDb.Name = fxModel.Name;
                            fxDb.Amount = fxModel.Amount;
                            fxDb.FundedAmount = fxModel.FundedAmount;
                            fxDb.DueDate = fxModel.DueDate;
                            fxDb.IsFinanced = fxModel.IsFinanced;
                        }
                    }
                }

                if (VariableExpenses != null && VariableExpenses.Count > 0)
                {
                    foreach (var vxModel in VariableExpenses)
                    {
                        var vxDb = planFromDb.VariableExpenses
                            .FirstOrDefault(v => v.VariableExpenseId == vxModel.VariableExpenseId);

                        if (vxDb != null)
                        {
                            vxDb.CategoryName = vxModel.CategoryName;
                            vxDb.PercentOfAvailableBudget = vxModel.PercentOfAvailableBudget;
                            vxDb.CategoryBalance = vxModel.CategoryBalance;
                        }
                    }
                }
            }
            else
            {
                planFromDb = new BudgetPlan
                {
                    UserAccountId = userFromDb.UserAccountId,
                    PlanName = BudgetPlan.PlanName,
                    TotalBudget = BudgetPlan.TotalBudget,
                    FundedExpenses = BudgetPlan.FundedExpenses
                };
                userFromDb.BudgetPlans.Add(planFromDb);
            }

            var rows = await _context.SaveChangesAsync();
            Console.WriteLine($"DEBUG: SaveChangesAsync affected {rows} rows.");

            return RedirectToPage("./Details", new { id = userFromDb.UserAccountId });
        }

        private bool UserAccountExists(int id)
        {
            return _context.UserAccounts.Any(e => e.UserAccountId == id);
        }
    }
}
