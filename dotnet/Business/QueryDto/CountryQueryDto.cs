namespace Business.QueryDto;

public record CountryQueryDto : BaseQueryDto
{
    public string Name { get; set; }
}