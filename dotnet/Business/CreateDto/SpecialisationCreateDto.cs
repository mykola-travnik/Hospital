namespace Business.CreateDto;

public record SpecialisationCreateDto : BaseCreateDto
{
    public string Name { get; set; }
}