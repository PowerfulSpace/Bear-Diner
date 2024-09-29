using PS.BearDiner.Application.Common.Interfaces.Persistence;
using PS.BearDiner.Domain.Menus;

namespace PS.BearDiner.Infrastructure.Persistence.Repositories
{
    public class MenuRepository : IMenuRepository
    {
        private readonly BearDinerDbContext _dbContext;

        public MenuRepository(BearDinerDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void Add(Menu menu)
        {
            _dbContext.Menus.Add(menu);
            _dbContext.SaveChanges();
        }
    }
}
