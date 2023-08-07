using Data.Repositories;
using Microsoft.VisualBasic;
using System.Data;

namespace Business.DataSeedService
{
    public class HospitalDataSeedService : AbstractDataSeedService, IDataSeedService, IHospitalDataSeedService
    {
        private readonly IHospitalRepository repository;

        public static Hospital Hospital1 = new Hospital()
        {
            Id = Guid.Parse("F9DB7886-25C0-4850-90B4-A6B7E7365D8A"),
            Name = "Medin",
            IsDeleted = false,
            CreationTimestamp = DateTime.Now.ToUniversalTime(),
            ModifiedTimestamp = DateTime.Now.ToUniversalTime(),
            DeletedTimestamp = null,
            CityId = CityDataSeedService.City1.Id,
            Address = "Strada Karl Liebknecht 1/2, Tiraspol",
            Phone = "+373(533)61818",
            Photo = ""

        };

        public static Hospital Hospital2 = new Hospital()
        {
            Id = Guid.Parse("8FEA5F3B-A05D-4F66-9CBF-1520774705DF"),
            Name = "ТираМед",
            IsDeleted = false,
            CreationTimestamp = DateTime.Now.ToUniversalTime(),
            ModifiedTimestamp = DateTime.Now.ToUniversalTime(),
            DeletedTimestamp = null,
            CityId = CityDataSeedService.City1.Id,
            Address = "Strada 25 Octombrie 75, Tiraspol",
            Phone = "+373(533)89898",
            Photo = ""
        };

        public static Hospital Hospital3 = new Hospital()
        {
            Id = Guid.Parse("1358B2EA-9486-496B-B5E9-11EDF71F2EEE"),
            Name = "Святая Надежда",
            IsDeleted = false,
            CreationTimestamp = DateTime.Now.ToUniversalTime(),
            ModifiedTimestamp = DateTime.Now.ToUniversalTime(),
            DeletedTimestamp = null,
            CityId = CityDataSeedService.City1.Id,
            Address = "Strada Odessa 20, Tiraspol",
            Phone = "+373(533)66110",
            Photo = ""
        };

        public static Hospital Hospital4 = new Hospital()
        {
            Id = Guid.Parse("C30B3528-A425-465F-A258-18BE0DED885E"),
            Name = "Физиотерапевтическая поликлиника\r\n",
            IsDeleted = false,
            CreationTimestamp = DateTime.Now.ToUniversalTime(),
            ModifiedTimestamp = DateTime.Now.ToUniversalTime(),
            DeletedTimestamp = null,
            CityId = CityDataSeedService.City1.Id,
            Address = "Strada Karl Marx 1, Tiraspol",
            Phone = "+373(533)93415",
            Photo = ""
        };

        public static Hospital Hospital5 = new Hospital()
        {
            Id = Guid.Parse("B8FD991E-218D-4C77-A1D4-A14E65B52895"),
            Name = "Республиканская клиническая больница",
            IsDeleted = false,
            CreationTimestamp = DateTime.Now.ToUniversalTime(),
            ModifiedTimestamp = DateTime.Now.ToUniversalTime(),
            DeletedTimestamp = null,
            CityId = CityDataSeedService.City1.Id,
            Address = "Strada Păcii 33, Tiraspol",
            Phone = "+373(533)22962",
            Photo = ""
        };

        public HospitalDataSeedService(IHospitalRepository repository)
        {
            this.repository = repository;
        }

        public override async Task DataSeedAsync()
        {
            await repository.SeedData(new List<Hospital> { Hospital1, Hospital2, Hospital3, Hospital4, Hospital5 });
        }
    }
}