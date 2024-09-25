using PS.BearDiner.Application.Common.Interfaces.Persistence;
using PS.BearDiner.Domain.Users;

namespace PS.BearDiner.Infrastructure.Persistence
{
    public class UserRepository : IUserRepository
    {
        private static readonly List<User> _users = new List<User>();
        public void AddUser(User user)
        {
            _users.Add(user);
        }

        public User? GetUserByEmai(string email)
        {
            return _users.SingleOrDefault(x => x.Email == email);
        }
    }
}
