using PS.BearDiner.Domain.Common.Models;
using PS.BearDiner.Domain.Menu.ValueObjects;

namespace PS.BearDiner.Domain.Menu.Entities
{
    public sealed class MenuSection : Entity<MenuSectionId>
    {
        private readonly List<MenuItem> _items = new List<MenuItem>();
        public string Name { get; set; }
        public string Description { get; set; }

        private MenuSection(MenuSectionId menuSectionId, string name, string description)
            : base(menuSectionId)
        {
            Name = name;
            Description = description;
        }

        public static MenuSection Create(string name, string description)
        {
            return new MenuSection(MenuSectionId.CreateUnique(), name, description);
        }

        public IReadOnlyList<MenuItem> Items => _items.AsReadOnly();
    }
}
