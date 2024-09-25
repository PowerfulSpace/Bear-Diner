using PS.BearDiner.Domain.Common.Models;

namespace PS.BearDiner.Domain.Hosts.ValueObjects
{
    public sealed class HostId : AggregateRootId<Guid>
    {
        public override Guid Value { get; protected set; }

        private HostId(Guid id)
        {
            Value = id;
        }
        public static HostId Create(Guid value)
        {
            return new HostId(value);
        }
        public static HostId CreateUnique()
        {
            return new HostId(Guid.NewGuid());
        }

        public override IEnumerable<object> GetEqualityComponents()
        {
            yield return Value;
        }
    }
}
