using Library.Core.DTOs;

namespace Library.Web.Services
{
    public class PublisherApiService
    {
        private readonly HttpClient _httpClient;

        public PublisherApiService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IEnumerable<PublisherDTO>> GetPublishers()
        {
            var response = await _httpClient.GetFromJsonAsync<IEnumerable<PublisherDTO>>("Publisher/");

            return response;
        }
    }
}
