namespace Business.UpdateDto;

public record CountryUpdateDto : BaseUpdateDto
{ 
    public string Name { get; set; }
}