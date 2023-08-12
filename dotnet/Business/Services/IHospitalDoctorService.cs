using Data.QueryDto;

namespace Business.Services
{
    public interface IHospitalDoctorService: IBaseEntityService<HospitalDoctor, HospitalDoctorDto, HospitalDoctorCreateDto, HospitalDoctorUpdateDto, HospitalDoctorQueryDto> { }
}
