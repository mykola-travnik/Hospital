﻿using Data.QueryDto;

namespace Data.Repositories
{
    public interface IHospitalRepository : IRepository<Hospital, HospitalDto, HospitalCreateDto, HospitalUpdateDto, HospitalQueryDto> { }
}
