using ErrorOr;
using MediatR;
using PS.BearDiner.Application.Authentication.Commands.Register;
using PS.BearDiner.Application.Authentication.Common;

namespace PS.BearDiner.Application.Common.Behaviors
{
    public class ValidationRegisterCommandBehavior : IPipelineBehavior<RegisterCommand, ErrorOr<AuthenticationResult>>
    {
        public async Task<ErrorOr<AuthenticationResult>> Handle(
            RegisterCommand request,
            RequestHandlerDelegate<ErrorOr<AuthenticationResult>> next,
            CancellationToken cancellationToken)
        {
            var result = await next();

            return result;
        }
    }
}
