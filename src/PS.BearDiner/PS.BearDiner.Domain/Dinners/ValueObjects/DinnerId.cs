using PS.BearDiner.Domain.Common.Models;

namespace PS.BearDiner.Domain.Dinners.ValueObjects
{
    public sealed class DinnerId : AggregateRootId<Guid>
    {
        public override Guid Value { get; protected set; }

        private DinnerId(Guid id)
        {
            Value = id;
        }

        public static DinnerId Create(Guid value)
        {
            return new(value);
        }

        public static DinnerId CreateUnique()
        {
            return new DinnerId(Guid.NewGuid());
        }

        public override IEnumerable<object> GetEqualityComponents()
        {
            yield return Value;
        }

        private DinnerId() { }
    }
}
