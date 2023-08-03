using Infrastructure.Contexts;

namespace Data.Repositories
{
    public class CityRepository : AbstractRepository<City, CityDto>, ICityRepository
    {
        public CityRepository(MainContext context) : base(context)
        {
        }
    }
}
