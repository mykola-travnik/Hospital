namespace Business.CreateDto;

public record RoleCreateDto : BaseCreateDto
{
    public string Name { get; set; }
    public string Description { get; set; }
}