using PS.BearDiner.Domain.User;

namespace PS.BearDiner.Application.Common.Interfaces.Persistence
{
    public interface IUserRepository
    {
        User? GetUserByEmai(string email);
        void AddUser(User user);
    }
}
