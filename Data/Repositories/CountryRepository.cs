using Infrastructure.Contexts;

namespace Data.Repositories
{
    public class CountryRepository : AbstractRepository<Country, CountryDto>, ICountryRepository
    {
        public CountryRepository(MainContext context) : base(context)
        {
        }
    }
}
