using ErrorOr;
using PS.BearDiner.Application.Common.Interfaces.Authentication;
using PS.BearDiner.Application.Common.Interfaces.Persistence;
using PS.BearDiner.Application.Services.Authentication.Common;
using PS.BearDiner.Domain.Common.Errors;
using PS.BearDiner.Domain.Entities;

namespace PS.BearDiner.Application.Services.Authentication.Queries
{
    public class AuthenticationQueryService : IAuthenticationQueryService
    {
        private readonly IJwtTokenGenerator _jwtTokenGenerator;
        private readonly IUserRepository _userRepository;
        public AuthenticationQueryService(IJwtTokenGenerator jwtTokenGenerator, IUserRepository userRepository)
        {
            _jwtTokenGenerator = jwtTokenGenerator;
            _userRepository = userRepository;
        }

        public ErrorOr<AuthenticationResult> Login(string email, string password)
        {
            if (_userRepository.GetUserByEmai(email) is not User user)
            {
                return Errors.Authentication.InvalidCredentials;
            }

            if (user.Password != password)
            {
                return Errors.Authentication.InvalidCredentials;
            }

            var token = _jwtTokenGenerator.GenerateToken(user);

            return new AuthenticationResult(
               user,
               token
               );
        }
    }
}
