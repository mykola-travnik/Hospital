using Domain;

public class SpecialisationDoctorDto : BaseDto
{
    public Guid SpecialisationId { get; set; }
    public Guid DoctorId { get; set; }
    public DateOnly? Experience { get; set; }
}


