using Data.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace App.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CityController : AbstractController<City, CityDto>
    {
        public CityController(ICityRepository cityRepository): base(cityRepository)
        {
        }
    }
}