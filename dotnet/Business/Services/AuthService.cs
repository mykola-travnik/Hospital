using AutoMapper;
using Business.DataSeedService;
using Data.Repositories;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using Business.Dto;
using Domain.Models;

namespace Business.Services
{

    public class AuthService : IAuthService
    {
        private readonly IUserRepository userRepository;
        private readonly IMapper mapper;

        public AuthService(IUserRepository userRepository, IMapper mapper)
        {
            this.userRepository = userRepository;
            this.mapper = mapper;
        }

        public string LogIn(string username, string password)
        {
            var user = userRepository.GetQueryable().FirstOrDefault(user => user.Name.Equals(username));

            if (user == default)
            {
                throw new Exception("User not found");
            }

            if (user.Password != HashHelpers.GetHashString(password))
            {
                throw new Exception("Password incorrect");
            }

            return GenerateJWTToken(user);
        }
        public async Task<UserDto> SignIn(string username, string password)
        {
            var newUser = new User()
            {
                Name = username,
                Roles = new List<Role> { RoleDataSeedService.UserRole },
                Password = HashHelpers.GetHashString(password)
            };

            return mapper.Map<UserDto>(await userRepository.CreateAsync(newUser));
        }

        private string GenerateJWTToken(User user)
        {
            var claims = new List<Claim> { new Claim("username", user.Name) };
            // создаем JWT-токен
            var jwt = new JwtSecurityToken(
                    issuer: AuthOptions.ISSUER,
                    audience: AuthOptions.AUDIENCE,
                    claims: claims,
                    expires: DateTime.UtcNow.Add(TimeSpan.FromMinutes(2)),
                    signingCredentials: new SigningCredentials(AuthOptions.GetSymmetricSecurityKey(), SecurityAlgorithms.HmacSha256));

            return new JwtSecurityTokenHandler().WriteToken(jwt);
        }


    }
}
