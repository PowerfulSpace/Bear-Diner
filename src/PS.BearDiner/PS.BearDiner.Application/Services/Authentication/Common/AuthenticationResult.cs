using PS.BearDiner.Domain.Entities;

namespace PS.BearDiner.Application.Services.Authentication.Common
{
    public record AuthenticationResult(
        User User,
        string Token
        );
}
