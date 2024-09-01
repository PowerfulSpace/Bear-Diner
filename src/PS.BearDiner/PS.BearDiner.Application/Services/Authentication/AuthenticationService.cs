using PS.BearDiner.Application.Common.Interfaces.Authentication;
using PS.BearDiner.Application.Common.Interfaces.Persistence;
using PS.BearDiner.Domain.Entities;

namespace PS.BearDiner.Application.Services.Authentication
{
    public class AuthenticationService : IAuthenticationService
    {
        private readonly IJwtTokenGenerator _jwtTokenGenerator;
        private readonly IUserRepository _userRepository;
        public AuthenticationService(IJwtTokenGenerator jwtTokenGenerator, IUserRepository userRepository)
        {
            _jwtTokenGenerator = jwtTokenGenerator;
            _userRepository = userRepository;
        }

        public AuthenticationResult Register(string firstName, string lastName, string email, string password)
        {

            if (_userRepository.GetUserByEmai(email) is not null)
            {
                throw new Exception("User with given email already exists.");
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
        

        public AuthenticationResult Login(string email, string password)
        {
            if (_userRepository.GetUserByEmai(email) is null)
            {
                throw new Exception("User is not exists.");
            }

            var user = _userRepository.GetUserByEmai(email);

            if(user.Password != password)
            {
                throw new Exception("Invalid password");
            }

            var token = _jwtTokenGenerator.GenerateToken(user);

            return new AuthenticationResult(
               user,
               token
               );
        }
    }
}
