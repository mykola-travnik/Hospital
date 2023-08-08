using Domain;

namespace Data.Repositories
{
    public interface IHospital_DoctorRepository: IRepository<Hospital_Doctor, Hospital_DoctorDto, Hospital_DoctorCreateDto, Hospital_DoctorUpdateDto, BaseQueryDto> { }
}
