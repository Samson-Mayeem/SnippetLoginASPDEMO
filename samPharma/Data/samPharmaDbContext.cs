
using Microsoft.EntityFrameworkCore;
using samPharma.Models;


namespace samPharma.Data
{
    public class samPharmaDbContext : DbContext
    {
        public samPharmaDbContext(DbContextOptions options): base(options)
        {

        }
        public DbSet<Customer> customer { get; set; }
        public DbSet<ExpiryDate> expirydate { get; set; }
        public DbSet<Order> order { get; set; }
        public DbSet<Product> product { get; set; }
        public DbSet<Stock> stock { get; set; }
        public DbSet<Supplier> supplier { get; set; }
        public DbSet<User> user { get; set; }

    }
}