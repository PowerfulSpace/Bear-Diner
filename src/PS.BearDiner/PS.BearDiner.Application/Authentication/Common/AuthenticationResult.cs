using PS.BearDiner.Domain.UsersAggregate;

namespace PS.BearDiner.Application.Authentication.Common
{
    public record AuthenticationResult(User User, string Token);
}
