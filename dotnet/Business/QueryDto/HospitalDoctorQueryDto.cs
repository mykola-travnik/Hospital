namespace Business.QueryDto;

public record HospitalDoctorQueryDto : BaseQueryDto
{
    public double Price { get; set; }
}