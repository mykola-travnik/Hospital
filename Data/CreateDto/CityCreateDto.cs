using Domain;

public class CityCreateDto : BaseCreateDto
{
    public string Name { get; set; }

    public Guid CountryId { get; set; }
}


