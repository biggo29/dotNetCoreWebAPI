using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace eTINwebAPI_2.JWTAuth
{
public class JWTAuthValidator : ISecurityTokenValidator
    {
        private int _maxTokenSizeInBytes = TokenValidationParameters.DefaultMaximumTokenSizeInBytes;
        private JwtSecurityTokenHandler _tokenHandler;
        private readonly IHttpContextAccessor _httpContextAccessor;
        readonly IConfiguration _configuration;

        public JWTAuthValidator(IHttpContextAccessor httpContextAccessor, IConfiguration configuration)
        {
            _configuration = configuration;
            _httpContextAccessor = httpContextAccessor;
            _tokenHandler = new JwtSecurityTokenHandler();
        }
        public bool CanValidateToken
        {
            get
            {
                return true;
            }
        }
        public int MaximumTokenSizeInBytes
        {
            get
            {
                return _maxTokenSizeInBytes;
            }

            set
            {
                _maxTokenSizeInBytes = value;
            }
        }
        public bool CanReadToken(string securityToken)
        {
            return _tokenHandler.CanReadToken(securityToken);
        }

        public ClaimsPrincipal ValidateToken(string securityToken, TokenValidationParameters validationParameters, out SecurityToken validatedToken)
        {
            var httpContext = _httpContextAccessor.HttpContext;
            var jwtSecurityToken = new JwtSecurityToken(securityToken).Payload.FirstOrDefault(p => p.Key.Equals("unique_name")).Value.ToString();
            string securityKey = "moinul.islam@synesisit.com.bd";
            if (!Token.IsKeyExist(jwtSecurityToken, ref securityKey)) {
                throw new UnauthorizedAccessException();
            }
            
            var symmetricSecurityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(securityKey));
            //jwtSecurityToken.Subject.
            var principal = _tokenHandler.ValidateToken(securityToken,
                new TokenValidationParameters
                {
                    ValidateIssuer = true,
                    ValidateAudience = true,
                    ValidateIssuerSigningKey = true,
                    ValidIssuer = _configuration["Jwt:Issuer"],//"NBR",
                    ValidAudience = "eTINwebAPI_2",
                    IssuerSigningKey = symmetricSecurityKey
                }
                , out validatedToken);


            return principal;
        }
    }
}
