using Microsoft.EntityFrameworkCore;
using WillStockBackend.Models;

namespace WillStockBackend.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options)
        {
        }

        public DbSet<ProductModel> Produto { get; set; }
    }
}
