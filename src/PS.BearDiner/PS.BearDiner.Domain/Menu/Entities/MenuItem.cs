﻿using PS.BearDiner.Domain.Common.Models;
using PS.BearDiner.Domain.Dinner.ValueObjects;
using PS.BearDiner.Domain.Menu.ValueObjects;

namespace PS.BearDiner.Domain.Menu.Entities
{
    public sealed class MenuItem : Entity<MenuItemId>
    {
        public string Name { get;}
        public string Description { get;}

        private MenuItem(MenuItemId menuItemId, string name, string description) 
            : base(menuItemId)
        {
            Name = name;
            Description = description;
        }

        public static MenuItem Create(string name, string description)
        {
            return new MenuItem(MenuItemId.CreateUnique(), name, description);
        }

    }
}
