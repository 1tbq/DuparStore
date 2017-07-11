using DuperStore.Models;
using Microsoft.EntityFrameworkCore;
namespace DuperStore.Models
{
    public class ApplicationDbContext : DbContext {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) { }
        public DbSet<Product> Products { get; set; }
    }
}