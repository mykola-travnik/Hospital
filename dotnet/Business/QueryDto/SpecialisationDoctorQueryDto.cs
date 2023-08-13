namespace Business.QueryDto
{
    public record SpecialisationDoctorQueryDto : BaseQueryDto
    {
        public DateOnly Experience { get; set; }
    }
}
