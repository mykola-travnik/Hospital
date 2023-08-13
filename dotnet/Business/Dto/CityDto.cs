using Domain.Models;

namespace Business.Dto;

public record CityDto : BaseDto
{
    public string Name { get; set; }
    public Country Country { get; set; }
}