using Microsoft.EntityFrameworkCore;
using SimpleLogin.Models;

namespace SimpleLogin.Data
{
    public class UserDbContext : DbContext
    {
        public UserDbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Users> Users { get; set; }
    }
}
