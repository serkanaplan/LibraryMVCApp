using Library.Core.DTOs;

namespace Library.Web.Services
{
    public class AuthorApiService
    {
        private readonly HttpClient _httpClient;

        public AuthorApiService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

		public async Task<IEnumerable<AuthorDTO>> GetAuthors()
		{
			var response = await _httpClient.GetFromJsonAsync<IEnumerable<AuthorDTO>>("Author/");

			return response;
		}


		public async Task<AuthorDTO> GetAuthorById(int id)
		{
			var response = await _httpClient.GetFromJsonAsync<AuthorDTO>($"Author/{id}");

			return response;
		}

		public async Task<AuthorDTO> CreateAuthor(AuthorDTO author)
		{
			var response = await _httpClient.PostAsJsonAsync("Author", author);
			if (!response.IsSuccessStatusCode) return null;

			var authorResponse = await response.Content.ReadFromJsonAsync<AuthorDTO>();
			return authorResponse;

		}

		public async Task<bool> UpdateAuthor(AuthorDTO author)
		{
			var response = await _httpClient.PutAsJsonAsync($"Author", author);
			return response.IsSuccessStatusCode;
		}

		public async Task<bool> DeleteAuthor(int id)
		{
			var response = await _httpClient.DeleteAsync($"Author/{id}");

			return response.IsSuccessStatusCode;
		}
	}
}
