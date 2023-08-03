using AutoMapper;
using Infrastructure.Contexts;

namespace Data.Repositories
{
    public class HospitalRepository : AbstractRepository<Hospital, HospitalDto, HospitalCreateDto>, IHospitalRepository
    {
        public HospitalRepository(MainContext context, IMapper mapper) : base(context, mapper)
        {
        }
    }
}
