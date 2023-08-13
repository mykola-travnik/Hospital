namespace Business.QueryDto
{
    public record DoctorQueryDto : BaseQueryDto
    {
        public string FullName { get; set; }
    }
}
