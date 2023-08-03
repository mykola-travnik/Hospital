using AutoMapper;
using Infrastructure.Contexts;

namespace Data.Repositories
{
    public class CountryRepository : AbstractRepository<Country, CountryDto, CountryCreateDto>, ICountryRepository
    {
        public CountryRepository(MainContext context, IMapper mapper) : base(context, mapper)
        {
        }
    }
}
