using ErrorOr;
using PS.BearDiner.Application.Services.Authentication.Common;

namespace PS.BearDiner.Application.Services.Authentication.Commands
{
    public interface IAuthenticationCommandService
    {
        ErrorOr<AuthenticationResult> Register(string firstName, string lastName, string email, string password);
    }
}
