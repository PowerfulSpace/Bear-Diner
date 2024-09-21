using PS.BearDiner.Domain.Common.Models;

namespace PS.BearDiner.Domain.Common.Valueobjects
{
    public sealed class Rating : ValueObject
    {
        public int Value { get; private set; }

        private Rating(int value)
        {
            Value = value;
        }

        public static Rating CreateNew(int rating)
        {
            return new Rating(rating);
        }

        public override IEnumerable<object> GetEqualityComponents()
        {
            yield return Value;
        }
    }
}
