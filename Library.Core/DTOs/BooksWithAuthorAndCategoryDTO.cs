
namespace Library.Core.DTOs
{
    public class BooksWithAuthorAndCategoryDTO:BookDTO
    {
        public AuthorDTO Author { get; set; }
        public CategoryDTO Category { get; set; }
    }
}
