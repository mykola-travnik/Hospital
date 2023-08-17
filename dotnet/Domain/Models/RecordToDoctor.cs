namespace Domain.Models;

public class RecordToDoctor: BaseEntity
{
    public virtual HospitalDoctor HospitalDoctor { get; set; }
    public virtual User User { get; set; }
    public DateTime RecordTime { get; set; }
}