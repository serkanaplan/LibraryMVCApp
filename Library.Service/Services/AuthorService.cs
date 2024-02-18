using Library.Core.Models;
using Library.Core.Repositories;
using Library.Core.Services;
using Library.Core.UnitOfWork;
using Library.ServiceBase.Services;

namespace Library.Service.Services
{
    public class AuthorService : ServiceBase<Author>, IAuthorService
    {
        public AuthorService(IRepositoryBase<Author> repository, IUnitOfWork unitofwork) : base(repository, unitofwork)
        {
        }

    }
}
