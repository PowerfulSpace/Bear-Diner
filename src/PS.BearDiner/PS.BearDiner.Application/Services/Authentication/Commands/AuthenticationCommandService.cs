using ErrorOr;
using PS.BearDiner.Application.Common.Interfaces.Authentication;
using PS.BearDiner.Application.Common.Interfaces.Persistence;
using PS.BearDiner.Application.Services.Authentication.Common;
using PS.BearDiner.Domain.Common.Errors;
using PS.BearDiner.Domain.Entities;

namespace PS.BearDiner.Application.Services.Authentication.Commands
{
    public class AuthenticationCommandService : IAuthenticationCommandService
    {
        private readonly IJwtTokenGenerator _jwtTokenGenerator;
        private readonly IUserRepository _userRepository;
        public AuthenticationCommandService(IJwtTokenGenerator jwtTokenGenerator, IUserRepository userRepository)
        {
            _jwtTokenGenerator = jwtTokenGenerator;
            _userRepository = userRepository;
        }

        public ErrorOr<AuthenticationResult> Register(string firstName, string lastName, string email, string password)
        {

            if (_userRepository.GetUserByEmai(email) is not null)
            {
                return Errors.User.DuplicateEmail;
            }

            User user = new User
            {
                FirstName = firstName,
                LastName = lastName,
                Email = email,
                Password = password
            };

            _userRepository.AddUser(user);

            var token = _jwtTokenGenerator.GenerateToken(user);

            return new AuthenticationResult(
                user,
                token
                );
        }
    }
}
