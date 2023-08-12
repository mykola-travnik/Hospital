using Business.Services;
using Data.QueryDto;
using Data.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace App.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : AbstractController<User, UserDto, UserCreateDto, UserUpdateDto, UserQueryDto>
    {
        public UserController(IUserService UserService) : base(UserService)
        {
        }
    }
}