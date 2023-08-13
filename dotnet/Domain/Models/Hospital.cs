namespace Domain.Models;

public class Hospital : BaseEntity
{
    public string Name { get; set; }
    public string? Address { get; set; }
    public string? Phone { get; set; }
    public string? Photo { get; set; }
    public Guid CityId { get; set; }
    public City City { get; set; }
}