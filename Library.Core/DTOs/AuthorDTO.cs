using Library.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Core.DTOs
{
    public class AuthorDTO
    {
        public int AuthorId { get; set; }
        public string NameSurname { get; set; }
        public string Biography { get; set; }
        public int CountryId { get; set; }
        public string Img { get; set; }
    }
}
