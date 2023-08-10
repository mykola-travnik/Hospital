using AutoMapper;
using Data.QueryDto;
using Infrastructure.Contexts;

namespace Data.Repositories
{
    public class DoctorRepository : AbstractRepository<Doctor, DoctorDto, DoctorCreateDto, DoctorUpdateDto, DoctorQueryDto>, IDoctorRepository
    {
        public DoctorRepository(MainContext context, IMapper mapper) : base(context, mapper)
        {
        }
        public List<DoctorDto> QueryAsync(DoctorQueryDto query)
        {
            if (string.IsNullOrWhiteSpace(query.FullName))
                return Find(entity => true);

            return Find(entity => entity.FirstName.ToLower().StartsWith(query.FullName.ToLower()) ||
                entity.LastName.ToLower().StartsWith(query.FullName.ToLower()));
        }
    }
}
