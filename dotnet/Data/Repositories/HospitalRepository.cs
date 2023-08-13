using Domain.Models;
using Infrastructure.Contexts;

namespace Data.Repositories;

public class HospitalRepository : AbstractRepository<Hospital>, IHospitalRepository
{
    public HospitalRepository(MainContext context) : base(context)
    {
    }
}