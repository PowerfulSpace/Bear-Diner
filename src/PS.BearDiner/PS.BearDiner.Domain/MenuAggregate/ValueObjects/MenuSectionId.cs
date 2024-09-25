using PS.BearDiner.Domain.Common.Models;

namespace PS.BearDiner.Domain.MenuAggregate.ValueObjects
{
    public sealed class MenuSectionId : ValueObject
    {
        public Guid Value { get; }

        private MenuSectionId(Guid value)
        {
            Value = value;
        }
        public static MenuSectionId Create(Guid value)
        {
            return new(value);
        }

        public static MenuSectionId CreateUnique()
        {
            return new MenuSectionId(Guid.NewGuid());
        }

        public override IEnumerable<object> GetEqualityComponents()
        {
            yield return Value;
        }

        private MenuSectionId() { }
    }
}
