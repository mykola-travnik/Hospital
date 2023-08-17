namespace Domain.Models;

public class HospitalDoctor : BaseEntity
{
    public Guid HospitalId { get; set; }
    public Guid DoctorId { get; set; }
    public Guid SpecialisationId { get; set; }
    public double? Price { get; set; }
    public virtual Hospital Hospital { get; set; }
    public virtual Doctor Doctor { get; set; }
    public virtual Specialisation Specialisation { get; set; }
}