using Domain.Models;

namespace Business.Dto;

public record SpecialisationDoctorDto : BaseDto
{
    public Doctor Doctor { get; set; }
    public Specialisation Specialisation { get; set; }
    public DateOnly? Experience { get; set; }
}