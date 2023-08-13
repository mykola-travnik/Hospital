using Business.CreateDto;
using Business.Dto;
using Business.QueryDto;
using Business.Services;
using Business.UpdateDto;
using Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace App.Controllers;

[ApiController]
[Route("[controller]")]
public class RoleController : AbstractController<Role, RoleDto, RoleCreateDto, RoleUpdateDto, RoleQueryDto>
{
    public RoleController(IRoleService RoleService) : base(RoleService)
    {
    }
}