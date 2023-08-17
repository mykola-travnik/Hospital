namespace Domain.Models;

public class SpecialisationDoctor : BaseEntity
{
    public Guid SpecialisationId { get; set; }
    public Guid DoctorId { get; set; }
    public DateOnly? Experience { get; set; }
    public virtual Doctor Doctor { get; set; }
    public virtual Specialisation Specialisation { get; set; }
}