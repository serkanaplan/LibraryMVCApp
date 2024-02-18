using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Core.DTOs
{
    public class BookWithCategoryDTO:BookDTO
    {
        public CategoryDTO Category { get; set; }
    }
}
