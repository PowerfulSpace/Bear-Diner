using ErrorOr;
using MediatR;
using PS.BearDiner.Application.Authentication.Common;

namespace PS.BearDiner.Application.Authentication.Commands.Register
{
    public record RegisterCommand(
        string FirstName,
        string LastName,
        string Email,
        string Password
        ) : IRequest<ErrorOr<AuthenticationResult>>;
}
