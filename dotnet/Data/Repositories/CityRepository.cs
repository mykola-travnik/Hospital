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

        //public List<CityDto> QueryAsync(CityQueryDto query)
        //{
        //    return Find(entity => entity.Name.ToLower().StartsWith(query.Name.ToLower()));
        //}
    }
}
