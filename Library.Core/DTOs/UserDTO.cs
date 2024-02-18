using Library.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Core.DTOs
{
    public class UserDTO
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
    }
}
