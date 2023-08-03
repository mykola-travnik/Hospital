using Infrastructure.Contexts;

namespace Data.Repositories
{
    public class SpecialisationRepository : AbstractRepository<Specialisation, SpecialisationDto>, ISpecialisationRepository
    {
        public SpecialisationRepository(MainContext context) : base(context)
        {
        }
    }
}
