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
    public class IndexModel : PageModel
    {
        private readonly SkyMoney_Admin_System.Models.AppDbContext _context;

        public IndexModel(SkyMoney_Admin_System.Models.AppDbContext context)
        {
            _context = context;
        }

        public IList<UserAccount> UserAccount { get; set; } = default!;

        [BindProperty(SupportsGet = true)]
        public int PageNum { get; set; } = 1;

        public int PageSize { get; set; } = 10;

        public int TotalPages { get; set; }

        public async Task OnGetAsync()
        {
            var TotalUsers = await _context.UserAccounts.CountAsync();
            TotalPages = (int)Math.Ceiling(_context.UserAccounts.Count() / (double)PageSize);

            if (PageNum < 1)
            {
                PageNum = 1;
            }
            if (TotalPages > 0 && PageNum > TotalPages )
            {
                PageNum = TotalPages;
            }
            UserAccount = await _context.UserAccounts
                .OrderBy(u => u.LastName)
                .ThenBy(u => u.FirstName)
                .Skip((PageNum - 1) * PageSize)
                .Take(PageSize)
                .ToListAsync();
       }
    }
}
