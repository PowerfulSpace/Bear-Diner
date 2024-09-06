using ErrorOr;
using PS.BearDiner.Application.Services.Authentication.Common;

namespace PS.BearDiner.Application.Services.Authentication.Queries
{
    public interface IAuthenticationQueryService
    {
        ErrorOr<AuthenticationResult> Login(string email, string password);
    }
}
