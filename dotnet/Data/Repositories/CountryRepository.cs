using Infrastructure.Contexts;

namespace Data.Repositories
{
    public class CountryRepository : AbstractRepository<Country>, ICountryRepository
    {
        public CountryRepository(MainContext context) : base(context)
        {
        }
    }
}
