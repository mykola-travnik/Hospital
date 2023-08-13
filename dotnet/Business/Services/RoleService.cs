using AutoMapper;
using Business.CreateDto;
using Business.Dto;
using Business.QueryDto;
using Business.UpdateDto;
using Data.Repositories;
using Domain.Models;

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
