namespace Business.CreateDto;

public record CountryCreateDto : BaseCreateDto
{
    public string Name { get; set; }
}