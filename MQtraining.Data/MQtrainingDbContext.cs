using Microsoft.EntityFrameworkCore;
using MQtraining.Shared.Models;

namespace MQtraining.Data
{
    public class MQtrainingDbContext : DbContext
    {
        public MQtrainingDbContext(DbContextOptions<MQtrainingDbContext> options)
            : base(options)
        {

        }

        public DbSet<Order> Orders { get; set; }

        public DbSet<Item> Items { get; set; }

        public DbSet<LineItem> LineItems { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(MQtrainingDbContext).Assembly);

            base.OnModelCreating(modelBuilder);
        }
    }
}
