using AutoMapper;
using Infrastructure.Contexts;

namespace Data.Repositories
{
    public class Specialisation_DoctorRepository : AbstractRepository<Specialisation_Doctor, Specialisation_DoctorDto, Specialisation_DoctorCreateDto, Specialisation_DoctorUpdateDto>, ISpecialisation_DoctorRepository
    {
        public Specialisation_DoctorRepository(MainContext context, IMapper mapper) : base(context, mapper)
        {
        }
    }
}
