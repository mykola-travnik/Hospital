using Business.CreateDto;
using Business.Dto;
using Business.QueryDto;
using Business.Services;
using Business.UpdateDto;
using Domain.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace App.Controllers;

[ApiController]
[Route("[controller]")]
[AllowAnonymous]
public class
    RecordToDoctorController : AbstractController<RecordToDoctor, RecordToDoctorDto, RecordToDoctorCreateDto, RecordToDoctorUpdateDto, RecordToDoctorQueryDto>
{
    public RecordToDoctorController(IRecordToDoctorService RecordToDoctorService) : base(RecordToDoctorService)
    {
    }
}