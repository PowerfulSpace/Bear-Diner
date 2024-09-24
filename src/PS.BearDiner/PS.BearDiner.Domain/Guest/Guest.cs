using PS.BearDiner.Domain.Common.Models;
using PS.BearDiner.Domain.Guest.ValueObjects;

namespace PS.BearDiner.Domain.Guest
{
    public sealed class Guest : AggregateRoot<GuestId, Guid>
    {
        public Guest(GuestId id) : base(id)
        {
            
        }

#pragma warning disable CS8618
        private Guest() { }
#pragma warning restore CS8618
    }
}
