using CQRS.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace CQRS.Data.context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Item> Items { get; set; }
    }
}
