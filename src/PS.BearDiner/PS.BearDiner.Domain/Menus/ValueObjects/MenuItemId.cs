﻿using PS.BearDiner.Domain.Common.Models;

namespace PS.BearDiner.Domain.Menus.ValueObjects
{
    public sealed class MenuItemId : ValueObject
    {
        public Guid Value { get; }

        private MenuItemId(Guid value)
        {
            Value = value;
        }

        public static MenuItemId Create(Guid value)
        {
            return new(value);
        }

        public static MenuItemId CreateUnique()
        {
            return new MenuItemId(Guid.NewGuid());
        }

        public override IEnumerable<object> GetEqualityComponents()
        {
            yield return Value;
        }

        private MenuItemId() { }
    }
}
