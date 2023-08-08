using AutoMapper;
using Data.QueryDto;
using Infrastructure.Contexts;

namespace Data.Repositories
{
    public class CountryRepository : AbstractRepository<Country, CountryDto, CountryCreateDto, CountryUpdateDto, CountryQueryDto>, ICountryRepository
    {
        public CountryRepository(MainContext context, IMapper mapper) : base(context, mapper)
        {
        }

        public override List<CountryDto> QueryAsync(CountryQueryDto query)
        {
            return Find(entity => entity.Name.ToLower().StartsWith(query.Name.ToLower()));
        }
    }
}
