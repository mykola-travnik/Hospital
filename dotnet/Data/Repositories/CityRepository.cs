using AutoMapper;
using Data.QueryDto;
using Infrastructure.Contexts;

namespace Data.Repositories
{
    public class CityRepository : AbstractRepository<City, CityDto, CityCreateDto, CityUpdateDto, CityQueryDto>, ICityRepository
    {
        public CityRepository(MainContext context, IMapper mapper) : base(context, mapper)
        {
        }

        public List<CityDto> QueryAsync(CityQueryDto query)
        {
            return Find(entity => entity.Name.ToLower().StartsWith(query.Name.ToLower()));
        }
    }
}
