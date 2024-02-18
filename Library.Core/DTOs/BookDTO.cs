
using Library.Core.Models;

namespace Library.Core.DTOs
{
    public class BookDTO
    {
        public int BookId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int AuthorId { get; set; }
        public int CategoryId { get; set; }
        public int PublisherId { get; set; }
        public string? Img { get; set; }
        public int LanguageId { get; set; }
        public int Stock { get; set; }
        public bool Status { get; set; }
        public int ShelfId { get; set; }
        public int Rated { get; set; }
        public DateTime CreatedDate { get; set; }
        public int PublishedDate { get; set; }
    }
}
