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
    public class DeleteModel : PageModel
    {
        private readonly SkyMoney_Admin_System.Models.AppDbContext _context;

        public DeleteModel(SkyMoney_Admin_System.Models.AppDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public UserAccount UserAccount { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var useraccount = await _context.UserAccounts.FirstOrDefaultAsync(m => m.UserAccountId == id);

            if (useraccount == null)
            {
                return NotFound();
            }
            else
            {
                UserAccount = useraccount;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var useraccount = await _context.UserAccounts.FindAsync(id);
            if (useraccount != null)
            {
                UserAccount = useraccount;
                _context.UserAccounts.Remove(UserAccount);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
