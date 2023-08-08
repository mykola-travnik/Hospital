using Domain;

public class Specialisation_DoctorCreateDto : BaseCreateDto
{
    public Guid SpecialisationId { get; set; }
    public Guid DoctorId { get; set; }
    public DateOnly? Experience { get; set; }

}


