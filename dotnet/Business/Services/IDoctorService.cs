using Business.CreateDto;
using Business.Dto;
using Business.QueryDto;
using Business.UpdateDto;
using Domain.Models;

namespace Business.Services
{
    public interface IDoctorService: IBaseEntityService<Doctor, DoctorDto, DoctorCreateDto, DoctorUpdateDto, DoctorQueryDto> { }
}
