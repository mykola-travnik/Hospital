using Business.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace App.Controllers;

[ApiController]
[Route("[controller]")]
[AllowAnonymous]
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
    public async Task<string> SignIn(string username, string password)
    {
        return await authService.SignIn(username, password);
    }
}