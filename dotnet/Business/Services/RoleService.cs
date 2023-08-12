using AutoMapper;
using Data.QueryDto;
using Data.Repositories;

namespace Business.Services
{
    public class RoleService : BaseEntityService<Role, RoleDto, RoleCreateDto, RoleUpdateDto, RoleQueryDto>, IRoleService
    {
        public RoleService(IRoleRepository repository, IMapper mapper) : base(repository, mapper)
        {
        }

        public new List<RoleDto> QueryAsync(RoleQueryDto query)
        {
            return Find(entity => entity.Name.ToLower().StartsWith(query.Name.ToLower()));
        }
    }
}
