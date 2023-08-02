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

        // Read Controller
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

        [HttpPost]
        public async Task<City> Create(City city)
        {
            return await cityRepository.CreateAsync(city);
        }

        [HttpPut]
        public async Task<City> Update(City city)
        {
            return await cityRepository.UpdateAsync(city);
        }

        [HttpDelete]
        public Task<bool> Delete(Guid id)
        {
            return cityRepository.DeleteAsync(id);
        }
    }
}