namespace Business.Dto;

public record RoleDto : BaseDto
{
    public string Name { get; set; }
    public string Description { get; set; }
}