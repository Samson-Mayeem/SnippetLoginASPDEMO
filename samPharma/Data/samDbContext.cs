using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EntityFrameWorkCore;
using Pomelo.Microsoft.EntityFrameWorkCore;
using samPharma.Data;


namespace samPharma.Data
{
    public class samDbContext
    {
        public samDbContext(DbContextOptions options): base(options)
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