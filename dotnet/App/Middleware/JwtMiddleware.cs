using Business;
using Business.Services;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Text;

namespace App.Middleware
{
    public class JwtMiddleware
    {
        public static string AUTHORIZATION_HEADER = "Authorization";

        private readonly RequestDelegate _next;

        public JwtMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext context)
        {
            var token = context.Request.Headers[AUTHORIZATION_HEADER].FirstOrDefault()?.Split(" ").Last();
            var (username, role) = ValidateToken(token);
            if (username != null)
            {
                // attach user to context on successful jwt validation
                context.Items[AuthOptions.USERNAME_CLAIM] = username;
                context.Items[AuthOptions.USER_ROLES_CLAIM] = role;
            }

            await _next(context);
        }

        public (string?, string?) ValidateToken(string? token)
        {
            if (token == null)
                return (null, null);

            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(AuthOptions.KEY);
            try
            {
                tokenHandler.ValidateToken(token, new TokenValidationParameters
                {
                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey = new SymmetricSecurityKey(key),
                    ValidateIssuer = false,
                    ValidateAudience = false,
                    // set clockskew to zero so tokens expire exactly at token expiration time (instead of 5 minutes later)
                    ClockSkew = TimeSpan.Zero
                }, out SecurityToken validatedToken);

                var jwtToken = (JwtSecurityToken)validatedToken;
                var userName = jwtToken.Claims.First(x => x.Type == AuthOptions.USERNAME_CLAIM).Value;
                var roles = jwtToken.Claims.First(x => x.Type == AuthOptions.USER_ROLES_CLAIM).Value;

                // return user id from JWT token if validation successful
                return (userName, roles);
            }
            catch
            {
                // return null if validation fails
                return (null, null);
            }
        }
    }
}
