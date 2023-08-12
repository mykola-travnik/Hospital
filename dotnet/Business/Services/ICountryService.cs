using Data.QueryDto;

namespace Business.Services
{
    public interface ICountryService: IBaseEntityService<Country, CountryDto, CountryCreateDto, CountryUpdateDto, CountryQueryDto> { }
}
