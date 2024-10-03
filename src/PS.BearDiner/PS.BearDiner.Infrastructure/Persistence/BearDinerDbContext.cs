using Microsoft.EntityFrameworkCore;
using PS.BearDiner.Domain.Bills;
using PS.BearDiner.Domain.Dinners;
using PS.BearDiner.Domain.Guests;
using PS.BearDiner.Domain.Hosts;
using PS.BearDiner.Domain.MenuReviews;
using PS.BearDiner.Domain.Menus;
using PS.BearDiner.Domain.Users;

namespace PS.BearDiner.Infrastructure.Persistence
{
    public class BearDinerDbContext : DbContext
    {
        public BearDinerDbContext(DbContextOptions<BearDinerDbContext> options) : base(options)
        {
        }

        public DbSet<Bill> Bills { get; set; } = null!;
        public DbSet<Dinner> Dinners { get; set; } = null!;
        public DbSet<Guest> Guests { get; set; } = null!;
        public DbSet<Host> Hosts { get; set; } = null!;
        public DbSet<Menu> Menus { get; set; } = null!;
        public DbSet<MenuReview> MenuReviews { get; set; } = null!;
        public DbSet<User> Users { get; set; } = null!;


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(BearDinerDbContext).Assembly);

            base.OnModelCreating(modelBuilder);
        }
    }
}