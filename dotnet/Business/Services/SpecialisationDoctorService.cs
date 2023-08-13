using AutoMapper;
using Business.CreateDto;
using Business.Dto;
using Business.QueryDto;
using Business.UpdateDto;
using Data.Repositories;
using Domain.Models;

namespace Business.Services
{
    public class SpecialisationDoctorService : BaseEntityService<SpecialisationDoctor, SpecialisationDoctorDto, SpecialisationDoctorCreateDto, SpecialisationDoctorUpdateDto, SpecialisationDoctorQueryDto>, ISpecialisationDoctorService
    {
        public SpecialisationDoctorService(ISpecialisationDoctorRepository repository, IMapper mapper) : base(repository, mapper)
        {
        }

        public new List<SpecialisationDoctorDto> QueryAsync(SpecialisationDoctorQueryDto query)
        {
            if (query.Experience == null)
                return Find(entity => true);

            return Find(entity => entity.Experience == query.Experience);
        }
    }
}
