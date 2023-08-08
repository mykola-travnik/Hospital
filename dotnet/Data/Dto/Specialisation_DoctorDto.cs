using Domain;

public class Specialisation_DoctorDto : BaseDto
{
    public Guid SpecialisationId { get; set; }
    public Guid DoctorId { get; set; }
    public DateOnly? Experience { get; set; }
}


