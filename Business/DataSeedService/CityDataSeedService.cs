using Data.Repositories;
using Microsoft.VisualBasic;
using System.Data;

namespace Business.DataSeedService
{
    public class CityDataSeedService : BaseDataSeedService, IDataSeedService, ICityDataSeedService
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
            Country = CountryDataSeedService.Country1,
        };
        public static City City2 = new City()
        {
            Id = Guid.Parse("5A5A3707-46FD-4392-91A7-9FAF30D6C80C"),
            Name = "Bender",
            IsDeleted = false,
            CreationTimestamp = DateTime.Now.ToUniversalTime(),
            ModifiedTimestamp = DateTime.Now.ToUniversalTime(),
            DeletedTimestamp = null,
            Country = CountryDataSeedService.Country1
        };

        public CityDataSeedService(ICityRepository repository)
        {
            this.repository = repository;
        }

        public override async Task DataSeedAsync()
        {
            await repository.SeedData(new List<City> { City1, City2 });
        }
    }
}