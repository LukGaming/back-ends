using AuthApi.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace AuthApi.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) {
        
        }

        public DbSet<User> users { get; set; }
    }
}
