﻿using ErrorOr;
using MapsterMapper;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PS.BearDiner.Application.Authentication.Commands.Register;
using PS.BearDiner.Application.Authentication.Common;
using PS.BearDiner.Application.Authentication.Queries.Login;
using PS.BearDiner.Contracts.Authentication;

namespace PS.BearDiner.Api.Controllers
{
    [Route("[controller]")]
    [AllowAnonymous]
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

            return authResult.Match(
               authResult => Ok(_mapper.Map<AuthenticationResponse>(authResult)),
               errors => Problem(errors)
               );
        }
    }
}
