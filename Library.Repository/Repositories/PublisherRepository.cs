using Library.Core.Models;
using Library.Core.Repositories;

namespace Library.Repository.Repositories
{
    public class PublisherRepository : RepositoryBase<Publisher>, IPublisherRepository
    {
        public PublisherRepository(LibraryDbContext context) : base(context)
        {
        }
    }
}