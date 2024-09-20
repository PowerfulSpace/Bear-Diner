using PS.BearDiner.Domain.User;

namespace PS.BearDiner.Application.Authentication.Common
{
    public record AuthenticationResult(User User, string Token);
}
