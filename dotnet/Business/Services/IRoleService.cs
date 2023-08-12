using Data.QueryDto;

namespace Business.Services
{
    public interface IRoleService : IBaseEntityService<Role, RoleDto, RoleCreateDto, RoleUpdateDto, RoleQueryDto> { }
}
