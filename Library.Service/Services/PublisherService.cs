
using Library.Core.Models;
using Library.Core.Repositories;
using Library.Core.Services;
using Library.Core.UnitOfWork;
using Library.ServiceBase.Services;

namespace Library.Service.Services
{
    public class PublisherService : ServiceBase<Publisher>, IPublisherService
    {
        public PublisherService(IRepositoryBase<Publisher> repository, IUnitOfWork unitofwork) : base(repository, unitofwork)
        {
        }

    }
}
