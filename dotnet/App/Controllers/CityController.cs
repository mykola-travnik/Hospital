using Business.Services;
using Data.QueryDto;
using Data.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace App.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CityController : AbstractController<City, CityDto, CityCreateDto, CityUpdateDto, CityQueryDto>
    {
        public CityController(ICityService cityService) : base(cityService)
        {
        }
    }
}