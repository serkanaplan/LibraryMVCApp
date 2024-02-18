using Library.Core.DTOs;
using System.Net.Http;

namespace Library.Web.Services
{
    public class ShelfApiService
    {
        private readonly HttpClient _httpClient;

        public ShelfApiService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IEnumerable<ShelfDTO>> GetShelves()
        {
          var response = await _httpClient.GetFromJsonAsync<IEnumerable<ShelfDTO>>("Shelf/");
            return response;
        }
    }
}
