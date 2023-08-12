using Infrastructure.Contexts;

namespace Data.Repositories
{
    public class SpecialisationDoctorRepository : AbstractRepository<SpecialisationDoctor>, ISpecialisationDoctorRepository
    {
        public SpecialisationDoctorRepository(MainContext context) : base(context)
        {
        }
    }
}
