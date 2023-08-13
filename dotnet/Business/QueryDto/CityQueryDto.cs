namespace Business.QueryDto;

public record CityQueryDto : BaseQueryDto
{
    public string Name { get; set; }
}