using Data.QueryDto;
using Data.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace App.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HospitalDoctorController : AbstractController<HospitalDoctor, HospitalDoctorDto, HospitalDoctorCreateDto, HospitalDoctorUpdateDto, HospitalDoctorQueryDto>
    {
        public HospitalDoctorController(IHospitalDoctorRepository hospitalDoctorRepository) : base(hospitalDoctorRepository)
        {
        }
    }
}