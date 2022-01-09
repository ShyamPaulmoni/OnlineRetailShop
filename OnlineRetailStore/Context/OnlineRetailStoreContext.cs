using Microsoft.EntityFrameworkCore;
using OnlineRetailStore.Models;

namespace OnlineRetailStore.Context
{
    public class OnlineRetailStoreContext : DbContext
    {
        public OnlineRetailStoreContext(DbContextOptions dbContextOptions) : base(dbContextOptions)
        {

        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
    }
}
