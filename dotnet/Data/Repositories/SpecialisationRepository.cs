using Infrastructure.Contexts;

namespace Data.Repositories
{
    public class SpecialisationRepository : AbstractRepository<Specialisation>, ISpecialisationRepository
    {
        public SpecialisationRepository(MainContext context) : base(context)
        {
        }

    }
}
