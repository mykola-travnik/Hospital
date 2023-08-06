using Domain;

public class Specialisation_Doctor : BaseEntity
{
    public Guid SpecialisationId { get; set; }
    public Guid DoctorId { get; set; }
    public DateOnly? Experience { get; set; }

    public Doctor Doctor { get; set; }
    public Specialisation Specialisation { get; set; }

}


