using Infrastructure.Contexts;

namespace Data.Repositories
{
    public class HospitalRepository : AbstractRepository<Hospital, HospitalDto>, IHospitalRepository
    {
        public HospitalRepository(MainContext context) : base(context)
        {
        }
    }
}
