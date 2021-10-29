using Microsoft.EntityFrameworkCore;

namespace GreenCellUpsControl.EntityFramework.Models
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options) { }
        public ApplicationContext() { }

        public DbSet<DataEntry> DataEntries { get; set; }
    }
}