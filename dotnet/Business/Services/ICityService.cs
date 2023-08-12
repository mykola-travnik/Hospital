using Data.QueryDto;

namespace Business.Services
{
    public interface ICityService : IBaseEntityService<City, CityDto, CityCreateDto, CityUpdateDto, CityQueryDto> { }
}
