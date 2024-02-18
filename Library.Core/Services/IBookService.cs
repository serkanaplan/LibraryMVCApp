using Library.Core.DTOs;
using Library.Core.Models;

namespace Library.Core.Services
{
    public interface IBookService:IServiceBase<Book>
    {
            Task<List<BookWithCategoryDTO>> GetBookWithCategory();
            Task<List<BookWithAuthorDTO>> GetBookWithAuthor();
            Task<List<BooksWithAuthorAndCategoryDTO>> GetBooksWithAuthorAndCategory();

    }
}