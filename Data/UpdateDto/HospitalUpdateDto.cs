using Domain;

public class HospitalUpdateDto : BaseUpdateDto
{
    public string Name { get; set; }
    public string? Address { get; set; }
    public string? Phone { get; set; }
    public string? Photo { get; set; }

    public Guid CityId{ get; set; }
}