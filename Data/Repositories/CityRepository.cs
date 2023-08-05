using AutoMapper;
using Infrastructure.Contexts;

namespace Data.Repositories
{
    public class CityRepository : AbstractRepository<City, CityDto, CityCreateDto, CityUpdateDto>, ICityRepository
    {
        public CityRepository(MainContext context, IMapper mapper) : base(context, mapper)
        {
        }
    }
}
