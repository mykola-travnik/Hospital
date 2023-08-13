using Domain.Models;
using Infrastructure.Contexts;

namespace Data.Repositories
{
    public class HospitalDoctorRepository : AbstractRepository<HospitalDoctor>, IHospitalDoctorRepository
    {
        public HospitalDoctorRepository(MainContext context) : base(context)
        {
        }
    }
}
