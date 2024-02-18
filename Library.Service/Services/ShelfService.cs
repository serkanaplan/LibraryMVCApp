
using Library.Core.Models;
using Library.Core.Repositories;
using Library.Core.Services;
using Library.Core.UnitOfWork;
using Library.ServiceBase.Services;

namespace Library.Service.Services
{
    public class ShelfService : ServiceBase<Shelf>, IShelfService
    {
        public ShelfService(IRepositoryBase<Shelf> repository, IUnitOfWork unitofwork) : base(repository, unitofwork)
        {
        }
    }
}
