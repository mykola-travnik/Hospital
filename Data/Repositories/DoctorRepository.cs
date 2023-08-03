using AutoMapper;
using Infrastructure.Contexts;

namespace Data.Repositories
{
    public class DoctorRepository : AbstractRepository<Doctor, DoctorDto>, IDoctorRepository
    {
        public DoctorRepository(MainContext context, IMapper mapper) : base(context, mapper)
        {
        }
    }
}
