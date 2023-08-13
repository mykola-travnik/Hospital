using Domain.Models;

namespace Business.UpdateDto;

public record RecordToDoctorUpdateDto : BaseUpdateDto
{
    public DateTime RecordTime { get; set; }
}