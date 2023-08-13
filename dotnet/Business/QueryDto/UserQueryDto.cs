namespace Business.QueryDto;

public record UserQueryDto : BaseQueryDto
{
    public string Name { get; set; }
}