using Business.Services;
using Microsoft.AspNetCore.Mvc;

namespace App.Controllers
{
    public class AuthController : ControllerBase
    {
        private readonly IAuthService authService;

        public AuthController(IAuthService authService)
        {
            this.authService = authService;
        }

        [HttpGet(nameof(LogIn))]
        public string LogIn(string username, string password)
        {
            return authService.LogIn(username, password);
        }

        [HttpPost(nameof(SignIn))]
        public async Task<UserDto> SignIn(string username, string password)
        {
            return await authService.SignIn(username, password);
        }
    }
}
