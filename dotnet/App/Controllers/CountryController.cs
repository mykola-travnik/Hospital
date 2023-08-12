using Business.Services;
using Data.QueryDto;
using Data.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace App.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CountryController : AbstractController<Country, CountryDto, CountryCreateDto, CountryUpdateDto, CountryQueryDto>
    {
        public CountryController(ICountryService countryService) : base(countryService)
        {
        }

    }
}