using Library.Core.Models;
using Library.Core.Repositories;

namespace Library.Repository.Repositories
{
    public class AuthorRepository : RepositoryBase<Author>, IAuthorRepository
    {
        public AuthorRepository(LibraryDbContext context) : base(context)
        {
        }
    }
}