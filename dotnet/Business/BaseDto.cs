namespace Business
{
    public record BaseDto
    {
        public Guid Id { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime CreationTimestamp { get; set; }
        public DateTime ModifiedTimestamp { get; set; }
        public DateTime? DeletedTimestamp { get; set; }
    }
}
