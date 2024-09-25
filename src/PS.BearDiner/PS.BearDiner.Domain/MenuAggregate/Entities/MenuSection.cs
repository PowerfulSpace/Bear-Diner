using PS.BearDiner.Domain.Common.Models;
using PS.BearDiner.Domain.MenuAggregate.ValueObjects;

namespace PS.BearDiner.Domain.MenuAggregate.Entities
{
    public sealed class MenuSection : Entity<MenuSectionId>
    {
        private readonly List<MenuItem> _items = new List<MenuItem>();
        public IReadOnlyList<MenuItem> Items => _items.AsReadOnly();

        public string Name { get; set; }
        public string Description { get; set; }        
        

        private MenuSection(MenuSectionId menuSectionId, string name, string description, List<MenuItem> items)
            : base(menuSectionId)
        {
            Name = name;
            Description = description;
            _items = items;
        }

        public static MenuSection Create(string name, string description, List<MenuItem> items)
        {
            return new MenuSection(MenuSectionId.CreateUnique(), name, description, items);
        }

#pragma warning disable CS8618
        private MenuSection() { }
#pragma warning restore CS8618
    }
}
