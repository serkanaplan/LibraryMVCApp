using System.Linq.Expressions;
using Library.Core.Models;
using Library.Core.Repositories;

namespace Library.Repository.Repositories
{
    public class UserRepository : RepositoryBase<User>, IUserRepository
    {
        public UserRepository(LibraryDbContext context) : base(context)
        {
        }
    }
}