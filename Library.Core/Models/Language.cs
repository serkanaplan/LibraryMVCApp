
namespace Library.Core.Models
{
    public class Language
    {
        public int LanguageId { get; set; }
        public string Name { get; set; }
        public ICollection<Book> Books { get; set; }
    }
}
