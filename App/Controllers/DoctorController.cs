using Data.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace App.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DoctorController : AbstractController<Doctor, DoctorDto, DoctorCreateDto, DoctorUpdateDto>
    {
        public DoctorController(IDoctorRepository doctorRepository) : base(doctorRepository)
        {
        }
    }
}