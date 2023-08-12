using Domain;

public class SpecialisationDoctorDto : BaseDto
{
    public Doctor Doctor { get; set; }
    public Specialisation Specialisation { get; set; }
    public DateOnly? Experience { get; set; }
}


