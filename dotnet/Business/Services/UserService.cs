using AutoMapper;
using Data;
using Data.QueryDto;
using Data.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Business.Services
{
    public class UserService : BaseEntityService<User, UserDto, UserCreateDto, UserUpdateDto, UserQueryDto>, IUserService
    {
        private readonly IUserRepository userRepository;
        private readonly IRoleRepository roleRepository;
        private readonly IMapper mapper;

        public UserService(IUserRepository userRepository, IRoleRepository roleRepository, IMapper mapper) : base(userRepository, mapper)
        {
            this.userRepository = userRepository;
            this.roleRepository = roleRepository;
            this.mapper = mapper;
        }

        public new async Task<UserDto> CreateAsync(UserCreateDto dto)
        {
            var entity = mapper.Map<UserCreateDto, User>(dto);

            var roles = await roleRepository.GetQueryable().Where(role => dto.Roles.Contains(role.Id)).ToListAsync();
            entity.Roles = roles;

            var newEntity = await userRepository.CreateAsync(entity);

            var newDto = mapper.Map<User, UserDto>(newEntity);

            return newDto;
        }

        public new async Task<UserDto> UpdateAsync(UserUpdateDto updateDto)
        {
            var updateEntity = GetQueryable().FirstOrDefault(updateEntity => updateEntity.Id == updateDto.Id);

            if (updateEntity == null) { throw new Exception("Not Found"); }

            var roles = await roleRepository.GetQueryable().Where(role => updateDto.Roles.Contains(role.Id)).ToListAsync();

            updateEntity = mapper.Map(updateDto, updateEntity);
            updateEntity.Roles = roles;

            var entity = await userRepository.UpdateAsync(updateEntity);

            return mapper.Map<User, UserDto>(entity);
        }

        public new List<UserDto> QueryAsync(UserQueryDto query)
        {
            return Find(entity => entity.Name.ToLower().StartsWith(query.Name.ToLower()));
        }
    }
}
