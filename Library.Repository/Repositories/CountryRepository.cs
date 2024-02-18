using Library.Core.Models;
using Library.Core.Repositories;

namespace Library.Repository.Repositories
{
    public class CountryRepository : RepositoryBase<Country>, ICountryRepository
    {
        public CountryRepository(LibraryDbContext context) : base(context)
        {
        }
    }
}