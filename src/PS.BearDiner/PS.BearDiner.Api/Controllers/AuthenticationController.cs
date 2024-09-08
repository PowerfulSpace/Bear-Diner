using ErrorOr;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using PS.BearDiner.Application.Authentication.Commands.Register;
using PS.BearDiner.Application.Authentication.Queries.Login;
using PS.BearDiner.Application.Authentication.Common;
using PS.BearDiner.Contracts.Authentication;
using MapsterMapper;

namespace PS.BearDiner.Api.Controllers
{
    [Route("[controller]")]
    public class AuthenticationController : ApiController
    {
        private readonly ISender _mediator;
        private readonly IMapper _mapper;

        public AuthenticationController(ISender mediator, IMapper mapper)
        {
            _mediator = mediator;
            _mapper = mapper;
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register(RegisterRequest request)
        {
            var command = _mapper.Map<RegisterCommand>(request);

            ErrorOr<AuthenticationResult> authResult = await _mediator.Send(command);

            //return authResult.Match(
            //    authResult => Ok(MapAuthResult(authResult)),
            //    errors => Problem(errors)
            //    );

            return authResult.Match(
              authResult => Ok(_mapper.Map<AuthenticationResponse>(authResult)),
              errors => Problem(errors)
              );
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login(LoginRequest request)
        {
            var query = _mapper.Map<LoginQuery>(request);

            ErrorOr<AuthenticationResult> authResult = await _mediator.Send(query);

            //Использовать этот код для тестов

            //if (authResult.IsError && authResult.FirstError == Errors.Authentication.InvalidCredentials)
            //{
            //    return Problem(statusCode: StatusCodes.Status401Unauthorized, title: authResult.FirstError.Description);
            //}

            return authResult.Match(
               authResult => Ok(_mapper.Map<AuthenticationResponse>(authResult)),
               errors => Problem(errors)
               );
        }
    }
}
