using PS.BearDiner.Domain.Common.Models;

namespace PS.BearDiner.Domain.Dinner.ValueObjects
{
    public sealed class ReservationId : ValueObject
    {
        public Guid Value { get; }

        private ReservationId(Guid value)
        {
            Value = value;
        }
        public static ReservationId Create(Guid value)
        {
            return new(value);
        }
        public static ReservationId CreateUnique()
        {
            return new(Guid.NewGuid());
        }
        public override IEnumerable<object> GetEqualityComponents()
        {
            yield return Value;
        }
    }
}
