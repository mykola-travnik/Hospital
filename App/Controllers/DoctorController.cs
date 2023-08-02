using Data.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace App.Controllers
{
    [ApiController]
    [Route("[controller]")]

    public class DoctorController : ControllerBase 
    {
        private readonly ILogger<DoctorController> _logger;
        private readonly IDoctorRepository doctorRepository;

        // Read Controller
        public DoctorController(ILogger<DoctorController> logger, IDoctorRepository doctorRepository)
        {
            _logger = logger;
            this.doctorRepository = doctorRepository;
        }

        [HttpGet]
        public Doctor Get(Guid id)
        {
            return doctorRepository.Get(id);
        }

        [HttpPost]
        public async Task<Doctor> Create(Doctor doctor)
        {
            return await doctorRepository.CreateAsync(doctor);
        }

        [HttpPut]
        public async Task<Doctor> Update(Doctor doctor)
        {
            return await doctorRepository.UpdateAsync(doctor);
        }

        [HttpDelete]
        public Task<bool> Delete(Guid id)
        {
            return doctorRepository.DeleteAsync(id);
        }
    }
}