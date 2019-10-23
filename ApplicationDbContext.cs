using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Candy3.Data;

namespace Candy3.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Candy3.Data.Candy> Candy { get; set; }
        public DbSet<Candy3.Data.CandyStores> CandyStores { get; set; }
        public DbSet<Candy3.Data.Orderscs> Orderscs { get; set; }
    }
}
