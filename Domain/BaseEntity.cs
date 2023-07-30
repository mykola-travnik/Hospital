namespace Domain
{
    public class BaseEntity
    {
        public Guid Id { get; set; }

        public bool IsDeleted { get; set; }

        public string CreationTimestamp { get; set; }

        public string ModifiedTimestamp { get; set; }

        public string DeletedTimestamp { get; set; }
    }
}
