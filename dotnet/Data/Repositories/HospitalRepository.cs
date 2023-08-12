using AutoMapper;
using Data.QueryDto;
using Infrastructure.Contexts;

namespace Data.Repositories
{
    public class HospitalRepository : AbstractRepository<Hospital>, IHospitalRepository
    {
        public HospitalRepository(MainContext context) : base(context)
        {
        }
        //public List<HospitalDto> QueryAsync(HospitalQueryDto query)
        //{
        //    return Find(entity => entity.Name.ToLower().StartsWith(query.Name.ToLower()));
        //}

    }
}
