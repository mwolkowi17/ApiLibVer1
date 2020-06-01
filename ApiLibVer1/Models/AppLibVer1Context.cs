using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiLibVer1.Models
{
    public class AppLibVer1Context:DbContext
    {
        public AppLibVer1Context(DbContextOptions<AppLibVer1Context> options)
            : base(options)
        {
        }
        public DbSet<User>Users { get; set; }
        public DbSet<Item>Items { get; set; }
        public DbSet<Checkout>Checkouts { get; set; }
    }
}
