using AutoMapper;

namespace Data
{
    public class MapperConfig : Profile
    {
        public MapperConfig()
        {
            CreateMap<City, CityDto>().ReverseMap();
            CreateMap<Country, CountryDto>().ReverseMap();
            CreateMap<Doctor, DoctorDto>().ReverseMap();
            CreateMap<Hospital, HospitalDto>().ReverseMap();
            CreateMap<Specialisation, SpecialisationDto>().ReverseMap();

            CreateMap<City, CityCreateDto>().ReverseMap();
            CreateMap<Country, CountryCreateDto>().ReverseMap();
            CreateMap<Doctor, DoctorCreateDto>().ReverseMap();
            CreateMap<Hospital, HospitalCreateDto>().ReverseMap();
            CreateMap<Specialisation, SpecialisationCreateDto>().ReverseMap();

        }
    }
}
