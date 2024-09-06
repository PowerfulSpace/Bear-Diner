using ErrorOr;
using MediatR;
using PS.BearDiner.Application.Authentication.Common;

namespace PS.BearDiner.Application.Authentication.Queries.Login
{
    public record LoginQuery(
        string Email,
        string Password
        ) : IRequest<ErrorOr<AuthenticationResult>>;
}
