using System;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using LogicServices.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.IdentityModel.Tokens;

namespace LogicServices.Services
{
    public class AuthenticationService
    {
        private readonly DataContext _DataContext;

        private static string JwtSecretSign = "ProEMLh5e_qnzdNUQrqdHPgp";
        private static string JwtSecretDecrypt = "ProEMLh5e_qnzdNU";
        public static SymmetricSecurityKey JwtSymmetricSecurityIssuerSigningKey => new SymmetricSecurityKey(System.Text.Encoding.ASCII.GetBytes(JwtSecretSign));
        public static SymmetricSecurityKey JwtSymmetricSecurityTokenDecryptionKey => new SymmetricSecurityKey(System.Text.Encoding.ASCII.GetBytes(JwtSecretDecrypt));

        public IHttpContextAccessor HttpContextAccessor { get; }
        public HttpRequest? Request => HttpContextAccessor?.HttpContext?.Request;

        public AuthenticationService(DataContext dataContext,IHttpContextAccessor http)
        {
            _DataContext = dataContext;
             HttpContextAccessor = http;
        }

         //החלק שאוכף את הטוקן והוא מוגדר בstartup.cs
        public static TokenValidationParameters TokenValidationParameters => new TokenValidationParameters()
        {
            ValidateIssuerSigningKey = true,
            IssuerSigningKey = JwtSymmetricSecurityIssuerSigningKey,
            TokenDecryptionKey = JwtSymmetricSecurityTokenDecryptionKey,
            ValidIssuer = "issuer",
            ValidAudience = "Audience",
            ValidateIssuer = true,
            ValidateAudience = true,
            RequireExpirationTime = true,
            ClockSkew = TimeSpan.Zero
        };
        
        public string GenerateToken(int id)
        {
            string secretKey = "your-secret-key";
            var signingKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(secretKey));

            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new[]
                {
                  new Claim("userId", id.ToString()),
                  new Claim("role", "admin")
                }),
                Expires = DateTime.UtcNow.AddDays(6),
                SigningCredentials = new SigningCredentials(signingKey, SecurityAlgorithms.HmacSha256Signature)
            };

            var tokenHandler = new JwtSecurityTokenHandler();
            var token = tokenHandler.CreateJwtSecurityToken(tokenDescriptor);
            var tokenStr = $"Bearer {tokenHandler.WriteToken(token)}";

            return tokenStr;
        }

        public string GetTokenClaims()
        {
            string tokenString = Request.Headers["Authorization"];
            tokenString ??= "";
            tokenString = tokenString.Trim();

            if (string.IsNullOrEmpty(tokenString)) { throw new Exception("JwtService - Token Is Empty"); }
            if (tokenString.Length <= "Bearer ".Length) { throw new Exception("JwtService - Token Is Too Short"); }
        
            try
            {
                var accesToken = tokenString.Substring("Bearer ".Length);

                // משתמשים בפונקציה של JWT בכדי להוציא את הפרמטרים של המפתח
                var tokenHandler = new JwtSecurityTokenHandler();
                tokenHandler.ValidateToken(accesToken, TokenValidationParameters, out var securityToken);
                JwtSecurityToken jwtToken = ((JwtSecurityToken)securityToken);

                return jwtToken.Claims.ToList().FirstOrDefault(claim => claim.Type == "UserId")?.Value;
            }
            catch (Exception ex)
            {
                throw new Exception($"JwtService Error TokenClaims  Invalid Token - {ex.Message}");
            }
        }
    }

}