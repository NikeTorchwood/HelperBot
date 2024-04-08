using Microsoft.EntityFrameworkCore;

namespace CatalogService
{
    public class CatalogDbContext: DbContext
    {
        public CatalogDbContext(DbContextOptions<CatalogDbContext> options): base(options)
        {
            
        }
        public DbSet<Item> Items { get; set; }
    }
}
