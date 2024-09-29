using PS.BearDiner.Application.Common.Interfaces.Persistence;
using PS.BearDiner.Domain.Menus;

namespace PS.BearDiner.Infrastructure.Persistence.Repositories
{
    public class MenuRepository : IMenuRepository
    {
        public static readonly List<Menu> _menus = new List<Menu>();
        public void Add(Menu menu)
        {
            _menus.Add(menu);
        }
    }
}
