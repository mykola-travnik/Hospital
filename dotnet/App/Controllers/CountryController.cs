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
[AdminAuthorize]
public class
    CountryController : AbstractController<Country, CountryDto, CountryCreateDto, CountryUpdateDto, CountryQueryDto>
{
    public CountryController(ICountryService countryService) : base(countryService)
    {
    }
}