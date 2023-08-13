using Domain.Models;

namespace Business.CreateDto;

public record RecordToDoctorCreateDto : BaseCreateDto
{
    public Guid HospitalDoctorId { get; set; }
    public Guid UserId { get; set; }
    public DateTime RecordTime { get; set; }
}