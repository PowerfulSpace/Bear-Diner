using PS.BearDiner.Domain.Menus;

namespace PS.BearDiner.Application.Common.Interfaces.Persistence
{
    public interface IMenuRepository
    {
        void Add(Menu menu);
    }
}