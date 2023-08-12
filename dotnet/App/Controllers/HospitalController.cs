﻿using Business.Services;
using Data.QueryDto;
using Data.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace App.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HospitalController : AbstractController<Hospital, HospitalDto, HospitalCreateDto, HospitalUpdateDto, HospitalQueryDto>
    {
        public HospitalController(IHospitalService hospitalService) : base(hospitalService)
        {
        }
    }
}