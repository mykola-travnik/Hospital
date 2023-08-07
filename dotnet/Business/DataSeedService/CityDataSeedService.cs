using Data.Repositories;
using Microsoft.VisualBasic;
using System.Data;

namespace Business.DataSeedService
{
    public class CityDataSeedService : AbstractDataSeedService, IDataSeedService, ICityDataSeedService
    {
        private readonly ICityRepository repository;

        public static City City1 = new City()
        {
            Id = Guid.Parse("D2A6B951-8FD7-46F6-A0ED-15B465F93D08"),
            Name = "Tiraspol",
            IsDeleted = false,
            CreationTimestamp = DateTime.Now.ToUniversalTime(),
            ModifiedTimestamp = DateTime.Now.ToUniversalTime(),
            DeletedTimestamp = null,
            CountryId = CountryDataSeedService.Country1.Id,
        };

        public static City City2 = new City()
        {
            Id = Guid.Parse("5A5A3707-46FD-4392-91A7-9FAF30D6C80C"),
            Name = "Bender",
            IsDeleted = false,
            CreationTimestamp = DateTime.Now.ToUniversalTime(),
            ModifiedTimestamp = DateTime.Now.ToUniversalTime(),
            DeletedTimestamp = null,
            CountryId = CountryDataSeedService.Country1.Id,
        };

        public static City City3 = new City()
        {
            Id = Guid.Parse("E352CC07-23A0-4ACE-A24E-2FAFB51DCA09"),
            Name = "Dubossary",
            IsDeleted = false,
            CreationTimestamp = DateTime.Now.ToUniversalTime(),
            ModifiedTimestamp = DateTime.Now.ToUniversalTime(),
            DeletedTimestamp = null,
            CountryId = CountryDataSeedService.Country1.Id,
        };

        public static City City4 = new City()
        {
            Id = Guid.Parse("F02E19E0-907F-48FC-B072-D1AA0474D63A"),
            Name = "Grigoriopol",
            IsDeleted = false,
            CreationTimestamp = DateTime.Now.ToUniversalTime(),
            ModifiedTimestamp = DateTime.Now.ToUniversalTime(),
            DeletedTimestamp = null,
            CountryId = CountryDataSeedService.Country1.Id,
        };

        public static City City5 = new City()
        {
            Id = Guid.Parse("BC383983-537F-4648-8E86-DF95C2578981"),
            Name = "Ribnita",
            IsDeleted = false,
            CreationTimestamp = DateTime.Now.ToUniversalTime(),
            ModifiedTimestamp = DateTime.Now.ToUniversalTime(),
            DeletedTimestamp = null,
            CountryId = CountryDataSeedService.Country1.Id,
        };

        public CityDataSeedService(ICityRepository repository)
        {
            this.repository = repository;
        }

        public override async Task DataSeedAsync()
        {
            await repository.SeedData(new List<City> { City1, City2, City3, City4, City5 });
        }
    }
}