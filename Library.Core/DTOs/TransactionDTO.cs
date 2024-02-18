using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Core.DTOs
{
    public class TransactionDTO
    {
        public int TransactionId { get; set; }
        public int UserId { get; set; }
        public int BookId { get; set; }
        public DateTime TransactionDate { get; set; }
        public DateTime SystemReturnDate { get; set; }
        public DateTime? UserReturnDate { get; set; }
        public bool TransactionStatus { get; set; }
    }
}
