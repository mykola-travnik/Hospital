using AutoMapper;
using Business.CreateDto;
using Business.Dto;
using Business.UpdateDto;
using Domain.Models;

namespace Business;

public class MapperConfig : Profile
{
    public MapperConfig()
    {
        CreateMap<City, CityDto>().ReverseMap();
        CreateMap<Country, CountryDto>().ReverseMap();
        CreateMap<Doctor, DoctorDto>().ReverseMap();
        CreateMap<Hospital, HospitalDto>().ReverseMap();
        CreateMap<Specialisation, SpecialisationDto>().ReverseMap();
        CreateMap<HospitalDoctor, HospitalDoctorDto>().ReverseMap();
        CreateMap<SpecialisationDoctor, SpecialisationDoctorDto>().ReverseMap();
        CreateMap<RecordToDoctor, RecordToDoctorDto>().ReverseMap();
        CreateMap<Role, RoleDto>().ReverseMap();
        CreateMap<User, UserDto>().ReverseMap();

        CreateMap<CityCreateDto, City>();
        CreateMap<CountryCreateDto, Country>();
        CreateMap<DoctorCreateDto, Doctor>();
        CreateMap<HospitalCreateDto, Hospital>();
        CreateMap<SpecialisationCreateDto, Specialisation>();
        CreateMap<HospitalDoctorCreateDto, HospitalDoctor>();
        CreateMap<SpecialisationDoctorCreateDto, SpecialisationDoctor>();
        CreateMap<RecordToDoctorCreateDto, RecordToDoctor>();
        CreateMap<RoleCreateDto, Role>();
        CreateMap<UserCreateDto, User>().ForMember(scr => scr.Roles, options => options.Ignore());

        CreateMap<CityUpdateDto, City>();
        CreateMap<CountryUpdateDto, Country>();
        CreateMap<DoctorUpdateDto, Doctor>();
        CreateMap<HospitalUpdateDto, Hospital>();
        CreateMap<SpecialisationUpdateDto, Specialisation>();
        CreateMap<HospitalDoctorUpdateDto, HospitalDoctor>();
        CreateMap<SpecialisationDoctorUpdateDto, SpecialisationDoctor>();
        CreateMap<RecordToDoctorUpdateDto, RecordToDoctor>();
        CreateMap<RoleUpdateDto, Role>();
        CreateMap<UserUpdateDto, User>().ForMember(scr => scr.Roles, options => options.Ignore());
        ;
    }
}