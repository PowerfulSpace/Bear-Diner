using ErrorOr;
using Microsoft.AspNetCore.Mvc;
using PS.BearDiner.Application.Services.Authentication.Commands;
using PS.BearDiner.Application.Services.Authentication.Common;
using PS.BearDiner.Application.Services.Authentication.Queries;
using PS.BearDiner.Contracts.Authentication;

namespace PS.BearDiner.Api.Controllers
{
    [Route("[controller]")]
    public class AuthenticationController : ApiController
    {

        private readonly IAuthenticationCommandService _authenticationCommandService;
        private readonly IAuthenticationQueryService _uthenticationQueryService;

        public AuthenticationController(
            IAuthenticationCommandService authenticationCommandService,
            IAuthenticationQueryService uthenticationQueryService)
        {
            _authenticationCommandService = authenticationCommandService;
            _uthenticationQueryService = uthenticationQueryService;
        }

        [HttpPost("register")]
        public IActionResult Register(RegisterRequest request)
        {
            ErrorOr<AuthenticationResult> authResult = _authenticationCommandService.Register(
                request.FirstName,
                request.LastName,
                request.Email,
                request.Password);

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
