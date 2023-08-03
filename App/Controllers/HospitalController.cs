using Data.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace App.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HospitalController : AbstractController<Hospital, HospitalDto>
    {
        public HospitalController(IHospitalRepository hospitalRepository) : base(hospitalRepository)
        {
        }
    }
}