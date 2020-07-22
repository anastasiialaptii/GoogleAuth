using AuthTest.Models;
using Microsoft.EntityFrameworkCore;

namespace AuthTest.AppDbContext
{
    public class AuthDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        public AuthDbContext(DbContextOptions<AuthDbContext> options) : base(options)
        {
        }
    }
}
