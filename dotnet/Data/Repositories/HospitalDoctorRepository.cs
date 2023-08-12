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

        //public List<HospitalDoctorDto> QueryAsync(HospitalDoctorQueryDto query)
        //{
        //    if (query.Price == null || query.Price == 0)
        //        return Find(entity => true);

        //    return Find(entity => entity.Price == query.Price);
        //}
    }
}
