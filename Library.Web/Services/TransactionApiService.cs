namespace Library.Web.Services
{
    public class TransactionApiService
    {
        private readonly HttpClient _httpClient;

        public TransactionApiService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
    }
}
