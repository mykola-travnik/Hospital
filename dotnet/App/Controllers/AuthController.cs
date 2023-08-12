using Microsoft.AspNetCore.Mvc;

namespace App.Controllers
{
    public class AuthController : ControllerBase
    {
        [HttpGet(nameof(LogIn))]
        public async Task<string> LogIn(string username, string password)
        {
            throw new NotImplementedException();
        }

        [HttpPost(nameof(SignIn))]
        public async Task<UserDto> SignIn(string username, string password)
        {
            throw new NotImplementedException();
        }
    }
}
