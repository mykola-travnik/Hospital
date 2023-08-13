using Business.CreateDto;
using Business.Dto;
using Business.QueryDto;
using Business.UpdateDto;
using Domain.Models;

namespace Business.Services
{
    public interface ICountryService: IBaseEntityService<Country, CountryDto, CountryCreateDto, CountryUpdateDto, CountryQueryDto> { }
}
