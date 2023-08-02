using Domain;

public class Specialisation_Doctor : BaseEntity
{
    public List<Specialisation> Specialisation { get; set; }
    public List<Doctor> Doctor { get; set; }
    public DateOnly? Experience { get; set; }

}


