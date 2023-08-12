using Business.Services;
using Data.QueryDto;
using Data.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace App.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RoleController : AbstractController<Role, RoleDto, RoleCreateDto, RoleUpdateDto, RoleQueryDto>
    {
        public RoleController(IRoleService RoleService) : base(RoleService)
        {
        }
    }
}