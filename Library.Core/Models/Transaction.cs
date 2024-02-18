namespace Library.Core.Models
{
    public class Transaction
    {
        public int TransactionId { get; set; }
        public int UserId { get; set; }
        public int BookId { get; set; }
        public DateTime TransactionDate { get; set; }
        public DateTime SystemReturnDate { get; set; }
        public DateTime? UserReturnDate { get; set; }
        public bool TransactionStatus { get; set; }
        public User Users { get; set; }
        public Book Books { get; set; }
    }
    
}