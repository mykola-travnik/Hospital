using Domain;

public class HospitalDoctorDto : BaseDto
{
    public double? Price { get; set; }

    public HospitalDto Hospital { get; set; }

    public DoctorDto Doctor { get; set; }

    public SpecialisationDto Specialisation { get; set; }
}