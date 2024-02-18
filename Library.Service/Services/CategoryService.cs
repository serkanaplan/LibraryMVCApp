using Library.Core.Models;
using Library.Core.Repositories;
using Library.Core.Services;
using Library.Core.UnitOfWork;
using Library.ServiceBase.Services;

namespace Library.Service.Services
{
    public class CategoryService : ServiceBase<Category>, ICategoryService
    {
        public CategoryService(IRepositoryBase<Category> repository, IUnitOfWork unitofwork) : base(repository, unitofwork)
        {
        }
    }
}
