using Microsoft.EntityFrameworkCore;
using SistemaMVCOracle.Models;

namespace SistemaMVCOracle.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) 
            : base(options)
        {
        }
        public DbSet<Producto> Produtos { get; set; }
    }
}   
