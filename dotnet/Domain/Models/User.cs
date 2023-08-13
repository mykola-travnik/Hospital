namespace Domain.Models;

public class User: BaseEntity
{
    public string Name { get; set; }
    public string Password { get; set; }
    public List<Role> Roles { get; set; }
}