using PS.BearDiner.Domain.Entities;

namespace PS.BearDiner.Application.Authentication.Common
{
    public record AuthenticationResult(User User, string Token);
}
