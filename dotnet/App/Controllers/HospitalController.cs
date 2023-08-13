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
public class HospitalController : AbstractController<Hospital, HospitalDto, HospitalCreateDto, HospitalUpdateDto,
    HospitalQueryDto>
{
    public HospitalController(IHospitalService hospitalService) : base(hospitalService)
    {
    }
}