using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PS.BearDiner.Domain.GuestAggregate.ValueObjects;
using PS.BearDiner.Domain.Guests;

namespace PS.BearDiner.Infrastructure.Persistence.Configurations
{
    public sealed class GuestConfigurations : IEntityTypeConfiguration<Guest>
    {
        public void Configure(EntityTypeBuilder<Guest> builder)
        {
            ConfigureGuestsTable(builder);
        }

        private void ConfigureGuestsTable(EntityTypeBuilder<Guest> builder)
        {
            builder
                .ToTable("Guests");

            builder
                .HasKey(g => g.Id);

            builder
                .Property(g => g.Id)
                .ValueGeneratedNever()
                .HasConversion(
                    id => id.Value,
                    value => GuestId.Create(value));
        }
    }
}
