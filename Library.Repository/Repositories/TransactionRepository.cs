using System.Transactions;
using Library.Core.Repositories;

namespace Library.Repository.Repositories
{
    public class TransactionRepository : RepositoryBase<Transaction>, ITransactionRepository
    {
        public TransactionRepository(LibraryDbContext context) : base(context)
        {
        }
    }
}