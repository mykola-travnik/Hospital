using Business.Dto;

namespace Business.Services
{
    public interface IAuthService
    {
        string LogIn(string username, string password);
        Task<UserDto> SignIn(string username, string password);
    }
}