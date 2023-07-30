using Domain;

public class Country : BaseEntity
{ 
    public string Name { get; set; }
    public List<City> City { get; set; }
}


