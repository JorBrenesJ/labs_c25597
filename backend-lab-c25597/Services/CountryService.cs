using backend_lab_c25597.models;
using backend_lab.Handlers.backend_lab.Repositories;

namespace backend_lab_c25597.Services
{
    public class CountryService
    {
        private readonly CountryRepository countryRepository;
        public CountryService()
        {
            countryRepository = new CountryRepository();
        }
        public List<CountryModel> GetCountries()
        {
            // Add any missing business logic when it is neccesary
        return countryRepository.GetCountries();
        }
    }
}