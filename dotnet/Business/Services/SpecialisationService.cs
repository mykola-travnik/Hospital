using AutoMapper;
using Data.QueryDto;
using Data.Repositories;

namespace Business.Services
{
    public class SpecialisationService : BaseEntityService<Specialisation, SpecialisationDto, SpecialisationCreateDto, SpecialisationUpdateDto, SpecialisationQueryDto>, ISpecialisationService
    {
        public SpecialisationService(ISpecialisationRepository repository, IMapper mapper) : base(repository, mapper)
        {
        }

        public new List<SpecialisationDto> QueryAsync(SpecialisationQueryDto query)
        {
            return Find(entity => entity.Name.ToLower().StartsWith(query.Name.ToLower()));
        }
    }
}
