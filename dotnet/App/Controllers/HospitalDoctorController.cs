using Business.CreateDto;
using Business.Dto;
using Business.QueryDto;
using Business.Services;
using Business.UpdateDto;
using Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace App.Controllers;

[ApiController]
[Route("[controller]")]
public class HospitalDoctorController : AbstractController<HospitalDoctor, HospitalDoctorDto, HospitalDoctorCreateDto,
    HospitalDoctorUpdateDto, HospitalDoctorQueryDto>
{
    public HospitalDoctorController(IHospitalDoctorService hospitalDoctorService) : base(hospitalDoctorService)
    {
    }
}