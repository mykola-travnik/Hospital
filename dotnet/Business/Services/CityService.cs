using AutoMapper;
using Data.QueryDto;
using Data.Repositories;

namespace Business.Services
{
    public class CityService : BaseEntityService<City, CityDto, CityCreateDto, CityUpdateDto, CityQueryDto>, ICityService
    {
        public CityService(ICityRepository repository, IMapper mapper) : base(repository, mapper)
        {
        }

        public new List<CityDto> QueryAsync(CityQueryDto query)
        {
            return Find(entity => entity.Name.ToLower().StartsWith(query.Name.ToLower()));
        }
    }
}
