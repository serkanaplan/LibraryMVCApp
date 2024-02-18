namespace Library.Core.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string Tin { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public bool Gender { get; set; }
        public string Img { get; set; }
        public string Email { get; set; } 
        public string Password { get; set; } 
        public bool Role { get; set; }
        public bool RegistrationStatus { get; set; }
        public int ReadBookCount { get; set; }
        public DateTime MembershipDate { get; set; }
        public DateTime? PenaltyDate { get; set; }
        public ICollection<Transaction>  Transaction { get; set; } 
    }
}
