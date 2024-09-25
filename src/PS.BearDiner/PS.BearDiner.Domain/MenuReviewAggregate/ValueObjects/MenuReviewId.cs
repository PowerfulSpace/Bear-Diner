using PS.BearDiner.Domain.Common.Models;

namespace PS.BearDiner.Domain.MenuReviewAggregate.ValueObjects
{
    public sealed class MenuReviewId : AggregateRootId<Guid>
    {
        public override Guid Value { get; protected set; }

        private MenuReviewId(Guid id)
        {
            Value = id;
        }
        public static MenuReviewId Create(Guid value)
        {
            return new(value);
        }
        public static MenuReviewId CreateUnique()
        {
            return new MenuReviewId(Guid.NewGuid());
        }

        public override IEnumerable<object> GetEqualityComponents()
        {
            yield return Value;
        }

        private MenuReviewId() { }
    }
}
