using PS.BearDiner.Domain.Common.Models;

namespace PS.BearDiner.Domain.Common.Valueobjects
{
    public sealed class Rating : ValueObject
    {
        public double Value { get; private set; }

        private Rating(double value)
        {
            Value = value;
        }

        public static Rating CreateNew(double value)
        {
            return new Rating(value);
        }

        public override IEnumerable<object> GetEqualityComponents()
        {
            yield return Value;
        }
    }
}