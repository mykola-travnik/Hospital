using AutoMapper;
using Business.CreateDto;
using Business.Dto;
using Business.QueryDto;
using Business.UpdateDto;
using Data.Repositories;
using Domain.Models;

namespace Business.Services;

public class RecordToDoctorService : BaseEntityService<RecordToDoctor, RecordToDoctorDto, RecordToDoctorCreateDto, RecordToDoctorUpdateDto, RecordToDoctorQueryDto>, IRecordToDoctorService
{
    private readonly IRecordToDoctorRepository recordToDoctorRepository;
    private readonly IUserRepository userRepository;
    private readonly IHospitalDoctorRepository hospitalDoctorRepository;
    private readonly IMapper mapper;

    public RecordToDoctorService(IRecordToDoctorRepository recordToDoctorRepository, IUserRepository userRepository, IHospitalDoctorRepository hospitalDoctorRepository, IMapper mapper) : base(recordToDoctorRepository, mapper)
    {
        this.recordToDoctorRepository = recordToDoctorRepository;
        this.userRepository = userRepository;
        this.hospitalDoctorRepository = hospitalDoctorRepository;
        this.mapper = mapper;
    }
    public new async Task<RecordToDoctorDto> CreateAsync(RecordToDoctorCreateDto dto)
    {
        var user = userRepository.Get(dto.UserId);
        var hopitalDoctor = hospitalDoctorRepository.Get(dto.HospitalDoctorId);

        var entity = new RecordToDoctor()
        {
            User = user,
            HospitalDoctor = hopitalDoctor,
            RecordTime = dto.RecordTime,
        };

        await recordToDoctorRepository.CreateAsync(entity);
        return mapper.Map<RecordToDoctorDto>(entity);
    }

    public new List<RecordToDoctorDto> QueryAsync(RecordToDoctorQueryDto query)
    {
        return Find(entity => true);
    }
}