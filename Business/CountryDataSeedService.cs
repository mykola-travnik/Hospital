using Data.Repositories;

namespace Business
{
    public class CountryDataSeedService : BaseDataSeedService, IDataSeedService, ICountryDataSeedService
    {
        private readonly ICountryRepository repository;

        public CountryDataSeedService(ICountryRepository repository)
        {
            this.repository = repository;
        }

        public override async Task DataSeedAsync()
        {
            var country1 = new Country() { Name = "Moldova" };
            var country2 = new Country() { Name = "Ukraine" };

            //await repository.CreateAsync(country1);
            //await repository.CreateAsync(country2);
        }
    }
}