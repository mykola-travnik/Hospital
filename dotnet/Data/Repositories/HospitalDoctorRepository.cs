using AutoMapper;
using Data.QueryDto;
using Domain;
using Infrastructure.Contexts;

namespace Data.Repositories
{
    public class HospitalDoctorRepository : AbstractRepository<HospitalDoctor, HospitalDoctorDto, HospitalDoctorCreateDto, HospitalDoctorUpdateDto, HospitalDoctorQueryDto>, IHospitalDoctorRepository
    {
        public HospitalDoctorRepository(MainContext context, IMapper mapper) : base(context, mapper)
        {
        }

        public List<HospitalDoctorDto> QueryAsync(HospitalDoctorQueryDto query)
        {
            if (query.Price == null || query.Price == 0)
                return Find(entity => true);

            return Find(entity => entity.Price == query.Price);
        }
    }
}
