using Data.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace App.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HospitalController : AbstractController<Hospital, HospitalDto, HospitalCreateDto>
    {
        public HospitalController(IHospitalRepository hospitalRepository) : base(hospitalRepository)
        {
        }
    }
}