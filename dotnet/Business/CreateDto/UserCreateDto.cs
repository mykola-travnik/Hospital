namespace Business.CreateDto;

public record UserCreateDto : BaseCreateDto
{
    public string Name { get; set; }
    public string Password { get; set; }
    public List<Guid> Roles { get; set; }
}