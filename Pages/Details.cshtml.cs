﻿using System;
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
    public class DetailsModel : PageModel
    {
        private readonly AspNetCore.Data.AspNetCoreContext _context;

        public DetailsModel(AspNetCore.Data.AspNetCoreContext context)
        {
            _context = context;
        }

        public Account Account { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Account = await _context.Account.FirstOrDefaultAsync(m => m.ID == id);

            if (Account == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
