
using Library.Core.Models;
using Library.Core.Repositories;
using Library.Core.Services;
using Library.Core.UnitOfWork;
using Library.ServiceBase.Services;

namespace Library.Service.Services
{
    public class UserService : ServiceBase<User>, IUserService
    {
        public UserService(IRepositoryBase<User> repository, IUnitOfWork unitofwork) : base(repository, unitofwork)
        {
        }
    }
}
