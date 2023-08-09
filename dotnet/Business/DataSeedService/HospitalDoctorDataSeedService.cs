using Data.Repositories;
using Microsoft.VisualBasic;
using System.Data;
using System.Diagnostics;

namespace Business.DataSeedService
{
    public class HospitalDoctorDataSeedService : IDataSeedService, IHospitalDoctorDataSeedService
    {
        private readonly IHospitalDoctorRepository repository;

        public static HospitalDoctor Hospital_Doctor0 = new HospitalDoctor()
        {
            Id = Guid.Parse("E957BC25-FDD7-4D90-8CBE-8537D67D5762"),
            IsDeleted = false,
            CreationTimestamp = DateTime.Now.ToUniversalTime(),
            ModifiedTimestamp = DateTime.Now.ToUniversalTime(),
            DeletedTimestamp = null,
            DoctorId = SpecialisationDoctorDataSeedService.Specialisation_Doctor0.DoctorId,
            SpecialisationId = SpecialisationDoctorDataSeedService.Specialisation_Doctor0.SpecialisationId,
            HospitalId = HospitalDataSeedService.Hospital0.Id,
            Price = 100
        };

        public static HospitalDoctor Hospital_Doctor1 = new HospitalDoctor()
        {
            Id = Guid.Parse("23722425-D3C3-4EFF-9A5C-09AE77DEC022"),
            IsDeleted = false,
            CreationTimestamp = DateTime.Now.ToUniversalTime(),
            ModifiedTimestamp = DateTime.Now.ToUniversalTime(),
            DeletedTimestamp = null,
            DoctorId = SpecialisationDoctorDataSeedService.Specialisation_Doctor1.DoctorId,
            SpecialisationId = SpecialisationDoctorDataSeedService.Specialisation_Doctor1.SpecialisationId,
            HospitalId = HospitalDataSeedService.Hospital1.Id,
            Price = 101
        };

        public static HospitalDoctor Hospital_Doctor2 = new HospitalDoctor()
        {
            Id = Guid.Parse("ADD16A50-A0C5-47C8-BAB1-564D0778B26A"),
            IsDeleted = false,
            CreationTimestamp = DateTime.Now.ToUniversalTime(),
            ModifiedTimestamp = DateTime.Now.ToUniversalTime(),
            DeletedTimestamp = null,
            DoctorId = SpecialisationDoctorDataSeedService.Specialisation_Doctor2.DoctorId,
            SpecialisationId = SpecialisationDoctorDataSeedService.Specialisation_Doctor2.SpecialisationId,
            HospitalId = HospitalDataSeedService.Hospital2.Id,
            Price = 102
        };

        public static HospitalDoctor Hospital_Doctor3 = new HospitalDoctor()
        {
            Id = Guid.Parse("B20495F5-6360-475B-B31B-BE696AD6F458"),
            IsDeleted = false,
            CreationTimestamp = DateTime.Now.ToUniversalTime(),
            ModifiedTimestamp = DateTime.Now.ToUniversalTime(),
            DeletedTimestamp = null,
            DoctorId = SpecialisationDoctorDataSeedService.Specialisation_Doctor3.DoctorId,
            SpecialisationId = SpecialisationDoctorDataSeedService.Specialisation_Doctor3.SpecialisationId,
            HospitalId = HospitalDataSeedService.Hospital3.Id,
            Price = 103
        };

        public static HospitalDoctor Hospital_Doctor4 = new HospitalDoctor()
        {
            Id = Guid.Parse("E920ED20-8730-4BA9-9244-8964F5DAEA20"),
            IsDeleted = false,
            CreationTimestamp = DateTime.Now.ToUniversalTime(),
            ModifiedTimestamp = DateTime.Now.ToUniversalTime(),
            DeletedTimestamp = null,
            DoctorId = SpecialisationDoctorDataSeedService.Specialisation_Doctor4.DoctorId,
            SpecialisationId = SpecialisationDoctorDataSeedService.Specialisation_Doctor4.SpecialisationId,
            HospitalId = HospitalDataSeedService.Hospital4.Id,
            Price = 104
        };


        public HospitalDoctorDataSeedService(IHospitalDoctorRepository repository)
        {
            this.repository = repository;
        }

        public async Task DataSeedAsync()
        {
            await repository.SeedData(new List<HospitalDoctor> { Hospital_Doctor0, Hospital_Doctor1, Hospital_Doctor2, Hospital_Doctor3, Hospital_Doctor4 });
        }
    }
}