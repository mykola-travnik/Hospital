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
public class DoctorController : AbstractController<Doctor, DoctorDto, DoctorCreateDto, DoctorUpdateDto, DoctorQueryDto>
{
    public DoctorController(IDoctorService doctorService) : base(doctorService)
    {
    }
}