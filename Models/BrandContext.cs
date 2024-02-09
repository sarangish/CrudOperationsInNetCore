using Microsoft.EntityFrameworkCore;

namespace CrudOperationsInNetCore.Models
{
    public class BrandContext : DbContext
    {
        public BrandContext(DbContextOptions<BrandContext> contextOptions) : base(contextOptions)
        {
        }

        public DbSet<Brand> Brands { get; set; }
    }
}
