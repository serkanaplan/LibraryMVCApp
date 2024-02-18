using Library.Core.Models;
using Library.Core.Repositories;

namespace Library.Repository.Repositories
{
    public class ShelfRepository : RepositoryBase<Shelf>, IShelfRepository
    {
        public ShelfRepository(LibraryDbContext context) : base(context)
        {
        }
    }
}