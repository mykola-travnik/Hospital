namespace Business.Dto;

public record DoctorDto : BaseDto
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string? Phone { get; set; }
    public string? Photo { get; set; }
    public string? Description { get; set; }
    public string? FullDescription { get; set; }
    public DateOnly Birthday { get; set; }
}