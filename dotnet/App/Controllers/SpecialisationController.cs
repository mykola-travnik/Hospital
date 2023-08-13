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
    public class SpecialisationController : AbstractController<Specialisation, SpecialisationDto, SpecialisationCreateDto, SpecialisationUpdateDto, SpecialisationQueryDto>
    {
        public SpecialisationController(ISpecialisationService specialisationService) : base(specialisationService)
        {
        }
    }
}