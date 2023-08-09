using AutoMapper;
using Data.QueryDto;
using Domain;
using Infrastructure.Contexts;

namespace Data.Repositories
{
    public class SpecialisationDoctorRepository : AbstractRepository<SpecialisationDoctor, SpecialisationDoctorDto, SpecialisationDoctorCreateDto, SpecialisationDoctorUpdateDto, BaseQueryDto>, ISpecialisationDoctorRepository
    {
        public SpecialisationDoctorRepository(MainContext context, IMapper mapper) : base(context, mapper)
        {
        }
    }
}
