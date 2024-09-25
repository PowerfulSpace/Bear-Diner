using PS.BearDiner.Domain.Users;

namespace PS.BearDiner.Application.Common.Interfaces.Authentication
{
    public interface IJwtTokenGenerator
    {
        string GenerateToken(User user);
    }
}
