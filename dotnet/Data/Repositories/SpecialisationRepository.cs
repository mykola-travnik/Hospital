using AutoMapper;
using Data.QueryDto;
using Infrastructure.Contexts;

namespace Data.Repositories
{
    public class SpecialisationRepository : AbstractRepository<Specialisation, SpecialisationDto, SpecialisationCreateDto, SpecialisationUpdateDto, SpecialisationQueryDto>, ISpecialisationRepository
    {
        public SpecialisationRepository(MainContext context, IMapper mapper) : base(context, mapper)
        {
        }
        public List<SpecialisationDto> QueryAsync(SpecialisationQueryDto query)
        {
            return Find(entity => entity.Name.ToLower().StartsWith(query.Name.ToLower()));
        }

    }
}
