using PS.BearDiner.Domain.Common.Models;

namespace PS.BearDiner.Domain.Menu.ValueObjects
{
    public sealed class MenuId : ValueObject
    {
        public Guid Value { get; }

        private MenuId(Guid id)
        {
            Value = id;
        }

        public static MenuId CreateUnique()
        {
            return new MenuId(Guid.NewGuid());
        }

        public override IEnumerable<object> GetEqualityComponents()
        {
            yield return Value;
        }
    }
}
