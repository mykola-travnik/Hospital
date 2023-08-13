using Domain.Models;

namespace Business.QueryDto;

public record RecordToDoctorQueryDto : BaseQueryDto
{
    public UserQueryDto User { get; set; }
    public HospitalQueryDto Hospital { get; set; }
    public SpecialisationQueryDto Specialisation { get; set; }
    public DoctorQueryDto Doctor { get; set; }
    public DateTime FromRecordTime { get; set; }
    public DateTime ToRecordTime { get; set; }
}