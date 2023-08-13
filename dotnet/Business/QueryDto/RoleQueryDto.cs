namespace Business.QueryDto;

public record RoleQueryDto : BaseQueryDto
{
    public string Name { get; set; }
    public string Description { get; set; }
}