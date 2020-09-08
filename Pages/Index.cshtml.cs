using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using AspNetCore.Data;
using AspNetCore.Models;

namespace AspNetCore.Pages
{
    public class IndexModel : PageModel
    {
        private readonly AspNetCore.Data.AspNetCoreContext _context;

        public IndexModel(AspNetCore.Data.AspNetCoreContext context)
        {
            _context = context;
        }

        public IList<Account> Account { get;set; }

        public async Task OnGetAsync()
        {
            Account = await _context.Account.ToListAsync();
        }
    }
}
