using Data.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace App.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HospitalController : ControllerBase
    {
        private readonly ILogger<HospitalController> _logger;
        private readonly IHospitalRepository hospitalRepository;

        // Read Controller
        public HospitalController(ILogger<HospitalController> logger, IHospitalRepository hospitalRepository)
        {
            _logger = logger;
            this.hospitalRepository = hospitalRepository;
        }

        [HttpGet]
        public Hospital Get(Guid id)
        {
            return hospitalRepository.Get(id);
        }

        [HttpPost]
        public async Task<Hospital> Create(Hospital hospital)
        {
            return await hospitalRepository.CreateAsync(hospital);
        }

        [HttpPut]
        public async Task<Hospital> Update(Hospital hospital)
        {
            return await hospitalRepository.UpdateAsync(hospital);
        }

        [HttpDelete]
        public Task<bool> Delete(Guid id)
        {
            return hospitalRepository.DeleteAsync(id);
        }
    }
}