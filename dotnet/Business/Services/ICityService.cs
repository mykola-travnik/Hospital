using Business.CreateDto;
using Business.Dto;
using Business.QueryDto;
using Business.UpdateDto;
using Domain.Models;

namespace Business.Services
{
    public interface ICityService : IBaseEntityService<City, CityDto, CityCreateDto, CityUpdateDto, CityQueryDto> { }
}
