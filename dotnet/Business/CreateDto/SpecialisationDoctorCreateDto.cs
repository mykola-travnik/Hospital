namespace Business.CreateDto;

public record SpecialisationDoctorCreateDto : BaseCreateDto
{
    public Guid SpecialisationId { get; set; }
    public Guid DoctorId { get; set; }
    public DateOnly? Experience { get; set; }

}