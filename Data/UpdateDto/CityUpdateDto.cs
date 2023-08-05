using Domain;

public class CityUpdateDto : BaseUpdateDto
{
    public string Name { get; set; }

    public Guid CountryId { get; set; }
}


