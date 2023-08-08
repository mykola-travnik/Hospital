using Data.QueryDto;

namespace Data.Repositories
{
    public interface ISpecialisationRepository : IRepository<Specialisation, SpecialisationDto, SpecialisationCreateDto, SpecialisationUpdateDto, SpecialisationQueryDto> { }
}
