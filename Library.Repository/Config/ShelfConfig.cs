using Library.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Library.Repository.Config
{
    public class ShelfConfig : IEntityTypeConfiguration<Shelf>
    {
        public void Configure(EntityTypeBuilder<Shelf> builder)
        {

            builder.HasData(
            new Shelf { ShelfId = 1, Name = "A1" },
            new Shelf { ShelfId = 2, Name = "A2" },
            new Shelf { ShelfId = 3, Name = "A3" },
            new Shelf { ShelfId = 4, Name = "B1" },
            new Shelf { ShelfId = 5, Name = "B2" },
            new Shelf { ShelfId = 6, Name = "B3" },
            new Shelf { ShelfId = 7, Name = "C1" },
            new Shelf { ShelfId = 8, Name = "C2" },
            new Shelf { ShelfId = 9, Name = "C3" },
            new Shelf { ShelfId = 10, Name = "D1" },
            new Shelf { ShelfId = 11, Name = "D2" },
            new Shelf { ShelfId = 12, Name = "D3" },
            new Shelf { ShelfId = 13, Name = "E1" },
            new Shelf { ShelfId = 14, Name = "E2" },
            new Shelf { ShelfId = 15, Name = "E3" }
        );
        }
    }
}
