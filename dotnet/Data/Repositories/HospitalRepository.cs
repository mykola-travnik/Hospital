using AutoMapper;
using Data.QueryDto;
using Infrastructure.Contexts;

namespace Data.Repositories
{
    public class HospitalRepository : AbstractRepository<Hospital, HospitalDto, HospitalCreateDto, HospitalUpdateDto, HospitalQueryDto>, IHospitalRepository
    {
        public HospitalRepository(MainContext context, IMapper mapper) : base(context, mapper)
        {
        }
    }
}
