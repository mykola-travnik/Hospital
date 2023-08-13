using Business.CreateDto;
using Business.Dto;
using Business.QueryDto;
using Business.UpdateDto;
using Domain.Models;

namespace Business.Services
{
    public interface IHospitalService: IBaseEntityService<Hospital, HospitalDto, HospitalCreateDto, HospitalUpdateDto, HospitalQueryDto> { }
}
