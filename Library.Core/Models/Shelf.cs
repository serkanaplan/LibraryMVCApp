using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Core.Models
{
    public class Shelf
    {
        public int ShelfId { get; set; }
        public string Name { get; set; }
        public ICollection<Book> Books { get; set; }
    }
}
