﻿using PS.BearDiner.Domain.Bill.ValueObjects;
using PS.BearDiner.Domain.Common.Models;
using PS.BearDiner.Domain.Dinner.ValueObjects;
using PS.BearDiner.Domain.Guest.ValueObjects;
using PS.BearDiner.Domain.Host.ValueObjects;

namespace PS.BearDiner.Domain.Bill
{
    public sealed class Bill : AggregateRoot<BillId, Guid>
    {
        public DinnerId DinnerId { get; }
        public GuestId GuestId { get; }
        public HostId HostId { get; }
        public Price Price { get; }
        public DateTime CreatedDateTime { get; }
        public DateTime UpdatedDateTime { get; }

        private Bill(BillId id, GuestId guestId, HostId hostId, Price price, DateTime createdDateTime, DateTime updatedDateTime) 
            : base(id)
        {
            GuestId = guestId;
            HostId = hostId;
            Price = price;
            CreatedDateTime = createdDateTime;
            UpdatedDateTime = updatedDateTime;
        }

        public static Bill Create(GuestId guestId, HostId hostId, Price price)
        {
            return new Bill(BillId.CreateUnique(), guestId, hostId, price, DateTime.UtcNow, DateTime.UtcNow);
        }

#pragma warning disable CS8618
        private Bill() { }
#pragma warning restore CS8618
    }
}
