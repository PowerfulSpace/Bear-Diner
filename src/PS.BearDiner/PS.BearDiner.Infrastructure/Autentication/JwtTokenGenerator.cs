using PS.BearDiner.Application.Common.Interfaces;

namespace PS.BearDiner.Infrastructure.Autentication
{
    public class JwtTokenGenerator : IJwtTokenGenerator
    {
        public string GenerateToken(Guid id, string firstName, string lastName)
        {
            throw new NotImplementedException();
        }
    }
}
