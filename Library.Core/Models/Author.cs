namespace Library.Core.Models
{
    public class Author   
    {
        public int AuthorId { get; set; }
        public string NameSurname { get; set; }
        public string Biography { get; set; }
        public int CountryId { get; set; }
        public string Img { get; set; }
        public ICollection<Book> Books { get; set; }
        public Country Country { get; set; }
    }
}
