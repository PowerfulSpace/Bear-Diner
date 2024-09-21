using PS.BearDiner.Domain.Common.Models;

namespace PS.BearDiner.Domain.Dinner.ValueObjects
{
    public sealed class DinnerId : ValueObject
    {
        public Guid Value { get; }

        private DinnerId(Guid id)
        {
            Value = id;
        }

        public static DinnerId CreateUnique()
        {
            return new DinnerId(Guid.NewGuid());
        }

        public override IEnumerable<object> GetEqualityComponents()
        {
            yield return Value;
        }
    }
}
