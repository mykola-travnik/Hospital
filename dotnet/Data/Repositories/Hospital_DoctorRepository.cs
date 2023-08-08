using AutoMapper;
using Domain;
using Infrastructure.Contexts;

namespace Data.Repositories
{
    public class Hospital_DoctorRepository : AbstractRepository<Hospital_Doctor, Hospital_DoctorDto, Hospital_DoctorCreateDto, Hospital_DoctorUpdateDto, BaseQueryDto>, IHospital_DoctorRepository
    {
        public Hospital_DoctorRepository(MainContext context, IMapper mapper) : base(context, mapper)
        {
        }
    }
}
