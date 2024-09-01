using PS.BearDiner.Domain.Entities;

namespace PS.BearDiner.Application.Common.Interfaces.Authentication
{
    public interface IJwtTokenGenerator
    {
        string GenerateToken(User user);
    }
}
