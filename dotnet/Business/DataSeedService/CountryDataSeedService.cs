using Data.Repositories;
using Microsoft.VisualBasic;
using System;
using System.Data;

namespace Business.DataSeedService
{
    public class CountryDataSeedService : AbstractDataSeedService, IDataSeedService, ICountryDataSeedService
    {
        private readonly ICountryRepository repository;

        public static Country Country1 = new Country()
        {
            Id = Guid.Parse("D2A6B951-8FD7-46F6-A0ED-15B468F93D08"),
            Name = "Moldova",
            IsDeleted = false,
            CreationTimestamp = DateTime.Now.ToUniversalTime(),
            ModifiedTimestamp = DateTime.Now.ToUniversalTime(),
            DeletedTimestamp = null
        };
        public static Country Country2 = new Country()
        {
            Id = Guid.Parse("5A5A3707-46FD-4392-98A7-9FAF30D6C80C"),
            Name = "Ukraine",
            IsDeleted = false,
            CreationTimestamp = DateTime.Now.ToUniversalTime(),
            ModifiedTimestamp = DateTime.Now.ToUniversalTime(),
            DeletedTimestamp = null
        };

        public CountryDataSeedService(ICountryRepository repository)
        {
            this.repository = repository;
        }

        public override async Task DataSeedAsync()
        {
            await repository.SeedData(new List<Country> { Country1, Country2 });
        }
    }
}