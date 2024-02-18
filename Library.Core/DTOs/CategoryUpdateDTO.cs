
using Library.Core.Models;

namespace Library.Core.DTOs
{
    public class CategoryUpdateDTO
    {
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public string Img { get; set; }
    }
}
