using Data.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace App.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SpecialisationController : AbstractController<Specialisation, SpecialisationDto, SpecialisationCreateDto>
    {
        public SpecialisationController(ISpecialisationRepository specialisationRepository) : base(specialisationRepository)
        {
        }
    }
}