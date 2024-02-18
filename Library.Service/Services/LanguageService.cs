using Library.Core.Models;
using Library.Core.Repositories;
using Library.Core.Services;
using Library.Core.UnitOfWork;
using Library.ServiceBase.Services;

namespace Library.Service.Services
{
    public class LanguageService : ServiceBase<Language>, ILanguageService
    {
        public LanguageService(IRepositoryBase<Language> repository, IUnitOfWork unitofwork) : base(repository, unitofwork)
        {
        }
    }
}
