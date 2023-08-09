using AutoMapper;
using Domain;
using Infrastructure.Contexts;

namespace Data.Repositories
{
    public class HospitalDoctorRepository : AbstractRepository<HospitalDoctor, HospitalDoctorDto, HospitalDoctorCreateDto, HospitalDoctorUpdateDto, BaseQueryDto>, IHospitalDoctorRepository
    {
        public HospitalDoctorRepository(MainContext context, IMapper mapper) : base(context, mapper)
        {
        }
    }
}
