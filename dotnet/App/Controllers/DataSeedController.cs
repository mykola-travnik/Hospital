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
        private readonly IHospitalDataSeedService hospitalDataSeedService;
        private readonly ISpecialisationDataSeedService specialisationDataSeedService;

        public DataSeedController(
            ICountryDataSeedService countryDataSeedService, 
            ICityDataSeedService cityDataSeedService,
            IHospitalDataSeedService hospitalDataSeedService,
            ISpecialisationDataSeedService specialisationDataSeedService)
        {
            this.countryDataSeedService = countryDataSeedService;
            this.cityDataSeedService = cityDataSeedService;
            this.hospitalDataSeedService = hospitalDataSeedService;
            this.specialisationDataSeedService = specialisationDataSeedService;

        }


        [HttpGet]
        public async Task DataSeed()
        {
            await countryDataSeedService.DataSeedAsync();
            await cityDataSeedService.DataSeedAsync();
            await hospitalDataSeedService.DataSeedAsync();
            await specialisationDataSeedService.DataSeedAsync();
        }
    }
}