﻿using ErrorOr;
using MediatR;
using PS.BearDiner.Application.Authentication.Common;
using PS.BearDiner.Application.Common.Interfaces.Authentication;
using PS.BearDiner.Application.Common.Interfaces.Persistence;
using PS.BearDiner.Domain.Common.Errors;
using PS.BearDiner.Domain.Users;

namespace PS.BearDiner.Application.Authentication.Commands.Register
{
    internal class RegisterCommandHandler : IRequestHandler<RegisterCommand, ErrorOr<AuthenticationResult>>
    {

        private readonly IJwtTokenGenerator _jwtTokenGenerator;
        private readonly IUserRepository _userRepository;

        public RegisterCommandHandler(IJwtTokenGenerator jwtTokenGenerator, IUserRepository userRepository)
        {
            _jwtTokenGenerator = jwtTokenGenerator;
            _userRepository = userRepository;
        }


        public async Task<ErrorOr<AuthenticationResult>> Handle(RegisterCommand command, CancellationToken cancellationToken)
        {
            await Task.CompletedTask;

            if (_userRepository.GetUserByEmai(command.Email) is not null)
            {
                return Errors.User.DuplicateEmail;
            }

            User user = User.Create(
                command.FirstName,
                command.LastName,
                command.Email,
                command.Password
            );

            _userRepository.AddUser(user);

            var token = _jwtTokenGenerator.GenerateToken(user);

            return new AuthenticationResult(
                user,
                token
                );
        }
    }
}
