using ErrorOr;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using PS.BearDiner.Application.Authentication.Commands.Register;
using PS.BearDiner.Application.Services.Authentication.Common;
using PS.BearDiner.Contracts.Authentication;

namespace PS.BearDiner.Api.Controllers
{
    [Route("[controller]")]
    public class AuthenticationController : ApiController
    {
        private readonly IMediator _mediator;

        public AuthenticationController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register(RegisterRequest request)
        {
            var command = new RegisterCommand(
                request.FirstName,
                request.LastName,
                request.Email,
                request.Password);

            ErrorOr<AuthenticationResult> authResult = await _mediator.Send(command);

            return authResult.Match(
                authResult => Ok(MapAuthResult(authResult)),
                errors => Problem(errors)
                );
        }

        [HttpPost("login")]
        public IActionResult Login(LoginRequest request)
        {
            ErrorOr<AuthenticationResult> authResult = _uthenticationQueryService.Login(
                request.Email,
                request.Password);

            //if (authResult.IsError && authResult.FirstError == Errors.Authentication.InvalidCredentials)
            //{
            //    return Problem(statusCode: StatusCodes.Status401Unauthorized, title: authResult.FirstError.Description);
            //}

            return authResult.Match(
               authResult => Ok(MapAuthResult(authResult)),
               errors => Problem(errors)
               );
        }

        private static AuthenticationResponse MapAuthResult(AuthenticationResult authResult)
        {
            return new AuthenticationResponse(
                            authResult.User.Id,
                            authResult.User.FirstName,
                            authResult.User.LastName,
                            authResult.User.Email,
                            authResult.Token);
        }
    }
}
