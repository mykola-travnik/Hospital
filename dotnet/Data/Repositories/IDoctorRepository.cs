﻿using Data.QueryDto;

namespace Data.Repositories
{
    public interface IDoctorRepository : IRepository<Doctor, DoctorDto, DoctorCreateDto, DoctorUpdateDto, DoctorQueryDto> { }
}
