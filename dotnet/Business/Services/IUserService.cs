using Data.QueryDto;

namespace Business.Services
{
    public interface IUserService : IBaseEntityService<User, UserDto, UserCreateDto, UserUpdateDto, UserQueryDto> { }
}
