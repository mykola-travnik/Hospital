﻿using AutoMapper;
using Infrastructure.Contexts;

namespace Data.Repositories
{
    public class CityRepository : AbstractRepository<City, CityDto, CityCreateDto>, ICityRepository
    {
        public CityRepository(MainContext context, IMapper mapper) : base(context, mapper)
        {
        }
    }
}
