using Business.CreateDto;
using Business.Dto;
using Business.QueryDto;
using Business.Services;
using Business.UpdateDto;
using Data.Repositories;
using Domain.Models;
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