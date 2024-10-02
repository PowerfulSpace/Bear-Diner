using Microsoft.EntityFrameworkCore;
using PS.BearDiner.Domain.Menus;

namespace PS.BearDiner.Infrastructure.Persistence
{
    public class BearDinerDbContext : DbContext
    {
        public BearDinerDbContext(DbContextOptions<BearDinerDbContext> options) : base(options)
        {
        }

        public DbSet<Menu> Menus { get; set; } = null!;


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(BearDinerDbContext).Assembly);

            base.OnModelCreating(modelBuilder);
        }
    }
}