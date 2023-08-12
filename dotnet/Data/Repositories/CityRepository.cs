using AutoMapper;
using Data.QueryDto;
using Infrastructure.Contexts;

namespace Data.Repositories
{
    public class CityRepository : AbstractRepository<City>, ICityRepository
    {
        public CityRepository(MainContext context) : base(context)
        {
        }
    }
}
