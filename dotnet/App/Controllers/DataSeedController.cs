using Business.DataSeedService;
using Microsoft.AspNetCore.Mvc;

namespace App.Controllers;

[ApiController]
[Route("[controller]")]
public class DataSeedController : ControllerBase
{
    private readonly ICityDataSeedService cityDataSeedService;
    private readonly ICountryDataSeedService countryDataSeedService;
    private readonly IDoctorDataSeedService doctorDataSeedService;
    private readonly IHospitalDataSeedService hospitalDataSeedService;
    private readonly IHospitalDoctorDataSeedService hospitalDoctorDataSeedService;
    private readonly IRoleDataSeedService roleDataSeedService;
    private readonly ISpecialisationDataSeedService specialisationDataSeedService;
    private readonly ISpecialisationDoctorDataSeedService specialisationDoctorDataSeedService;
    private readonly IUserDataSeedService userDataSeedService;

    public DataSeedController(
        ICountryDataSeedService countryDataSeedService,
        ICityDataSeedService cityDataSeedService,
        IHospitalDataSeedService hospitalDataSeedService,
        ISpecialisationDataSeedService specialisationDataSeedService,
        IDoctorDataSeedService doctorDataSeedService,
        IHospitalDoctorDataSeedService hospital_DoctorDataSeedService,
        ISpecialisationDoctorDataSeedService specialisation_DoctorDataSeedService,
        IRoleDataSeedService roleDataSeedService,
        IUserDataSeedService userDataSeedService)
    {
        this.countryDataSeedService = countryDataSeedService;
        this.cityDataSeedService = cityDataSeedService;
        this.hospitalDataSeedService = hospitalDataSeedService;
        this.specialisationDataSeedService = specialisationDataSeedService;
        this.doctorDataSeedService = doctorDataSeedService;
        hospitalDoctorDataSeedService = hospital_DoctorDataSeedService;
        specialisationDoctorDataSeedService = specialisation_DoctorDataSeedService;
        this.roleDataSeedService = roleDataSeedService;
        this.userDataSeedService = userDataSeedService;
    }


    [HttpGet]
    public async Task DataSeed()
    {
        await countryDataSeedService.DataSeedAsync();
        await cityDataSeedService.DataSeedAsync();
        await hospitalDataSeedService.DataSeedAsync();
        await specialisationDataSeedService.DataSeedAsync();
        await doctorDataSeedService.DataSeedAsync();
        await hospitalDoctorDataSeedService.DataSeedAsync();
        await specialisationDoctorDataSeedService.DataSeedAsync();
        await roleDataSeedService.DataSeedAsync();
        await userDataSeedService.DataSeedAsync();
    }
}