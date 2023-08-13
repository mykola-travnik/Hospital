using AutoMapper;
using Business.CreateDto;
using Business.Dto;
using Business.QueryDto;
using Business.UpdateDto;
using Data.Repositories;
using Domain.Models;

namespace Business.Services;

public class CityService : BaseEntityService<City, CityDto, CityCreateDto, CityUpdateDto, CityQueryDto>, ICityService
{
    public CityService(ICityRepository repository, IMapper mapper) : base(repository, mapper)
    {
    }

    public new List<CityDto> QueryAsync(CityQueryDto query)
    {
        return Find(entity => entity.Name.ToLower().StartsWith(query.Name.ToLower()));
    }
}