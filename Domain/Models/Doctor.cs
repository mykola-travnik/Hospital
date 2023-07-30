using Domain;

public class Doctor : BaseEntity
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public List<Specialisation> Specialisation { get; set; }
    public List<Hospital> Hospital { get; set; }
    public string Phone { get; set; }
    public string Photo { get; set; }
    public string Description { get; set; }
    public string FullDescription { get; set; }
    public DateOnly Birthday { get; set; }

}


