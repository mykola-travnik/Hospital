using AutoMapper;
using Business.CreateDto;
using Business.Dto;
using Business.QueryDto;
using Business.UpdateDto;
using Data.Repositories;
using Domain.Models;

namespace Business.Services;

public class HospitalService :
    BaseEntityService<Hospital, HospitalDto, HospitalCreateDto, HospitalUpdateDto, HospitalQueryDto>, IHospitalService
{
    public HospitalService(IHospitalRepository repository, IMapper mapper) : base(repository, mapper)
    {
    }

    public new List<HospitalDto> QueryAsync(HospitalQueryDto query)
    {
        return Find(entity => entity.Name.ToLower().StartsWith(query.Name.ToLower()));
    }
}