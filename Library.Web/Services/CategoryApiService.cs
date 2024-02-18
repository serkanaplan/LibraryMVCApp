using Library.Core.DTOs;
using Library.Core.Models;

namespace Library.Web.Services
{
    public class CategoryApiService
    {
        private readonly HttpClient _httpClient;

        public CategoryApiService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IEnumerable<CategoryDTO>> GetCategories()
        {
            var response = await _httpClient.GetFromJsonAsync<IEnumerable<CategoryDTO>>("category");

            return response;

        }
    }
}
