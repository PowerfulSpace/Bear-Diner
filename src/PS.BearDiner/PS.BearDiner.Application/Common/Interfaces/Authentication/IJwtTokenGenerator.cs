using PS.BearDiner.Domain.UsersAggregate;

namespace PS.BearDiner.Application.Common.Interfaces.Authentication
{
    public interface IJwtTokenGenerator
    {
        string GenerateToken(User user);
    }
}
