using Data.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace App.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CityController : ControllerBase
    {
        private readonly ILogger<CityController> _logger;
        private readonly ICityRepository cityRepository;

        public CityController(ILogger<CityController> logger, ICityRepository cityRepository)
        {
            _logger = logger;
            this.cityRepository = cityRepository;
        }

        [HttpGet]
        public City Get(Guid id)
        {
            return cityRepository.Get(id);
        }
    }
}