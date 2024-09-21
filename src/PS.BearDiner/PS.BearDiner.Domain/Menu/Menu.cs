using PS.BearDiner.Domain.Common.Models;
using PS.BearDiner.Domain.Menu.Entities;
using PS.BearDiner.Domain.Menu.ValueObjects;

namespace PS.BearDiner.Domain.Menu
{
    public sealed class Menu : AggregateRoot<MenuId>
    {
        private readonly List<MenuSection> _sections = new List<MenuSection>();
        public string Name { get; set; }
        public string Description { get; set; }
        public float AverageRating { get; set; }

        public Menu(MenuId id) : base(id)
        {
        }

        public IReadOnlyList<MenuSection> Sections => _sections.AsReadOnly();
    }
}
