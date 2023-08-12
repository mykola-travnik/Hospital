using Data.QueryDto;

namespace Business.Services
{
    public interface IDoctorService: IBaseEntityService<Doctor, DoctorDto, DoctorCreateDto, DoctorUpdateDto, DoctorQueryDto> { }
}
