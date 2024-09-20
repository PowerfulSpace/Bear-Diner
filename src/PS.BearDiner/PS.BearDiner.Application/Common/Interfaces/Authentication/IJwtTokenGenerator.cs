using PS.BearDiner.Domain.User;

namespace PS.BearDiner.Application.Common.Interfaces.Authentication
{
    public interface IJwtTokenGenerator
    {
        string GenerateToken(User user);
    }
}
