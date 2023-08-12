using Domain;

public class UserDto : BaseDto
{
    public string Name { get; set; }
    public string Password { get; set; }
    public List<RoleDto> Roles { get; set; }
}


