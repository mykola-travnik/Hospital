namespace Domain.Models;

public class RecordToDoctor: BaseEntity
{
    public HospitalDoctor HospitalDoctor { get; set; }
    public User User { get; set; }
    public DateTime RecordTime { get; set; }
}