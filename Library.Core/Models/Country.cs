
namespace Library.Core.Models
{
    public class Country
    {
        public int CountryId { get; set; }
        public string Name { get; set; }
        public string Img { get; set; }
        public ICollection<Author> Authors { get; set; }
    }
}
