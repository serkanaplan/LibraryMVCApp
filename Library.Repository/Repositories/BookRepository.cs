

using Library.Core.Models;
using Library.Core.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Library.Repository.Repositories
{
    public class BookRepository : RepositoryBase<Book>, IBookRepository
    {
        public BookRepository(LibraryDbContext context) : base(context)
        {
        }

        public Task<List<Book>> GetBooksWithAuthor()
        {
            return _context.Books.Include(x => x.Author).ToListAsync();
        }

        public Task<List<Book>> GetBooksWithAuthorAndCategory()
        {
            return _context.Books.Include(x => x.Author).Include(x => x.Category).ToListAsync();
        }

        public Task<List<Book>> GetBooksWithCategory()
        {
            return _context.Books.Include(x => x.Category).ToListAsync();
        }
    }
}
