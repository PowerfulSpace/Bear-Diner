using PS.BearDiner.Domain.Entities;

namespace PS.BearDiner.Application.Common.Interfaces.Persistence
{
    public interface IUserRepository
    {
        User? GetUserByEmai(string email);
        void AddUser(User user);
    }
}
