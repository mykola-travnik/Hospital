namespace Business.UpdateDto;

public record RoleUpdateDto : BaseUpdateDto
{
    public string Name { get; set; }
    public string Description { get; set; }
}