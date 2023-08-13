namespace Business.Dto;

public record UserDto : BaseDto
{
    public string Name { get; set; }
    public List<RoleDto> Roles { get; set; }
}