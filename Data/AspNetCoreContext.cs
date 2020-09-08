using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AspNetCore.Models;

namespace AspNetCore.Data
{
    public class AspNetCoreContext : DbContext
    {
        public AspNetCoreContext (DbContextOptions<AspNetCoreContext> options)
            : base(options)
        {
        }

        public DbSet<AspNetCore.Models.Account> Account { get; set; }
    }
}
