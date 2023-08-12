using AutoMapper;
using Data.QueryDto;
using Domain;
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
