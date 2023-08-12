using AutoMapper;
using Data.QueryDto;
using Infrastructure.Contexts;

namespace Data.Repositories
{
    public class SpecialisationRepository : AbstractRepository<Specialisation>, ISpecialisationRepository
    {
        public SpecialisationRepository(MainContext context) : base(context)
        {
        }
        //public List<SpecialisationDto> QueryAsync(SpecialisationQueryDto query)
        //{
        //    return Find(entity => entity.Name.ToLower().StartsWith(query.Name.ToLower()));
        //}

    }
}
