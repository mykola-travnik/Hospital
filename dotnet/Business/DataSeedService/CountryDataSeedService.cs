using Data.Repositories;
using Microsoft.VisualBasic;
using System;
using System.Data;

namespace Business.DataSeedService
{
    public class CountryDataSeedService : IDataSeedService, ICountryDataSeedService
    {
        private readonly ICountryRepository repository;

        public static Country Country0 = new Country()
        {
            Id = Guid.Parse("D2A6B951-8FD7-46F6-A0ED-15B468F93D08"),
            Name = "Moldova",
            IsDeleted = false,
            CreationTimestamp = DateTime.Now.ToUniversalTime(),
            ModifiedTimestamp = DateTime.Now.ToUniversalTime(),
            DeletedTimestamp = null
        };
        public static Country Country1= new Country()
        {
            Id = Guid.Parse("5A5A3707-46FD-4392-98A7-9FAF30D6C80C"),
            Name = "Ukraine",
            IsDeleted = false,
            CreationTimestamp = DateTime.Now.ToUniversalTime(),
            ModifiedTimestamp = DateTime.Now.ToUniversalTime(),
            DeletedTimestamp = null
        };
        public static Country Country2 = new Country()
        {
            Id = Guid.Parse("AFC7D299-6504-4ABA-AFA4-176E3FE39B6F"),
            Name = "Romania",
            IsDeleted = false,
            CreationTimestamp = DateTime.Now.ToUniversalTime(),
            ModifiedTimestamp = DateTime.Now.ToUniversalTime(),
            DeletedTimestamp = null
        };
        public static Country Country3 = new Country()
        {
            Id = Guid.Parse("9788F948-50CE-4817-85CD-3B1D80737A76"),
            Name = "Bulgaria",
            IsDeleted = false,
            CreationTimestamp = DateTime.Now.ToUniversalTime(),
            ModifiedTimestamp = DateTime.Now.ToUniversalTime(),
            DeletedTimestamp = null
        };
        public static Country Country4 = new Country()
        {
            Id = Guid.Parse("75686537-6435-450D-85FF-EA844CB99797"),
            Name = "Turkey",
            IsDeleted = false,
            CreationTimestamp = DateTime.Now.ToUniversalTime(),
            ModifiedTimestamp = DateTime.Now.ToUniversalTime(),
            DeletedTimestamp = null
        };


        public CountryDataSeedService(ICountryRepository repository)
        {
            this.repository = repository;
        }

        public async Task DataSeedAsync()
        {
            //await repository.SeedData(new List<Country> { Country0, Country1, Country2, Country3, Country4 });
        }
    }
}