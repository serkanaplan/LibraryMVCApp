using Library.Core.DTOs;

namespace Library.Web.Services
{
    public class BookApiService
    {
        private readonly HttpClient _httpClient;

        public BookApiService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IEnumerable<BookDTO>> GetBooks()
        {
            //api projesindeki book kontrollerinin all metoduna istek attık
            var response = await _httpClient.GetFromJsonAsync<IEnumerable<BookDTO>>("Book/");//url nin öncesini appsettings.json dosyasında tanımladık zaten

            return response;        
        }  
        
        public async Task<List<BooksWithAuthorAndCategoryDTO>> GetBooksWithCategoryAndAuthor()
        {
            //api projesindeki book kontrollerinin all metoduna istek attık
            var response = await _httpClient.GetFromJsonAsync<List<BooksWithAuthorAndCategoryDTO>>("Book/");//url nin öncesini appsettings.json dosyasında tanımladık zaten

            return response;        
        }


        public async Task<BookDTOForUpdate> GetBookById(int id)
        {
            var response = await _httpClient.GetFromJsonAsync<BookDTOForUpdate>($"Book/{id}");

            return response;
        }

        public async Task<BookDTOForInsertion> CreateBook(BookDTOForInsertion book)
        {
            var response = await _httpClient.PostAsJsonAsync("Book", book);
            if (!response.IsSuccessStatusCode) return null;

            var bookResponse = await response.Content.ReadFromJsonAsync<BookDTOForInsertion>();
            return bookResponse;

        }

        public async Task<bool> UpdateBook(BookDTOForUpdate book)
        {
            var response = await _httpClient.PutAsJsonAsync($"Book",book);
            return response.IsSuccessStatusCode;
        }

        public async Task<bool> DeleteBook(int id)
        {
            var response = await _httpClient.DeleteAsync($"Book/{id}");

            return response.IsSuccessStatusCode; 
        }
    }
}
