using PS.BearDiner.Domain.Common.Models;

namespace PS.BearDiner.Domain.MenuReview.ValueObjects
{
    public sealed class MenuReviewId : ValueObject
    {
        public Guid Value { get; }

        private MenuReviewId(Guid id)
        {
            Value = id;
        }

        public static MenuReviewId CreateUnique()
        {
            return new MenuReviewId(Guid.NewGuid());
        }

        public override IEnumerable<object> GetEqualityComponents()
        {
            yield return Value;
        }
    }
}
