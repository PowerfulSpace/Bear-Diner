using Microsoft.IdentityModel.Tokens;
using PS.BearDiner.Application.Common.Interfaces;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace PS.BearDiner.Infrastructure.Autentication
{
    public class JwtTokenGenerator : IJwtTokenGenerator
    {
        public string GenerateToken(Guid id, string firstName, string lastName)
        {
            var signingCredentials = new SigningCredentials(
                new SymmetricSecurityKey(Encoding.UTF8.GetBytes("super-secret-keysuper-secret-key")),
                SecurityAlgorithms.HmacSha256
                );

            var claims = new[]
            {
                new Claim(JwtRegisteredClaimNames.Sub,id.ToString()),
                new Claim(JwtRegisteredClaimNames.GivenName,firstName),
                new Claim(JwtRegisteredClaimNames.FamilyName,lastName)
            };

            
            var securityToken = new JwtSecurityToken(
                issuer: "BearDiner",
                expires: DateTime.Now.AddDays(1),
                claims: claims,
                signingCredentials: signingCredentials);


            return new JwtSecurityTokenHandler().WriteToken(securityToken);
        }
    }
}
