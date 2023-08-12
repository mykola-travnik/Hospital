using AutoMapper;
using Data.QueryDto;
using Data.Repositories;

namespace Business.Services
{
    public class HospitalService : BaseEntityService<Hospital, HospitalDto, HospitalCreateDto, HospitalUpdateDto, HospitalQueryDto>, IHospitalService
    {
        public HospitalService(IHospitalRepository repository, IMapper mapper) : base(repository, mapper)
        {
        }

        public new List<HospitalDto> QueryAsync(HospitalQueryDto query)
        {
            return Find(entity => entity.Name.ToLower().StartsWith(query.Name.ToLower()));
        }
    }
}
