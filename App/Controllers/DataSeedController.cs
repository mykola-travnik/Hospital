using Business;
using Business.DataSeedService;
using Data.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace App.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DataSeedController : ControllerBase
    {
        private readonly ICountryDataSeedService countryDataSeedService;
        private readonly ICityDataSeedService cityDataSeedService;

        public DataSeedController(ICountryDataSeedService countryDataSeedService, ICityDataSeedService cityDataSeedService)
        {
            this.countryDataSeedService = countryDataSeedService;
            this.cityDataSeedService = cityDataSeedService;
        }


        [HttpGet]
        public async Task DataSeed()
        {
            await countryDataSeedService.DataSeedAsync();
            await cityDataSeedService.DataSeedAsync();
        }
    }
}