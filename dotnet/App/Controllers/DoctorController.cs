using Business.Services;
using Data.QueryDto;
using Data.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace App.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DoctorController : AbstractController<Doctor, DoctorDto, DoctorCreateDto, DoctorUpdateDto, DoctorQueryDto>
    {
        public DoctorController(IDoctorService doctorService) : base(doctorService)
        {
        }
    }
}