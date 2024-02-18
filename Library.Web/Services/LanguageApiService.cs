using Library.Core.DTOs;

namespace Library.Web.Services
{
    public class LanguageApiService
    {
        private readonly HttpClient _httpClient;

        public LanguageApiService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IEnumerable<LanguageDTO>> GetLanguages()
        {
            var response = await _httpClient.GetFromJsonAsync<IEnumerable<LanguageDTO>>("Language/");
            return response;
        }
    }
}
