using Lupy.Domain.Records;
using Lupy.Infra.Authentication;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Lupy.Domain.Services
{
    public static class TokenService
    {
        public static string Generate(AuthUser user) 
        {
            var handler = new JwtSecurityTokenHandler();

            var credentials = new SigningCredentials
                (
                new SymmetricSecurityKey(Encoding.ASCII.GetBytes(Configuration.PrivateKey)), 
                SecurityAlgorithms.HmacSha256Signature
                );

            var token = handler.CreateToken(new SecurityTokenDescriptor {
                Subject = GenerateUserClaims(user),
                SigningCredentials = credentials, 
                Expires = DateTime.UtcNow.AddHours(8)
            });

            return handler.WriteToken(token);
        }

        public static bool IsValid(string token) 
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var tokenValidationParameters = new TokenValidationParameters
            {
                ValidateIssuerSigningKey = true,
                IssuerSigningKey = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(Configuration.PrivateKey)),
                ValidateIssuer = false,
                ValidateAudience = false,
                ValidateLifetime = true,
                ClockSkew = TimeSpan.Zero
            };

            SecurityToken validatedToken;
            tokenHandler.ValidateToken(token, tokenValidationParameters, out validatedToken);

            return true;
        }

        private static ClaimsIdentity GenerateUserClaims(AuthUser user) 
        {
            var ci = new ClaimsIdentity();

            ci.AddClaim(new Claim(ClaimTypes.Name, user.Email));
            ci.AddClaim(new Claim(ClaimTypes.Role, user.RoleId.ToString()));

            return ci;
        }
    }
}
