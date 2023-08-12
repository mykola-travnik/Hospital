using AutoMapper;
using Data.QueryDto;
using Data.Repositories;

namespace Business.Services
{
    public class DoctorService : BaseEntityService<Doctor, DoctorDto, DoctorCreateDto, DoctorUpdateDto, DoctorQueryDto>, IDoctorService
    {
        public DoctorService(IDoctorRepository repository, IMapper mapper) : base(repository, mapper)
        {
        }

        public new List<DoctorDto> QueryAsync(DoctorQueryDto query)
        {
            return Find(entity => entity.FirstName.ToLower().StartsWith(query.FullName.ToLower()) ||
                entity.LastName.ToLower().StartsWith(query.FullName.ToLower()));
        }
    }
}
