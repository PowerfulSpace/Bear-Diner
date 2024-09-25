using PS.BearDiner.Domain.Common.Models;

namespace PS.BearDiner.Domain.Menus.ValueObjects
{
    public sealed class MenuId : AggregateRootId<Guid>
    {
        public override Guid Value { get; protected set; }

        private MenuId(Guid value)
        {
            Value = value;
        }

        public static MenuId Create(Guid value)
        {
            return new(value);
        }

        public static MenuId CreateUnique()
        {
            return new MenuId(Guid.NewGuid());
        }

        public override IEnumerable<object> GetEqualityComponents()
        {
            yield return Value;
        }

        private MenuId() { }
    }
}
