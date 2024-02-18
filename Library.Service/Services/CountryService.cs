using Library.Core.Models;
using Library.Core.Repositories;
using Library.Core.Services;
using Library.Core.UnitOfWork;
using Library.ServiceBase.Services;

namespace Library.Service.Services
{
    public class CountryService : ServiceBase<Country>, ICountryService
    {
        public CountryService(IRepositoryBase<Country> repository, IUnitOfWork unitofwork) : base(repository, unitofwork)
        {
        }
    }
}
