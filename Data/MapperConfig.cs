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

            CreateMap<City, CityUpdateDto>().ReverseMap();
            CreateMap<Country, CountryUpdateDto>().ReverseMap();
            CreateMap<Doctor, DoctorUpdateDto>().ReverseMap();
            CreateMap<Hospital, HospitalUpdateDto>().ReverseMap();
            CreateMap<Specialisation, SpecialisationUpdateDto>().ReverseMap();

        }
    }
}
