using AutoMapper;
using Infrastructure.Contexts;

namespace Data.Repositories
{
    public class SpecialisationRepository : AbstractRepository<Specialisation, SpecialisationDto, SpecialisationCreateDto, SpecialisationUpdateDto>, ISpecialisationRepository
    {
        public SpecialisationRepository(MainContext context, IMapper mapper) : base(context, mapper)
        {
        }
    }
}
