using Domain;

public class UserDto : BaseDto
{
    public string Name { get; set; }
    public List<RoleDto> Roles { get; set; }
}


