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
        private readonly IDoctorDataSeedService doctorDataSeedService;
        private readonly IHospitalDoctorDataSeedService hospital_DoctorDataSeedService;
        private readonly ISpecialisationDoctorDataSeedService specialisation_DoctorDataSeedService;

        public DataSeedController(
            ICountryDataSeedService countryDataSeedService, 
            ICityDataSeedService cityDataSeedService,
            IHospitalDataSeedService hospitalDataSeedService,
            ISpecialisationDataSeedService specialisationDataSeedService,
            IDoctorDataSeedService doctorDataSeedService,
            IHospitalDoctorDataSeedService hospital_DoctorDataSeedService,
            ISpecialisationDoctorDataSeedService specialisation_DoctorDataSeedService)
        {
            this.countryDataSeedService = countryDataSeedService;
            this.cityDataSeedService = cityDataSeedService;
            this.hospitalDataSeedService = hospitalDataSeedService;
            this.specialisationDataSeedService = specialisationDataSeedService;
            this.doctorDataSeedService = doctorDataSeedService;
            this.hospital_DoctorDataSeedService = hospital_DoctorDataSeedService;
            this.specialisation_DoctorDataSeedService = specialisation_DoctorDataSeedService;
        }


        [HttpGet]
        public async Task DataSeed()
        {
            await countryDataSeedService.DataSeedAsync();
            await cityDataSeedService.DataSeedAsync();
            await hospitalDataSeedService.DataSeedAsync();
            await specialisationDataSeedService.DataSeedAsync();
            await doctorDataSeedService.DataSeedAsync();
            await hospital_DoctorDataSeedService.DataSeedAsync();
            await specialisation_DoctorDataSeedService.DataSeedAsync();
        }
    }
}