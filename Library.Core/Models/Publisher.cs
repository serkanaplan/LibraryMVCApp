
namespace Library.Core.Models
{
    public class Publisher
    {
        public int PublisherId { get; set; }
        public string Name { get; set; }
        public ICollection<Book> Books { get; set; }
    }

}
