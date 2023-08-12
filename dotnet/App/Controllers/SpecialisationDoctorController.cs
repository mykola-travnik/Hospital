using Business.Services;
using Data.QueryDto;
using Data.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace App.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SpecialisationDoctorController : AbstractController<SpecialisationDoctor, SpecialisationDoctorDto, SpecialisationDoctorCreateDto, SpecialisationDoctorUpdateDto, SpecialisationDoctorQueryDto>
    {
        public SpecialisationDoctorController(ISpecialisationDoctorService SpecialisationDoctorService) : base(SpecialisationDoctorService)
        {
        }

    }
}