using Business.CreateDto;
using Business.Dto;
using Business.QueryDto;
using Business.UpdateDto;
using Domain.Models;

namespace Business.Services
{
    public interface IRoleService : IBaseEntityService<Role, RoleDto, RoleCreateDto, RoleUpdateDto, RoleQueryDto> { }
}
