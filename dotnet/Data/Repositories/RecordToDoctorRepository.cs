using Domain.Models;
using Infrastructure.Contexts;

namespace Data.Repositories;

public class RecordToDoctorRepository : AbstractRepository<RecordToDoctor>, IRecordToDoctorRepository
{
    public RecordToDoctorRepository(MainContext context) : base(context)
    {
    }
}