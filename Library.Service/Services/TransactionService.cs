using Library.Core.Repositories;
using Library.Core.Services;
using Library.Core.UnitOfWork;
using Library.ServiceBase.Services;
using System.Transactions;

namespace Library.Service.Services
{
    public class TransactionService : ServiceBase<Transaction>, ITransactionService
    {
        public TransactionService(IRepositoryBase<Transaction> repository, IUnitOfWork unitofwork) : base(repository, unitofwork)
        {
        }
    }
}
