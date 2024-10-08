﻿using PS.BearDiner.Domain.Common.Models;
using PS.BearDiner.Domain.Menus.ValueObjects;

namespace PS.BearDiner.Domain.Menus.Entities
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

#pragma warning disable CS8618
        private MenuItem() { }
#pragma warning restore CS8618
    }
}
