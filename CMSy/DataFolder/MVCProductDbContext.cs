using CMSy.Models;
using Microsoft.EntityFrameworkCore;

namespace CMSy.DataFolder
{
    public class MVCProductDbContext : DbContext
    {
        public MVCProductDbContext(DbContextOptions<MVCOrderDbContext> options) : base(options)
        {

        }
        public DbSet<Product> Products { get; set; }
    }
}
