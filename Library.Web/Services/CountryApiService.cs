using Library.Core.DTOs;

namespace Library.Web.Services
{
    public class CountryApiService
    {
        private readonly HttpClient _httpClient;

        public CountryApiService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IEnumerable<CountryDTO>> GetCountry()
        {
            var response = await _httpClient.GetFromJsonAsync<IEnumerable<CountryDTO>>("Country/");//url nin öncesini appsettings.json dosyasında tanımladık zaten

            return response;
        }
    }
}
