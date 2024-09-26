using PS.BearDiner.Domain.Bills.ValueObjects;
using PS.BearDiner.Domain.Common.Models;
using PS.BearDiner.Domain.Dinners.ValueObjects;
using PS.BearDiner.Domain.GuestAggregate.ValueObjects;
using PS.BearDiner.Domain.Hosts.ValueObjects;

namespace PS.BearDiner.Domain.Bills
{
    public sealed class Bill : AggregateRoot<BillId, Guid>
    {
        public DinnerId DinnerId { get; }
        public GuestId GuestId { get; }
        public HostId HostId { get; }
        public Price Price { get; }
        public DateTime CreatedDateTime { get; }
        public DateTime UpdatedDateTime { get; }

        private Bill(BillId id, DinnerId dinnerId, GuestId guestId, HostId hostId, Price price, DateTime createdDateTime, DateTime updatedDateTime) 
            : base(id)
        {
            DinnerId = dinnerId;
            GuestId = guestId;
            HostId = hostId;
            Price = price;
            CreatedDateTime = createdDateTime;
            UpdatedDateTime = updatedDateTime;
        }

        public static Bill Create(GuestId guestId, DinnerId dinnerId, HostId hostId, Price price)
        {
            return new Bill(BillId.CreateUnique(), dinnerId, guestId, hostId, price, DateTime.UtcNow, DateTime.UtcNow);
        }

#pragma warning disable CS8618
        private Bill() { }
#pragma warning restore CS8618
    }
}
