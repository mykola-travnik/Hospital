using AutoMapper;
using Business.CreateDto;
using Business.Dto;
using Business.QueryDto;
using Business.UpdateDto;
using Data.Repositories;
using Domain.Models;

namespace Business.Services
{
    public class CountryService : BaseEntityService<Country, CountryDto, CountryCreateDto, CountryUpdateDto, CountryQueryDto>, ICountryService
    {
        public CountryService(ICountryRepository repository, IMapper mapper) : base(repository, mapper)
        {
        }

        public new List<CountryDto> QueryAsync(CountryQueryDto query)
        {
            return Find(entity => entity.Name.ToLower().StartsWith(query.Name.ToLower()));
        }
    }
}
