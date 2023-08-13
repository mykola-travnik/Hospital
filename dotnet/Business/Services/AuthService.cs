using AutoMapper;
using Business.DataSeedService;
using Data.Repositories;
using Domain.Models;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;

namespace Business.Services;

public class AuthService : IAuthService
{
    private readonly IMapper mapper;
    private readonly IUserRepository userRepository;
    private readonly IRoleRepository roleRepository;

    public AuthService(IUserRepository userRepository, IRoleRepository roleRepository, IMapper mapper)
    {
        this.userRepository = userRepository;
        this.roleRepository = roleRepository;
        this.mapper = mapper;
    }

    public string LogIn(string username, string password)
    {
        var user = userRepository.GetQueryable().FirstOrDefault(user => user.Name.Equals(username));

        if (user == default) throw new Exception("User not found");

        if (user.Password != HashHelpers.GetHashString(password)) throw new Exception("Password incorrect");

        return GenerateJWTToken(user);
    }

    public async Task<string> SignIn(string username, string password)
    {
        var userAlreadyExist = userRepository.GetQueryable().Any(user => user.Name.Equals(username));

        if (userAlreadyExist)
            throw new Exception("User already exist");

        var userRole = roleRepository.Get(RoleDataSeedService.UserRole.Id);

        var newUser = new User
        {
            Name = username,
            Roles = new List<Role> { userRole },
            Password = HashHelpers.GetHashString(password)
        };

        var user = await userRepository.CreateAsync(newUser);

        return GenerateJWTToken(user);
    }

    private string GenerateJWTToken(User user)
    {
        var claims = new List<Claim> { new("username", user.Name) };
        // создаем JWT-токен
        var jwt = new JwtSecurityToken(
            AuthOptions.ISSUER,
            AuthOptions.AUDIENCE,
            claims,
            expires: DateTime.UtcNow.Add(TimeSpan.FromMinutes(2)),
            signingCredentials: new SigningCredentials(AuthOptions.GetSymmetricSecurityKey(),
                SecurityAlgorithms.HmacSha256));

        return new JwtSecurityTokenHandler().WriteToken(jwt);
    }
}