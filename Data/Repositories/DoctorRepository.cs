using Infrastructure.Contexts;

namespace Data.Repositories
{
    public class DoctorRepository : AbstractRepository<Doctor, DoctorDto>, IDoctorRepository
    {
        public DoctorRepository(MainContext context) : base(context)
        {
        }
    }
}
