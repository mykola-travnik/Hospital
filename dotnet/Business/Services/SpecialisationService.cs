using AutoMapper;
using Business.CreateDto;
using Business.Dto;
using Business.QueryDto;
using Business.UpdateDto;
using Data.Repositories;
using Domain.Models;

namespace Business.Services;

public class SpecialisationService :
    BaseEntityService<Specialisation, SpecialisationDto, SpecialisationCreateDto, SpecialisationUpdateDto,
        SpecialisationQueryDto>, ISpecialisationService
{
    public SpecialisationService(ISpecialisationRepository repository, IMapper mapper) : base(repository, mapper)
    {
    }

    public new List<SpecialisationDto> QueryAsync(SpecialisationQueryDto query)
    {
        return Find(entity => entity.Name.ToLower().StartsWith(query.Name.ToLower()));
    }
}