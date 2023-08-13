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
public class CityController : AbstractController<City, CityDto, CityCreateDto, CityUpdateDto, CityQueryDto>
{
    public CityController(ICityService cityService) : base(cityService)
    {
    }
}