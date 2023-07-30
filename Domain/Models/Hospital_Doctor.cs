using Domain;

public class Hospital_Doctor : BaseEntity
{
    public List<Hospital> Hospital { get; set; }
    public List<Doctor> Doctor { get; set; }
    public double Price { get; set; }

}


