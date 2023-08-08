using Data.QueryDto;

namespace Data.Repositories
{
    public interface ICityRepository: IRepository<City, CityDto, CityCreateDto, CityUpdateDto, CityQueryDto> { }
}
