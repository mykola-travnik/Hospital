using Business.Services;
using Data.QueryDto;
using Data.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace App.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SpecialisationController : AbstractController<Specialisation, SpecialisationDto, SpecialisationCreateDto, SpecialisationUpdateDto, SpecialisationQueryDto>
    {
        public SpecialisationController(ISpecialisationService specialisationService) : base(specialisationService)
        {
        }
    }
}