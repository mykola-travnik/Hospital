using Business;
using Business.Dto;

public record RecordToDoctorDto : BaseDto
{
    public HospitalDoctorDto HospitalDoctor { get; set; }
    public UserDto User { get; set; }
    public DateTime RecordTime { get; set; }
}