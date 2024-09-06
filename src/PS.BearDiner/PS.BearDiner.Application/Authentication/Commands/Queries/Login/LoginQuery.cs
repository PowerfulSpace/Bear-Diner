using ErrorOr;
using MediatR;
using PS.BearDiner.Application.Services.Authentication.Common;

namespace PS.BearDiner.Application.Authentication.Commands.Queries.Login
{
    public record LoginQuery(
        string Email,
        string Password
        ) : IRequest<ErrorOr<AuthenticationResult>>;
}
