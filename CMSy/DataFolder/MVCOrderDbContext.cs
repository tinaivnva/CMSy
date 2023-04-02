using CMSy.Models;
using Microsoft.EntityFrameworkCore;

namespace CMSy.DataFolder
{
    public class MVCOrderDbContext : DbContext
    {
        public MVCOrderDbContext(DbContextOptions<MVCOrderDbContext> options) : base(options)
        {

        }
        public DbSet<Order> Order { get; set; }
    }
}
