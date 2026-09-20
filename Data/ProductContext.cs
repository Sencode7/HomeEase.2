using Microsoft.EntityFrameworkCore;
using HomeEase.Models;
namespace HomeEase.Data
{
    public class ProductContext(DbContextOptions<ProductContext> options) : DbContext(options)
    {
        public DbSet<Product> Products => Set<Product>();
    }
  
}