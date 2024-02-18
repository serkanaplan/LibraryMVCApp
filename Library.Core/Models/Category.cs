
namespace Library.Core.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public string Img { get; set; }
        public ICollection<Book> Books { get; set; }
    }
}
