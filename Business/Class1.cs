using Data.Repositories;

namespace Business
{
    public class Class1
    {
        private ICityRepository CityRepository { get; }

        public Class1(ICityRepository cityRepository)
        {
            CityRepository = cityRepository;
        }


        public City GetCity()
        {
            return CityRepository.Get(new Guid());
        }
    }
}