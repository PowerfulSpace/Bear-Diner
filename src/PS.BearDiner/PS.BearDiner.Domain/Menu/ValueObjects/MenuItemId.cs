using PS.BearDiner.Domain.Common.Models;

namespace PS.BearDiner.Domain.Menu.ValueObjects
{
    public sealed class MenuItemId : ValueObject
    {
        public Guid Value { get; }

        private MenuItemId(Guid id)
        {
            Value = id;
        }

        public static MenuItemId CreateUnique()
        {
            return new MenuItemId(Guid.NewGuid());
        }

        public override IEnumerable<object> GetEqualityComponents()
        {
            yield return Value;
        }
    }
}
