using Domain.Models;

namespace Business.Dto;

public record HospitalDto : BaseDto
{
    public string Name { get; set; }
    public string? Address { get; set; }
    public string? Phone { get; set; }
    public string? Photo { get; set; }
    public City City { get; set; }
}