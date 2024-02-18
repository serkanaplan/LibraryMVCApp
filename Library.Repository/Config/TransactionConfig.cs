using Library.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Library.Repository.Config
{
    public class TransactionConfig:IEntityTypeConfiguration<Transaction>
    {
        public void Configure(EntityTypeBuilder<Transaction> builder)
        {
            builder.HasData(
         new Transaction { TransactionId = 1, UserId = 1, BookId = 1, },
         new Transaction { TransactionId = 2, UserId = 2, BookId = 2, },
         new Transaction { TransactionId = 3, UserId = 3, BookId = 3, },
         new Transaction { TransactionId = 4, UserId = 4, BookId = 4, },
         new Transaction { TransactionId = 5, UserId = 5, BookId = 5, },
         new Transaction { TransactionId = 6, UserId = 6, BookId = 6, },
         new Transaction { TransactionId = 7, UserId = 7, BookId = 7, },
         new Transaction { TransactionId = 8, UserId = 8, BookId = 8, }
        );
        }
    }
}