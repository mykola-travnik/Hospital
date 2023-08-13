using Data.Repositories;
using Microsoft.VisualBasic;
using System.Data;
using Domain.Models;

namespace Business.DataSeedService
{
    public class DoctorDataSeedService : IDataSeedService, IDoctorDataSeedService
    {
        private readonly IDoctorRepository repository;

        public static Doctor Doctor0 = new Doctor()
        {
            Id = Guid.Parse("56B774F8-7D18-4DF9-8D27-401EA0B072DE"),
            IsDeleted = false,
            CreationTimestamp = DateTime.Now.ToUniversalTime(),
            ModifiedTimestamp = DateTime.Now.ToUniversalTime(),
            DeletedTimestamp = null,
            FirstName = "Александр",
            LastName = "Иванов",
            Birthday = DateOnly.Parse("1980-01-01"),
            Description = "Description",
            FullDescription = "FullDescription",
            Phone = "+373(777)77777",
            Photo = null
        };

        public static Doctor Doctor1 = new Doctor()
        {
            Id = Guid.Parse("5158C466-3929-4B3C-BC6C-8C3FB66938B5"),
            IsDeleted = false,
            CreationTimestamp = DateTime.Now.ToUniversalTime(),
            ModifiedTimestamp = DateTime.Now.ToUniversalTime(),
            DeletedTimestamp = null,
            FirstName = "Глеб",
            LastName = "Сотников",
            Birthday = DateOnly.Parse("1981-01-01"),
            Description = "Description",
            FullDescription = "FullDescription",
            Phone = "+373(777)77777",
            Photo = null
        };

        public static Doctor Doctor2 = new Doctor()
        {
            Id = Guid.Parse("EBA48ADC-262E-4122-AE10-229DC3B1F8DD"),
            IsDeleted = false,
            CreationTimestamp = DateTime.Now.ToUniversalTime(),
            ModifiedTimestamp = DateTime.Now.ToUniversalTime(),
            DeletedTimestamp = null,
            FirstName = "Елизавета",
            LastName = "Гаврилова",
            Birthday = DateOnly.Parse("1982-01-01"),
            Description = "Description",
            FullDescription = "FullDescription",
            Phone = "+373(777)77777",
            Photo = null
        };

        public static Doctor Doctor3 = new Doctor()
        {
            Id = Guid.Parse("87C075D1-F2A8-4F08-8361-2D25E6033ACD"),
            IsDeleted = false,
            CreationTimestamp = DateTime.Now.ToUniversalTime(),
            ModifiedTimestamp = DateTime.Now.ToUniversalTime(),
            DeletedTimestamp = null,
            FirstName = "София",
            LastName = "Григорьева",
            Birthday = DateOnly.Parse("1983-01-01"),
            Description = "Description",
            FullDescription = "FullDescription",
            Phone = "+373(777)77777",
            Photo = null
        };

        public static Doctor Doctor4 = new Doctor()
        {
            Id = Guid.Parse("93BECE1A-2999-4255-B834-0E2C3DBEA3E2"),
            IsDeleted = false,
            CreationTimestamp = DateTime.Now.ToUniversalTime(),
            ModifiedTimestamp = DateTime.Now.ToUniversalTime(),
            DeletedTimestamp = null,
            FirstName = "Михаил",
            LastName = "Наумов",
            Birthday = DateOnly.Parse("1984-01-01"),
            Description = "Description",
            FullDescription = "FullDescription",
            Phone = "+373(777)77777",
            Photo = null
        };

        public DoctorDataSeedService(IDoctorRepository repository)
        {
            this.repository = repository;
        }

        public async Task DataSeedAsync()
        {
            await repository.CreateOrUpdateRangeAsync(new List<Doctor> { Doctor0, Doctor1, Doctor2, Doctor3, Doctor4 });
        }
    }
}