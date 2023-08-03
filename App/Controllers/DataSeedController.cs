using Business;
using Data.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace App.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DataSeedController : ControllerBase
    {
        private readonly ICountryDataSeedService countryDataSeedService;

        public DataSeedController(ICountryDataSeedService countryDataSeedService)
        {
            this.countryDataSeedService = countryDataSeedService;
        }


        [HttpGet]
        public Task DataSeed()
        {
            countryDataSeedService.DataSeedAsync();

            return Task.FromResult(0);
        }
    }
}