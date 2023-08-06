using Data.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace App.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CountryController : AbstractController<Country, CountryDto, CountryCreateDto, CountryUpdateDto>
    {
        public CountryController(ICountryRepository countryRepository) : base(countryRepository)
        {
        }
    }
}