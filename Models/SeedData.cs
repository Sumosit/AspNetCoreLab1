using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using AspNetCore.Data;
using System;
using System.Linq;

namespace AspNetCore.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new AspNetCoreContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<AspNetCoreContext>>()))
            {
                // Look for any movies.
                if (context.Account.Any())
                {
                    return;   // DB has been seeded
                }

                context.Account.AddRange(
                    new Account
                    {
                        Name = "Ilia",
                        Pin = 1111,
                        Money = 21435
                    },
                    new Account
                    {
                        Name = "Roma",
                        Pin = 2222,
                        Money = 12312
                    },

                    new Account
                    {
                        Name = "Tris",
                        Pin = 1212,
                        Money = 36472
                    }
                );
                context.SaveChanges();
            }
        }
    }
}