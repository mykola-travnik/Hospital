using Business.CreateDto;
using Business.Dto;
using Business.QueryDto;
using Business.Services;
using Business.UpdateDto;
using Data.Repositories;
using Domain.Models;
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