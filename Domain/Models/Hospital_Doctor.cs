using Domain;

public class Hospital_Doctor : BaseEntity
{
    public Guid HospitalId { get; set; }
    public Guid DoctorId { get; set; }

    public Guid SpecialisationId { get; set; }
   
    public double? Price { get; set; }
    public Hospital Hospital { get; set; }
    public Doctor Doctor { get; set; }
    public Specialisation Specialisation { get; set; }

}


