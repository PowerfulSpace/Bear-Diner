using Microsoft.EntityFrameworkCore;
using PS.BearDiner.Domain.Bills;
using PS.BearDiner.Domain.Common.Models;
using PS.BearDiner.Domain.Dinners;
using PS.BearDiner.Domain.Guests;
using PS.BearDiner.Domain.Hosts;
using PS.BearDiner.Domain.MenuReviews;
using PS.BearDiner.Domain.Menus;
using PS.BearDiner.Domain.Users;
using PS.BearDiner.Infrastructure.Persistence.Interceptors;

namespace PS.BearDiner.Infrastructure.Persistence
{
    public class BearDinerDbContext : DbContext
    {
        private readonly PublishDomainEventsInterceptor _publishDomainEventsInterceptor;

        public BearDinerDbContext(DbContextOptions<BearDinerDbContext> options, PublishDomainEventsInterceptor publishDomainEventsInterceptor) 
            : base(options)
        {
            _publishDomainEventsInterceptor = publishDomainEventsInterceptor;
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
            modelBuilder
                .Ignore<List<IDomainEvent>>()
                .ApplyConfigurationsFromAssembly(typeof(BearDinerDbContext).Assembly);

            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.AddInterceptors(_publishDomainEventsInterceptor);
            base.OnConfiguring(optionsBuilder);
        }
    }
}