using Data.QueryDto;

namespace Business.Services
{
    public interface IHospitalService: IBaseEntityService<Hospital, HospitalDto, HospitalCreateDto, HospitalUpdateDto, HospitalQueryDto> { }
}
