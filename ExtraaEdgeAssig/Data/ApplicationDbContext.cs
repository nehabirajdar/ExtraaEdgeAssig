using ExtraaEdgeAssig.Models;
using Microsoft.EntityFrameworkCore;

namespace ExtraaEdgeAssig.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
        public DbSet<Brand> Brands { get; set; }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Mobile> Mobiles { get; set; }

        public DbSet<Purchase>Purchases { get; set; }


    }
}
