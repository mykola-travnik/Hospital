namespace Business.CreateDto;

public record CityCreateDto : BaseCreateDto
{
    public string Name { get; set; }
    public Guid CountryId { get; set; }
}