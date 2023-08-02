using Data.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace App.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SpecialisationController : ControllerBase
    {
        private readonly ILogger<SpecialisationController> _logger;
        private readonly ISpecialisationRepository specialisationRepository;

        // Read Controller
        public SpecialisationController(ILogger<SpecialisationController> logger, ISpecialisationRepository specialisationRepository)
        {
            _logger = logger;
            this.specialisationRepository = specialisationRepository;
        }

        [HttpGet]
        public Specialisation Get(Guid id)
        {
            return specialisationRepository.Get(id);
        }

        [HttpPost]
        public async Task<Specialisation> Create(Specialisation specialisation)
        {
            return await specialisationRepository.CreateAsync(specialisation);
        }

        [HttpPut]
        public async Task<Specialisation> Update(Specialisation specialisation)
        {
            return await specialisationRepository.UpdateAsync(specialisation);
        }

        [HttpDelete]
        public Task<bool> Delete(Guid id)
        {
            return specialisationRepository.DeleteAsync(id);
        }
    }
}