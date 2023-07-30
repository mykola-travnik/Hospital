using Business;
using Data.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Hospital.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

        private readonly ILogger<WeatherForecastController> _logger;
        private readonly ICityRepository cityRepository;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, ICityRepository cityRepository)
        {
            _logger = logger;
            this.cityRepository = cityRepository;
        }

        [HttpGet]
        public IEnumerable<WeatherForecast> Get()
        {
            var data = Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();

            data.First().Summary = cityRepository.Get(Guid.Parse("E66EF5DA-8B9D-4929-9628-F8A98CF27E3B")).Name;

            return data;
        }
    }
}