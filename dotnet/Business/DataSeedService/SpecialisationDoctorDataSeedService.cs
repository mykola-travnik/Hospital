using Data.Repositories;
using Microsoft.VisualBasic;
using System.Data;
using Domain.Models;

namespace Business.DataSeedService
{
    public class SpecialisationDoctorDataSeedService : IDataSeedService, ISpecialisationDoctorDataSeedService
    {
        private readonly ISpecialisationDoctorRepository repository;

        public static SpecialisationDoctor Specialisation_Doctor0 = new SpecialisationDoctor()
        {
            Id = Guid.Parse("07B4E8C3-834B-4B06-9F07-72BB13770E1E"),
            IsDeleted = false,
            CreationTimestamp = DateTime.Now.ToUniversalTime(),
            ModifiedTimestamp = DateTime.Now.ToUniversalTime(),
            DeletedTimestamp = null,
            DoctorId = DoctorDataSeedService.Doctor0.Id,
            SpecialisationId = SpecialisationDataSeedService.Specialisation0.Id,
            Experience = DateOnly.Parse("2000-01-01")
        };

        public static SpecialisationDoctor Specialisation_Doctor1 = new SpecialisationDoctor()
        {
            Id = Guid.Parse("40958322-32F3-4E84-9368-8CB5B128912F"),
            IsDeleted = false,
            CreationTimestamp = DateTime.Now.ToUniversalTime(),
            ModifiedTimestamp = DateTime.Now.ToUniversalTime(),
            DeletedTimestamp = null,
            DoctorId = DoctorDataSeedService.Doctor1.Id,
            SpecialisationId = SpecialisationDataSeedService.Specialisation1.Id,
            Experience = DateOnly.Parse("2001-01-01")
        };

        public static SpecialisationDoctor Specialisation_Doctor2 = new SpecialisationDoctor()
        {
            Id = Guid.Parse("DD6A9DD9-1EC1-4850-BCBC-02E85856F422"),
            IsDeleted = false,
            CreationTimestamp = DateTime.Now.ToUniversalTime(),
            ModifiedTimestamp = DateTime.Now.ToUniversalTime(),
            DeletedTimestamp = null,
            DoctorId = DoctorDataSeedService.Doctor2.Id,
            SpecialisationId = SpecialisationDataSeedService.Specialisation2.Id,
            Experience = DateOnly.Parse("2002-01-01")
        };

        public static SpecialisationDoctor Specialisation_Doctor3 = new SpecialisationDoctor()
        {
            Id = Guid.Parse("1213C2AD-67D3-45E3-8FAB-405FDE966C75"),
            IsDeleted = false,
            CreationTimestamp = DateTime.Now.ToUniversalTime(),
            ModifiedTimestamp = DateTime.Now.ToUniversalTime(),
            DeletedTimestamp = null,
            DoctorId = DoctorDataSeedService.Doctor3.Id,
            SpecialisationId = SpecialisationDataSeedService.Specialisation3.Id,
            Experience = DateOnly.Parse("2003-01-01")
        };

        public static SpecialisationDoctor Specialisation_Doctor4 = new SpecialisationDoctor()
        {
            Id = Guid.Parse("337D815D-038F-4897-A9A0-A9BD9BBCC0D8"),
            IsDeleted = false,
            CreationTimestamp = DateTime.Now.ToUniversalTime(),
            ModifiedTimestamp = DateTime.Now.ToUniversalTime(),
            DeletedTimestamp = null,
            DoctorId = DoctorDataSeedService.Doctor4.Id,
            SpecialisationId = SpecialisationDataSeedService.Specialisation4.Id,
            Experience = DateOnly.Parse("2004-01-01")
        };

        public SpecialisationDoctorDataSeedService(ISpecialisationDoctorRepository repository)
        {
            this.repository = repository;
        }

        public async Task DataSeedAsync()
        {
            await repository.CreateOrUpdateRangeAsync(new List<SpecialisationDoctor> { Specialisation_Doctor0, Specialisation_Doctor1, Specialisation_Doctor2, Specialisation_Doctor3, Specialisation_Doctor4 });
        }
    }
}