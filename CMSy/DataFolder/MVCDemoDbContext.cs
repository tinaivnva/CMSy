using CMSy.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace CMSy.DataFolder
{
    public class MVCDemoDbContext : DbContext
    {
        public MVCDemoDbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Receipts> Receipt { get; set; }
    }
}
