namespace Library.Core.Models
{
    public class Book
    {
        public int BookId { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
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
        public Shelf Shelf { get; set; }
        public Author Author { get; set; }
        public Category Category { get; set; }    
        public Publisher Publisher { get; set; }
        public Language Language { get; set; }
        public ICollection<Transaction>  Transaction { get; set; } 

    }
}

