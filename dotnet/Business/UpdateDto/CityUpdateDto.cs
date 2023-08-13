namespace Business.UpdateDto;

public record CityUpdateDto : BaseUpdateDto
{
    public string Name { get; set; }
    public Guid CountryId { get; set; }
}