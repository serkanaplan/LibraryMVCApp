using Library.Core.Models;

namespace Library.Core.Repositories
{
    public interface IBookRepository:IRepositoryBase<Book>
    {
        Task<List<Book>> GetBooksWithAuthor();
        Task<List<Book>> GetBooksWithCategory();
        Task<List<Book>> GetBooksWithAuthorAndCategory();

    }
}
