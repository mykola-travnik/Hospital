using Domain;

public class City: BaseEntity
{
    public string Name { get; set; }

    public List<Hospital> Hospitals { get; set; }
}


