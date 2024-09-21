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

        private Menu(MenuId menuId) : base(menuId)
        {
        }

        public static Menu Create()
        {

        }

        public IReadOnlyList<MenuSection> Sections => _sections.AsReadOnly();
    }
}
