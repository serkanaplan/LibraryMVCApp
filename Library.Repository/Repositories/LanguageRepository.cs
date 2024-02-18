using Library.Core.Models;
using Library.Core.Repositories;

namespace Library.Repository.Repositories
{
    public class LanguageRepository : RepositoryBase<Language>, ILanguageRepository
    {
        public LanguageRepository(LibraryDbContext context) : base(context)
        {
        }
    }
}