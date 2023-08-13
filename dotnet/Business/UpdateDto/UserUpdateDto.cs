namespace Business.UpdateDto;

public record UserUpdateDto : BaseUpdateDto
{
    public string Name { get; set; }
    public string Password { get; set; }
    public List<Guid> Roles { get; set; }
}