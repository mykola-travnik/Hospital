namespace Business.UpdateDto;

public record SpecialisationDoctorUpdateDto : BaseUpdateDto
{
    public Guid SpecialisationId { get; set; }
    public Guid DoctorId { get; set; }
    public DateOnly? Experience { get; set; }
}