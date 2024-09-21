using PS.BearDiner.Domain.Common.Models;

namespace PS.BearDiner.Domain.Host.ValueObjects
{
    public sealed class HostId : ValueObject
    {
        public Guid Value { get; }

        private HostId(Guid id)
        {
            Value = id;
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
