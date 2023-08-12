using AutoMapper;
using Data.QueryDto;
using Data.Repositories;

namespace Business.Services
{
    public class HospitalDoctorService : BaseEntityService<HospitalDoctor, HospitalDoctorDto, HospitalDoctorCreateDto, HospitalDoctorUpdateDto, HospitalDoctorQueryDto>, IHospitalDoctorService
    {
        public HospitalDoctorService(IHospitalDoctorRepository repository, IMapper mapper) : base(repository, mapper)
        {
        }

        public new List<HospitalDoctorDto> QueryAsync(HospitalDoctorQueryDto query)
        {
            if (query.Price == null || query.Price == 0)
                return Find(entity => true);

            return Find(entity => entity.Price == query.Price);

        }
    }
}
