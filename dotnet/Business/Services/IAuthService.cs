using Business.Dto;

namespace Business.Services;

public interface IAuthService
{
    string LogIn(string username, string password);
    Task<string> SignIn(string username, string password);
}